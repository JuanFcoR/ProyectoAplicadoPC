using ProyectoAplicadoPC.BLL;
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
            var listado = new List<Productos>();

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
                        listado =ProductosBLL.GetList(p => p.Comentario.Contains(CriterioTextBox.Text));
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
            var listado = new List<Productos>();
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
            Productos p = new Productos();
            int.TryParse(ConsultaDataGridView.CurrentRow.Cells[0].Value.ToString(), out id);
            p = ProductosBLL.Buscar(id);
            RegistrarProducto rp = new RegistrarProducto(p);
            this.Hide();
            rp.ShowDialog();
        }

       
    }

    
}
