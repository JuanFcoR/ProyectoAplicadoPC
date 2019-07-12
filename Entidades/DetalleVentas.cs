using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAplicadoPC.Entidades
{
    public class DetalleVentas
    {
        [Key]
        public int ID { get; set; }
        public int CodigoProducto { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }
        public float ITBIS { get; set; }
        public float SubTotal { get; set; }

        public DetalleVentas()
        {
            ID = 0;
            CodigoProducto=0;
            Descripcion = string.Empty; ;
            Cantidad = 0;
            Precio = 0;
            ITBIS = 0;
            SubTotal = 0;
        }

        public DetalleVentas(int iD, int codigoProducto, string descripcion, int cantidad, float precio, float iTBIS, float subTotal)
        {
            ID = iD;
            CodigoProducto = codigoProducto;
            Descripcion = descripcion;
            Cantidad = cantidad;
            Precio = precio;
            ITBIS = iTBIS;
            SubTotal = subTotal;
        }
    }
}
