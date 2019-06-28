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

        private void ConsultaButton_Click(object sender, EventArgs e)
        {
            var listado = new List<Clientes>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltrarComboBox.SelectedIndex)
                {
                    case 0://Todo
                        listado = ClientesBLL.GetList(p => true);
                        break;

                    case 1:
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        listado = ClientesBLL.GetList(p => p.Codigo == id);
                        break;

                    case 2:
                        listado = ClientesBLL.GetList(p => p.Nombre.Contains(CriterioTextBox.Text));
                        break;

                    case 3:
                        listado = ClientesBLL.GetList(p => p.Apellido.Contains(CriterioTextBox.Text));
                        break;

                    case 4:
                        listado = ClientesBLL.GetList(p => p.Telefono.Contains(CriterioTextBox.Text));
                        break;

                    case 5:
                        listado = ClientesBLL.GetList(p => true);
                        listado = listado.Where(c => c.Fecha.Date >= DesdeDateTimePicker.Value.Date && c.Fecha.Date <= HastaDateTimePicker.Value.Date).ToList();
                        break;

                }
                listado = listado.Where(c => c.Fecha.Date >= DesdeDateTimePicker.Value.Date && c.Fecha.Date <= HastaDateTimePicker.Value.Date).ToList();

            }
            else
            {
                listado = ClientesBLL.GetList(p => true);
            }

            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            int id;
            Clientes p = new Clientes();
            int.TryParse(ConsultaDataGridView.CurrentRow.Cells[0].Value.ToString(), out id);
            p = ClientesBLL.Buscar(id);
            rRegistrarCliente rp = new rRegistrarCliente(p);
            this.Hide();
            rp.ShowDialog();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            rRegistrarCliente rc = new rRegistrarCliente();
            rc.ShowDialog();
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
