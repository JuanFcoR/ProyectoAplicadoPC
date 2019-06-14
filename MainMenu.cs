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
    }
}
