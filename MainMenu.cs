using ProyectoAplicadoPC.UI.Registros;
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

namespace ProyectoAplicadoPC
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void RegistroDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rRegistrarCliente cliente = new rRegistrarCliente(); 
            cliente.ShowDialog();
        }

        private void RegistarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarProducto producto = new RegistrarProducto();
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
            rRegistrarCliente cliente = new rRegistrarCliente();
            cliente.ShowDialog();
        }

        private void ConsultarCliente_button_Click(object sender, EventArgs e)
        {
            SubMenuClientes.Visible = false;
            cClientes cliente = new cClientes();
            cliente.ShowDialog();
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
           
            RegistrarProducto rp = new RegistrarProducto();
            rp.ShowDialog();
            SubMenuP_panel.Visible = false;
        }

        private void ConsultarP_button_Click(object sender, EventArgs e)
        {
            cProductos cp = new cProductos();
            cp.ShowDialog();
            SubMenuP_panel.Visible = false;
        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
