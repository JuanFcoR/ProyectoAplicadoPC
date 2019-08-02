using ProyectoAplicadoPC.BLL;
using ProyectoAplicadoPC.Entidades;
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

namespace ProyectoAplicadoPC.UI.Consultas
{
    public partial class cVentas : Form
    {
        public cVentas()
        {
            InitializeComponent();
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

        private void ConsultaButton_Click(object sender, EventArgs e)
        {

        }

        private void CVentas_Load(object sender, EventArgs e)
        {
            var listado = new List<Ventas>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltrarComboBox.SelectedIndex)
                {
                    case 0://Todo
                        listado = VentasBLL.GetList(p => true);
                        break;

                    case 1:
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        //listado = VentasBLL.GetList(p => p.CodigoCliente == id);
                        break;

                        //break;

                //    case 5:
                //        listado = VentasBLL.GetList(p => true);
                //        /listado = listado.Where(c => DateTime.Parse(c.Fecha) >= DesdeDateTimePicker.Value.Date && DateTime.Parse(c.Fecha) <= HastaDateTimePicker.Value.Date).ToList();
                //        break;

                }
                //listado = listado.Where(c => DateTime.Parse(c.Fecha) >= DesdeDateTimePicker.Value.Date && DateTime.Parse(c.Fecha) <= HastaDateTimePicker.Value.Date).ToList();

            }
            else
            {
                listado = VentasBLL.GetList(p => true);
            }

            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            int id=0;
            Ventas p = new Ventas();
            int.TryParse(ConsultaDataGridView.CurrentRow.Cells[0].Value.ToString(), out id);
            p = VentasBLL.Buscar(id);
            rVentas rp = new rVentas(p);
            this.Hide();
            rp.ShowDialog();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            rVentas rp = new rVentas();
            this.Hide();
            rp.ShowDialog();
        }
    }
    
}
