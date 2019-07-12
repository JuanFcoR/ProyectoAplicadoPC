using ProyectoAplicadoPC.BLL;
using ProyectoAplicadoPC.Entidades;
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
    public partial class RegistrarProducto : Form
    {
        public RegistrarProducto()
        {
            InitializeComponent();
        }

        public RegistrarProducto(Productos p)
        {
            InitializeComponent();
            LlenarCampos(p);
        }

        private void limpiar()
        {
            CodigoRegistroNumericUpDown.Value = 0;
            DescripcionTextBox.Text = String.Empty;
            PreciocostoNumericUpDown.Value = 0;
            PrecioVentaNumericUpDown.Value = 0;
            ITBIsNumericUpDown.Value = 0;
            TasaDeGananciaNumericUpDown.Value = 0;
            DepartamentoTextBox.Text = String.Empty;
            CantidadExistenteNumericUpDown.Value = 0;
            MinimoTextBox.Text = String.Empty;
            FechaDateTimePicker.Value = DateTime.Now;
            SuperErrorProvider.Clear();
        }
        private Productos llenarClase()
        {
            Productos Pro = new Productos();
            Pro.CodigoProducto = Convert.ToInt32(CodigoRegistroNumericUpDown.Value);
            Pro.Descripcion = DescripcionTextBox.Text.ToString();
            Pro.CantidadExistente = Convert.ToInt32(CantidadExistenteNumericUpDown.Value);
            Pro.PrecioCosto = Convert.ToSingle(PreciocostoNumericUpDown.Value);
            Pro.Departamento = DepartamentoTextBox.Text;
            Pro.Minimo = Convert.ToInt32(MinimoTextBox.Text);
            Pro.FechaRegistro = FechaDateTimePicker.Value.ToString("dd/MM/yyyy");
            Pro.PrecioVenta = Convert.ToSingle(PrecioVentaNumericUpDown.Value);
            Pro.TasaDeGanancia = Convert.ToSingle(TasaDeGananciaNumericUpDown.Value);
            Pro.ITBIS = Convert.ToSingle(ITBIsNumericUpDown.Value);


            return Pro;
        }

        private bool ExisteEnLaBasedeDatos()
        {
            Productos Pro = ProductosBLL.Buscar((int)CodigoRegistroNumericUpDown.Value);
            return (Pro != null);
        }

        private bool Validar()
        {
            bool paso = true;

            {
                if (String.IsNullOrWhiteSpace(DescripcionTextBox.Text))
                {
                    SuperErrorProvider.SetError(DescripcionTextBox, "Este campo no debe estar vacio");
                    DescripcionTextBox.Focus();
                    paso = false;
                }

                if (String.IsNullOrWhiteSpace(DepartamentoTextBox.Text))
                {
                    SuperErrorProvider.SetError(DepartamentoTextBox, "Este campo no debe estar vacio");
                    DepartamentoTextBox.Focus();
                    paso = false;
                }

                if (String.IsNullOrWhiteSpace(MinimoTextBox.Text))
                {
                    SuperErrorProvider.SetError(MinimoTextBox, "Este campo no debe estar vacio");
                    MinimoTextBox.Focus();
                    paso = false;
                }

            }

            return paso;
        }

        private void LlenarCampos(Productos Pro)
        {
            FechaDateTimePicker.Value = DateTime.Parse(Pro.FechaRegistro);
            CodigoRegistroNumericUpDown.Value = Pro.CodigoProducto;
            DescripcionTextBox.Text = Pro.Descripcion;
            CantidadExistenteNumericUpDown.Value = Pro.CantidadExistente;
            PreciocostoNumericUpDown.Value = Convert.ToDecimal(Pro.PrecioCosto);
            PrecioVentaNumericUpDown.Value = Convert.ToDecimal(Pro.PrecioVenta);
            ITBIsNumericUpDown.Value = 0;
            DepartamentoTextBox.Text = Pro.Departamento;
            MinimoTextBox.Text = Pro.Minimo.ToString();
            TasaDeGananciaNumericUpDown.Value = Convert.ToDecimal(Pro.TasaDeGanancia);
        }

        

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Productos Pro;
            bool paso = false;


            if (!Validar())
                return;
            Pro = llenarClase();
            //limpiar();

            if (CodigoRegistroNumericUpDown.Value == 0)
            {
                paso = ProductosBLL.Guardar(Pro);
            }
            else
            {
                if (!ExisteEnLaBasedeDatos())
                {
                    MessageBox.Show("No se puede modificar un producto que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = ProductosBLL.Modificar(Pro);
            }
            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
                MessageBox.Show("No se pudo guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            cProductos cp = new cProductos();
            this.Hide();
            cp.ShowDialog();
        }


    

    private void CancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RegistrarProducto_Load(object sender, EventArgs e)
        {
            
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
        private void Minimizar_pictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        private void Restaurar_pictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Maximixar_pictureBox.Visible = true;
            Restaurar_pictureBox.Visible = false;
        }

        private void Maximixar_pictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Maximixar_pictureBox.Visible = false;
            Restaurar_pictureBox.Visible = true;
        }

        private void Cerrar_pictureBox_Click(object sender, EventArgs e)
        {
            Dispose();
        }


        private void CantidadExistenteNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
