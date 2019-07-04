﻿using ProyectoAplicadoPC.BLL;
using ProyectoAplicadoPC.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAplicadoPC.UI
{
    public partial class cProductos : Form
    {
        public cProductos()
        {
            InitializeComponent();
        }

        private void CProductos_Load(object sender, EventArgs e)
        {
            var listado = new List<Producto>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltrarComboBox.SelectedIndex)
                {
                    case 0://Todo
                        listado =ProductosBLL.GetList(p => true);
                        break;

                    case 1:
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        listado =ProductosBLL.GetList(p => p.CodigoProducto == id);
                        break;

                    case 2:
                        listado =ProductosBLL.GetList(p => p.Descripcion.Contains(CriterioTextBox.Text));
                        break;

                    case 3:
                        listado =ProductosBLL.GetList(p => p.Departamento.Contains(CriterioTextBox.Text));
                        break;

                    case 4:
                        int minimo = Convert.ToInt32(CriterioTextBox.Text);
                        listado =ProductosBLL.GetList(p => p.Minimo==minimo);
                        break;

                    case 5:
                        listado = ProductosBLL.GetList(p => true);
                        listado = listado.Where(c => c.FechaRegistro.Date >= DesdeDateTimePicker.Value.Date && c.FechaRegistro.Date <= HastaDateTimePicker.Value.Date).ToList();
                        break;

                }
                listado = listado.Where(c => c.FechaRegistro.Date >= DesdeDateTimePicker.Value.Date && c.FechaRegistro.Date <= HastaDateTimePicker.Value.Date).ToList();

            }
            else
            {
                listado =ProductosBLL.GetList(p => true);
            }

            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;
        }

        private void CProductos_Load_2(object sender, EventArgs e)
        {
            var listado = new List<Producto>();
            listado = ProductosBLL.GetList(p => true);
            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrarProducto rp = new RegistrarProducto();
            rp.ShowDialog();
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            int id;
            Producto p = new Producto();
            int.TryParse(ConsultaDataGridView.CurrentRow.Cells[0].Value.ToString(), out id);
            p = ProductosBLL.Buscar(id);
            RegistrarProducto rp = new RegistrarProducto(p);
            this.Hide();
            rp.ShowDialog();
        }

        private void Cerrar_pictureBox_Click(object sender, EventArgs e)
        {
            Dispose();
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


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ConsultaButton_Click(object sender, EventArgs e)
        {

        }
    }

    
}
