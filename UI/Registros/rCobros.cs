using ProyectoAplicadoPC.BLL;
using ProyectoAplicadoPC.Entidades;
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
    public partial class rCobros : Form
    {
        public rCobros()
        {
            InitializeComponent();
        }


        private void limpiar()
        {
            CodigoDelClientenumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            NombretextBox.Text = string.Empty;
            CedulamaskedTextBox.Text = string.Empty;
            CantidadAbonarnumericUpDown.Value = 0;
            DeudaActualnumericUpDown.Value = 0;
          
    

        }
        private Cobros llenarClase()
        {
            Cobros c = new Cobros();
            c.IdCliente = Convert.ToInt32(CodigoDelClientenumericUpDown.Value);
            c.Fecha = FechadateTimePicker.Value;
            c.Nombre = NombretextBox.Text;
            c.Deuda = Convert.ToDecimal(DeudaActualnumericUpDown.Value);
            c.Abonado = Convert.ToDecimal(CantidadAbonarnumericUpDown.Value);
            c.Fecha = FechadateTimePicker.Value;



            return c;
        }
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Cobros cobros = new Cobros();
            RepositorioBase<Cobros> db = new RepositorioBase<Cobros>();

            bool paso = false;
            if (!Validar())
                return;

            cobros = llenarClase();



            //Determinar si es guardar o modificar
            if (CodigoDelClientenumericUpDown.Value == 0)
                paso = db.Guardar(cobros);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("no se puede modificar", "exixte un fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = db.Modificar(cobros);
            }

            //infprmar el resultado
            if (paso)
            {
                MessageBox.Show("Guardado", "exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
            else
                MessageBox.Show("Nose pudo guardar", "fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private bool Validar()
        {
            bool paso = true;

            {
                if (String.IsNullOrWhiteSpace(NombretextBox.Text))
                {
                    SuperErrorProvider.SetError(NombretextBox, "Este campo no debe estar vacio");
                    NombretextBox.Focus();
                    paso = false;
                }

             

                if (String.IsNullOrWhiteSpace(CedulamaskedTextBox.Text))
                {
                    SuperErrorProvider.SetError(CedulamaskedTextBox, "Este campo no debe estar vacio");
                    CedulamaskedTextBox.Focus();
                    paso = false;
                }

                if (String.IsNullOrWhiteSpace(CodigoDelClientenumericUpDown.Text))
                {
                    SuperErrorProvider.SetError( CodigoDelClientenumericUpDown, "Este campo no debe estar vacio");
                    CodigoDelClientenumericUpDown.Focus();
                    paso = false;
                }

                if (String.IsNullOrWhiteSpace(DeudaActualnumericUpDown.Text))
                {
                    SuperErrorProvider.SetError(DeudaActualnumericUpDown, "Este campo no debe estar vacio");
                    DeudaActualnumericUpDown.Focus();
                    paso = false;
                }

                if (String.IsNullOrWhiteSpace(CantidadAbonarnumericUpDown.Text))
                {
                    SuperErrorProvider.SetError(CantidadAbonarnumericUpDown, "Este campo no debe estar vacio");
                    CantidadAbonarnumericUpDown.Focus();
                    paso = false;
                }

               

            }

            return paso;
        }
        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            Cobros cobros = new Cobros();
            RepositorioBase<Cobros> db = new RepositorioBase<Cobros>();
            int.TryParse(CodigoDelClientenumericUpDown.Text, out int Id);
            cobros = db.Buscar(Id);
            return cobros != null;
        }
    }
}
