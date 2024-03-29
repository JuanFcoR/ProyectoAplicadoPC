﻿using ProyectoAplicadoPC.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ProyectoAplicadoPC.UI.Consultas;
using ProyectoAplicadoPC.UI;
using ProyectoAplicadoPC.BLL;
using ProyectoAplicadoPC.Entidades;

namespace ProyectoAplicadoPC
{
    public partial class MainMenu : Form
    {
        public int IdUsuario;
        public MainMenu(int IdUsuario)
        {
            InitializeComponent();
            this.IdUsuario = IdUsuario;
            MostrarUsuario(IdUsuario);
        }

        private void MostrarUsuario(int id)
        {

            if (id > 0)
            {
                RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
                Usuarios usuario = repositorio.Buscar(id);

                Usuario_label.Text = usuario.Usuario.ToString();
                Permiso_label.Text = usuario.Permiso.ToString();
            }
            else
            {
                Usuario_label.Text = "Admin";
                Permiso_label.Text = "Administrador";
            }
        }

        private void RegistroDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rClientes cliente = new rClientes(); 
            cliente.ShowDialog();
        }

        private void RegistarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rProductos producto = new rProductos();
            producto.ShowDialog();
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

        private void Restaurar_pictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Restaurar_pictureBox.Visible = false;
            Maximixar_pictureBox.Visible = true;
        }

        private void Minimizar_pictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void Clientes_button_Click(object sender, EventArgs e)
        {
            if(SubMenuClientes.Visible == true)
            {
                SubMenuClientes.Visible = false;
            }
            else
            {
                SubMenuClientes.Visible = true;
            }
            
        }

        private void RegistrarCliente_button_Click(object sender, EventArgs e)
        {

            SubMenuClientes.Visible = false;
            rClientes cliente = new rClientes();
            cliente.ShowDialog();
        }

        private void ConsultarCliente_button_Click(object sender, EventArgs e)
        {
            SubMenuClientes.Visible = false;
            cClientes cC = new cClientes();
            cC.ShowDialog();
        }

        private void Productos_button_Click(object sender, EventArgs e)
        {
            if(SubMenuP_panel.Visible == true)
            {
                SubMenuP_panel.Visible = false;
            }
            else
            {
                SubMenuP_panel.Visible = true;
            }
        }

        private void RegistarP_button_Click(object sender, EventArgs e)
        {
           
            rProductos rp = new rProductos();
            rp.ShowDialog();
            SubMenuP_panel.Visible = false;
        }

        

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void RegistrarVenta_Button_Click(object sender, EventArgs e)
        {
            rVentas rv = new rVentas();
            rv.ShowDialog();
        }

        private void ConsultarVenta_button_Click(object sender, EventArgs e)
        {
            cVentas cv = new cVentas();
            cv.ShowDialog();
        }

        private void Ventas_button_Click(object sender, EventArgs e)
        {
            if (SubMenuV_panel.Visible == true)
            {
                SubMenuV_panel.Visible = false;
            }
            else
            {
                SubMenuV_panel.Visible = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            rLogin rl = new rLogin();
            rl.Dispose();
            rl.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            rCobros rc = new rCobros();
            rc.ShowDialog();
        }
    }
}
