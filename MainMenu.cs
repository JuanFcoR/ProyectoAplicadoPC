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
            rCliente cliente = new rCliente();
            cliente.Show();
        }

        private void RegistarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarProducto producto = new RegistrarProducto();
            producto.Show();
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
    }
}
