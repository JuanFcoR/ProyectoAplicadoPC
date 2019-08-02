using ProyectoAplicadoPC.BLL;
using ProyectoAplicadoPC.DAL;
using ProyectoAplicadoPC.Entidades;
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

namespace ProyectoAplicadoPC.UI.Consultas
{
    public partial class cClientes : Form
    {
        public cClientes()
        {
            InitializeComponent();
        }



        private void CClientes_Load(object sender, EventArgs e)
        {
            var listado = new List<Clientes>();
            listado = ClientesBLL.GetList(p => true);
            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;
        }

        private void ConsultaButton_Click_1(object sender, EventArgs e)
        {
            var listado = new List<Clientes>();
            Contexto c = new Contexto();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltrarComboBox.SelectedIndex)
                {
                    case 0://Todo
                        listado = ClientesBLL.GetList(p => true);
                        break;

                    case 1:
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        listado = ClientesBLL.GetList(p => p.CodigoCliente == id);
                        break;

                    case 2:
                        listado = ClientesBLL.GetList(p => p.Nombre.Contains(CriterioTextBox.Text));
                        break;

                    case 3:
                        listado = ClientesBLL.GetList(p => p.Apellidos.Contains(CriterioTextBox.Text));
                        break;

                    case 4:
                        listado = ClientesBLL.GetList(p => p.Telefono.Contains(CriterioTextBox.Text));
                        break;

                    case 5:
                        
                        listado = ClientesBLL.GetList(p => true);
                        listado = listado.Where(p => DateTime.Parse(p.Fecha) >= DesdeDateTimePicker.Value.Date && DateTime.Parse(p.Fecha) <= HastaDateTimePicker.Value.Date).ToList();
                        break;

                }
                listado = listado.Where(p => DateTime.Parse(p.Fecha) >= DesdeDateTimePicker.Value.Date && DateTime.Parse(p.Fecha) <= HastaDateTimePicker.Value.Date).ToList();

            }
            else
            {
                listado = ClientesBLL.GetList(p => true);
            }

            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;
        }

        private void EditarButton_Click_1(object sender, EventArgs e)
        {
            int id;
            Clientes p = new Clientes();
            int.TryParse(ConsultaDataGridView.CurrentRow.Cells[0].Value.ToString(), out id);
            p = ClientesBLL.Buscar(id);
            rClientes rp = new rClientes(p);
            this.Hide();
            rp.ShowDialog();
        }

        private void NuevoButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            rClientes rc = new rClientes();
            rc.ShowDialog();
        }

        private void CerrarButton_Click_1(object sender, EventArgs e)
        {
            Close();
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

        private void CriterioTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
