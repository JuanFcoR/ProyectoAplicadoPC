using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAplicadoPC
{
    public class Producto
    {
        [Key]
        public int CodigoProducto { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Descripcion { get; set; }
        public float PrecioCosto { get; set; }
        public float TasaDeGanancia { get; set; }
        public float ITBIS { get; set; }
        public float PrecioVenta { get; set; }
        public float TasaDeDescuento { get; set; }
        public int CantidadExistente { get; set; }
        public string Departamento { get; set; }
        public int Minimo { get; set; }
        
  
        

        public Producto()
        {
            CodigoProducto = 0;
            FechaRegistro = DateTime.Now;
            Descripcion = string.Empty;
            PrecioCosto = 0;
            PrecioVenta = 0;
            ITBIS = 0;
            CantidadExistente = 0;
            TasaDeDescuento = 0;
            TasaDeGanancia = 0;
            Departamento = string.Empty;
            Minimo = 0;
             

        }
    }
}
