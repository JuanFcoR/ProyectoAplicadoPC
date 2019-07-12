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

namespace ProyectoAplicadoPC.UI.Registros
{
    public partial class rVentas : Form
    {
        public rVentas()
        {
            InitializeComponent();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {

        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {

        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {

        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {

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

        private void RVentas_Load(object sender, EventArgs e)
        {

        }
    }
}
