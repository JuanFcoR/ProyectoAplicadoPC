﻿using ProyectoAplicadoPC.BLL;
using ProyectoAplicadoPC.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAplicadoPC.UI.Registros
{
    public partial class rProductos : Form
    {
        public rProductos()
        {
            InitializeComponent();
        }

        public rProductos(Productos p)
        {
            InitializeComponent();
            LlenarCampos(p);
        }

        private void limpiar()
        {
            CodigoRegistroNumericUpDown.Value = 0;
            DescripcionTextBox.Text = String.Empty;
            PreciocostoNumericUpDown.Value = 0;
            PrecioVentaNumericUpDown.Value = 0;
            ITBIsNumericUpDown.Value = 0;
            TasaDeGananciaNumericUpDown.Value = 0;
            DepartamentoTextBox.Text = String.Empty;
            CantidadExistenteNumericUpDown.Value = 0;
            MinimonumericUpDown.Value = 0;
            FechaDateTimePicker.Value = DateTime.Now;
            SuperErrorProvider.Clear();
        }
        private Productos llenarClase()
        {
            Productos Pro = new Productos();
            Pro.CodigoProducto = Convert.ToInt32(CodigoRegistroNumericUpDown.Value);
            Pro.Descripcion = DescripcionTextBox.Text.ToString();
            Pro.CantidadExistente = Convert.ToInt32(CantidadExistenteNumericUpDown.Value);
            Pro.PrecioCosto = Convert.ToSingle(PreciocostoNumericUpDown.Value);
            Pro.Departamento = DepartamentoTextBox.Text;
            Pro.Minimo = Convert.ToInt32(MinimonumericUpDown.Value);
            Pro.FechaRegistro = FechaDateTimePicker.Value.ToString("dd/MM/yyyy");
            Pro.PrecioVenta = Convert.ToSingle(PrecioVentaNumericUpDown.Value);
            Pro.TasaDeGanancia = Convert.ToSingle(TasaDeGananciaNumericUpDown.Value);
            Pro.ITBIS = Convert.ToSingle(ITBIsNumericUpDown.Value);


            return Pro;
        }

        private bool ExisteEnLaBasedeDatos()
        {
            Productos Pro = ProductosBLL.Buscar((int)CodigoRegistroNumericUpDown.Value);
            return (Pro != null);
        }

        private bool Validar()
        {
            bool paso = true;

            {
                if (String.IsNullOrWhiteSpace(DescripcionTextBox.Text))
                {
                    SuperErrorProvider.SetError(DescripcionTextBox, "Este campo no debe estar vacio");
                    paso = false;
                }

                if (String.IsNullOrWhiteSpace(DepartamentoTextBox.Text))
                {
                    SuperErrorProvider.SetError(DepartamentoTextBox, "Este campo no debe estar vacio");
                    paso = false;
                }

                if (MinimonumericUpDown.Value < 1)
                {
                    SuperErrorProvider.SetError(MinimonumericUpDown, "Este campo no puede ser menor de 1");
                    paso = false;
                }

                if(PrecioVentaNumericUpDown.Value < PreciocostoNumericUpDown.Value)
                {
                    SuperErrorProvider.SetError(PrecioVentaNumericUpDown, "El  precio de compra no puede ser menor al precio de venta");
                    paso = false;
                }

            }

            return paso;
        }

        private void LlenarCampos(Productos Pro)
        {
            FechaDateTimePicker.Value = DateTime.ParseExact(Pro.FechaRegistro, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            CodigoRegistroNumericUpDown.Value = Pro.CodigoProducto;
            DescripcionTextBox.Text = Pro.Descripcion;
            CantidadExistenteNumericUpDown.Value = Pro.CantidadExistente;
            PreciocostoNumericUpDown.Value = Convert.ToDecimal(Pro.PrecioCosto);
            PrecioVentaNumericUpDown.Value = Convert.ToDecimal(Pro.PrecioVenta);
            ITBIsNumericUpDown.Value = 0;
            DepartamentoTextBox.Text = Pro.Departamento;
            MinimonumericUpDown.Value = Pro.Minimo;
            TasaDeGananciaNumericUpDown.Value = Convert.ToDecimal(Pro.TasaDeGanancia);
        }

        

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Productos producto;
            bool paso = false;


            if (!Validar())
                return;

            try
            {
                producto = llenarClase();

                if (CodigoRegistroNumericUpDown.Value == 0)
                {
                    paso = ProductosBLL.Guardar(producto);
                    MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (!ExisteEnLaBasedeDatos())
                    {
                        MessageBox.Show("No se puede modificar un producto que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    paso = ProductosBLL.Modificar(producto);
                    MessageBox.Show("Se modifico con exito!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (!paso)
                    MessageBox.Show("No se pudo guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            cProductos cp = new cProductos();
            this.Hide();
            cp.ShowDialog();
        }

    private void CancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void Minimizar_pictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        private void Restaurar_pictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Maximixar_pictureBox.Visible = true;
            Restaurar_pictureBox.Visible = false;
        }

        private void Maximixar_pictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Maximixar_pictureBox.Visible = false;
            Restaurar_pictureBox.Visible = true;
        }

        private void Cerrar_pictureBox_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
