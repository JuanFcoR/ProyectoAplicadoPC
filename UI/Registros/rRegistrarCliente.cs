﻿using ProyectoAplicadoPC.BLL;
using ProyectoAplicadoPC.Entidades;
using ProyectoAplicadoPC.UI.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAplicadoPC.UI.Registros
{
    public partial class rRegistrarCliente : Form
    {
        public rRegistrarCliente()
        {
            InitializeComponent();
        }

        public rRegistrarCliente(Clientes c)
        {
            InitializeComponent();
            LlenarCampos(c);
        }

        private void limpiar()
        {
            CodigonumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            NombretextBox.Text = string.Empty;
            ApellidotextBox.Text = string.Empty;
            CedulamaskedTextBox.Text = string.Empty;
            TelefonomaskedTextBox.Text = string.Empty;
            CelularmaskedTextBox.Text = string.Empty;
            TelefonoDeReferenciamaskedTextBox.Text = string.Empty;
            DirecciontextBox.Text = string.Empty;
            LimiteDeCreditomaskedTextBox.Text = string.Empty;

        }
        private Clientes llenarClase()
        {
            Clientes c = new Clientes();
            c.Codigo=Convert.ToInt32(CodigonumericUpDown.Value);
            c.Fecha = FechadateTimePicker.Value;
            c.Nombre = NombretextBox.Text;
            c.Apellido = ApellidotextBox.Text;
            c.Cedula=CedulamaskedTextBox.Text;
            c.Telefono=TelefonomaskedTextBox.Text;
            c.Celular=CelularmaskedTextBox.Text;
            c.TelefonoDeReferencia=TelefonoDeReferenciamaskedTextBox.Text;
            c.Direccion=DirecciontextBox.Text;
            c.LimiteDeCredito=Convert.ToSingle(LimiteDeCreditomaskedTextBox.Text);


            return c;
        }

        private bool ExisteEnLaBasedeDatos()
        {
            Clientes Cliente = ClientesBLL.Buscar((int)CodigonumericUpDown.Value);
            return (Cliente != null);
        }

        private bool Validar()
        {
            bool paso = true;

            {
                if (String.IsNullOrWhiteSpace(NombretextBox.Text))
                {
                    SuperErrorProvider.SetError(NombretextBox, "Este campo no debe estar vacio");
                    NombretextBox.Focus();
                    paso = false;
                }

                if (String.IsNullOrWhiteSpace(ApellidotextBox.Text))
                {
                    SuperErrorProvider.SetError(ApellidotextBox, "Este campo no debe estar vacio");
                    ApellidotextBox.Focus();
                    paso = false;
                }

                if (String.IsNullOrWhiteSpace(CedulamaskedTextBox.Text))
                {
                    SuperErrorProvider.SetError(CedulamaskedTextBox, "Este campo no debe estar vacio");
                    CedulamaskedTextBox.Focus();
                    paso = false;
                }

                if (String.IsNullOrWhiteSpace(TelefonomaskedTextBox.Text))
                {
                    SuperErrorProvider.SetError(TelefonomaskedTextBox, "Este campo no debe estar vacio");
                    TelefonomaskedTextBox.Focus(); 
                    paso = false;
                }

                if (String.IsNullOrWhiteSpace(CelularmaskedTextBox.Text))
                {
                    SuperErrorProvider.SetError(CelularmaskedTextBox, "Este campo no debe estar vacio");
                    CelularmaskedTextBox.Focus();
                    paso = false;
                }

                if (String.IsNullOrWhiteSpace(TelefonoDeReferenciamaskedTextBox.Text))
                {
                    SuperErrorProvider.SetError(TelefonoDeReferenciamaskedTextBox, "Este campo no debe estar vacio");
                    TelefonoDeReferenciamaskedTextBox.Focus();
                    paso = false;
                }

                if (String.IsNullOrWhiteSpace(TelefonoDeReferenciamaskedTextBox.Text))
                {
                    SuperErrorProvider.SetError(TelefonoDeReferenciamaskedTextBox, "Este campo no debe estar vacio");
                    TelefonoDeReferenciamaskedTextBox.Focus();
                    paso = false;
                }

                if (String.IsNullOrWhiteSpace(DirecciontextBox.Text))
                {
                    SuperErrorProvider.SetError(DirecciontextBox, "Este campo no debe estar vacio");
                    DirecciontextBox.Focus();
                    paso = false;
                }

            }

            return paso;
        }

        private void LlenarCampos(Clientes c)
        {

            CodigonumericUpDown.Value=c.Codigo;
            FechadateTimePicker.Value = c.Fecha;
            NombretextBox.Text = c.Nombre;
            ApellidotextBox.Text = c.Apellido;
            CedulamaskedTextBox.Text = c.Cedula;
            TelefonomaskedTextBox.Text = c.Telefono;
            CelularmaskedTextBox.Text= c.Celular;
            TelefonoDeReferenciamaskedTextBox.Text = c.TelefonoDeReferencia;
            DirecciontextBox.Text = c.Direccion;
            LimiteDeCreditomaskedTextBox.Text = c.LimiteDeCredito.ToString()  ;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Clientes Cliente;
            bool paso = false;


            if (!Validar())
                return;
            Cliente = llenarClase();
            //limpiar();

            if (CodigonumericUpDown.Value == 0)
            {
                paso = ClientesBLL.Guardar(Cliente);
            }
            else
            {
                if (!ExisteEnLaBasedeDatos())
                {
                    MessageBox.Show("No se puede modificar un Cliente que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = ClientesBLL.Modificar(Cliente);
            }
            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
                MessageBox.Show("No se pudo guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void BuscarButton_Click_1(object sender, EventArgs e)
        {
            cClientes cp = new cClientes();
            this.Hide();
            cp.ShowDialog();
        }

        private void Cerrar_pictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximixar_pictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Maximixar_pictureBox.Visible = false;
            Restaurar_pictureBox.Visible = true;
        }

        private void Minimizar_pictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Restaurar_pictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Restaurar_pictureBox.Visible = false;
            Maximixar_pictureBox.Visible = true;
        }
    }
}
