using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAplicadoPC.Entidades
{
    public class Ventas
    {
        public int NumeroFactura { get; set; }
        public int CodigoCliente { get; set; }
        public string Fecha { get; set; }
        public float Total { get; set; }
        public virtual List<DetalleVentas> Articulos { get; set; }

        public Ventas()
        {
            NumeroFactura = 0;
            Fecha = DateTime.Now.ToString("dd/MM/yyyy");
            Total = 0;
            Articulos = new List<DetalleVentas>();
        }
    }
}
