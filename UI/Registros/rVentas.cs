using ProyectoAplicadoPC.BLL;
using ProyectoAplicadoPC.Entidades;
using ProyectoAplicadoPC.UI.Consultas;
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
        public List<DetalleVentas> Detalle { get; set; }
        public rVentas()
        {
            InitializeComponent();
            this.Detalle = new List<DetalleVentas>();
        }

        public void CargarGrid()
        {
            DetallesDataGridView.DataSource = null;
            DetallesDataGridView.DataSource = this.Detalle;
        }

        private void limpiar()
        {
            NumeroFacturaNumericUpDown.Value = 0;
            FechaDateTimePicker.Value = DateTime.Now;
            SuperErrorProvider.Clear();
            this.Detalle = new List<DetalleVentas>();
            CargarGrid();
        }
        private Ventas llenarClase()
        {
            Ventas Pro = new Ventas();
            Pro.NumeroFactura = Convert.ToInt32(NumeroFacturaNumericUpDown.Value);
            Pro.Fecha = FechaDateTimePicker.Value.ToString("dd/MM/yyyy");
            Pro.Total = Convert.ToSingle(TotalTextBox.Text);
            Pro.Articulos = this.Detalle;


            return Pro;
        }

        private bool ExisteEnLaBasedeDatos()
        {
            Ventas Pro = VentasBLL.Buscar((int)NumeroFacturaNumericUpDown.Value);
            return (Pro != null);
        }

        private bool Validar()
        {
            bool paso = true;

           

            return paso;
        }

        private void LlenarCampos(Ventas Pro)
        {
            FechaDateTimePicker.Value = DateTime.Parse(Pro.Fecha);
            NumeroFacturaNumericUpDown.Value = Pro.NumeroFactura;
            TotalTextBox.Text = Pro.Total.ToString();
            this.Detalle = Pro.Articulos;
            CargarGrid();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Ventas Pro;
            bool paso = false;


            if (!Validar())
                return;
            Pro = llenarClase();
            //limpiar();

            if (NumeroFacturaNumericUpDown.Value == 0)
            {
                paso = VentasBLL.Guardar(Pro);
            }
            else
            {
                if (!ExisteEnLaBasedeDatos())
                {
                    MessageBox.Show("No se puede modificar una venta que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = VentasBLL.Modificar(Pro);
            }
            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
                MessageBox.Show("No se pudo guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        } 

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            cVentas cv = new cVentas();
            cv.ShowDialog();
        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {
            if (DetallesDataGridView.Rows.Count > 0 && DetallesDataGridView.CurrentRow != null)
                Detalle.RemoveAt(DetallesDataGridView.CurrentRow.Index);
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (DetallesDataGridView.DataSource != null)
                this.Detalle = (List<DetalleVentas>)DetallesDataGridView.DataSource;
            Productos p = ProductosBLL.Buscar((int)CodigoProductoNumericUpDown.Value);
            this.Detalle.Add(
                new DetalleVentas(iD: 0,
                codigoProducto: (int)CodigoProductoNumericUpDown.Value,
                descripcion: p.Descripcion,
                cantidad: (int)CantidadNumericUpDown.Value,
                precio: p.PrecioVenta,
                iTBIS:p.ITBIS,
                subTotal: (int)CantidadNumericUpDown.Value*p.PrecioVenta

                ));

            CargarGrid();


            
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

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }
    }
}
