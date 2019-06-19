using ProyectoAplicadoPC.BLL;
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
    public partial class rProducto : Form
    {
        public rProducto()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            CodigoNumericUpDown.Value = 0;
            DescripcionTextBox.Text = String.Empty;
            FechaDateTimePicker.Value = DateTime.Now;
            
            SuperErrorProvider.Clear();
        }
        private Productos llenarClase()
        {
            Productos Producto = new Productos();
            Producto.CodigoProducto = Convert.ToInt32(CodigoNumericUpDown.Value);
            Producto.Descripcion = DescripcionTextBox.Text.ToString();
            Producto.FechaRegistro = FechaDateTimePicker.Value;

            return Producto;
        }

        private bool ExisteEnLaBasedeDatos()
        {
            Productos Producto = ProductosBLL.Buscar(Convert.ToInt32(CodigoNumericUpDown.Value));
            return (Producto != null);
        }

        private void LlenarCampos(Productos Producto)
        {
            CodigoNumericUpDown.Value = Producto.CodigoProducto;
            DescripcionTextBox.Text = Producto.Descripcion;
            FechaDateTimePicker.Value = Producto.FechaRegistro;            
        }

        private bool Validar()
        {
            bool paso = true;

            
                if (String.IsNullOrWhiteSpace(DescripcionTextBox.Text))
                {
                    SuperErrorProvider.SetError(DescripcionTextBox, "Este campo no debe estar vacio");
                    DescripcionTextBox.Focus();
                    paso = false;
                }


            

            return paso;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Productos Producto;
            bool paso = false;


            if (!Validar())
                return;
            Producto = llenarClase();
            limpiar();

            if (CodigoNumericUpDown.Value == 0)
            {
                paso = ProductosBLL.Guardar(Producto);
            }
            else
            {
                if (!ExisteEnLaBasedeDatos())
                {
                    MessageBox.Show("No se puede modificar un producto que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = ProductosBLL.Modificar(Producto);
            }
            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);


            else
                MessageBox.Show("No se pudo guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
    }
}
