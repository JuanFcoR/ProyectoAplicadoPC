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
    public partial class rCajas : Form
    {
        public rCajas()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            CajaIdNumericUpDown.Value = 0;
            SuperErrorProvider.Clear();
        }
        private void GuardarButton_Click(object sender, EventArgs e)
        {

        }
    }
}
