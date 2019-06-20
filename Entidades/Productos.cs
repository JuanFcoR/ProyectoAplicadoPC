using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAplicadoPC
{
    public class Productos
    {
        [Key]
        public int CodigoProducto { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Descripcion { get; set; }
        
        public float Preciocosto { get; set; }
        public float TasaDeGanancia { get; set; }
        public float ITBIs { get; set; }
        public int CantidadExistente { get; set; }
        public float TasaDeDescuento { get; set; }
        public float PrecioVenta { get; set; }
        public string Departamento { get; set; }
        public string Comentario { get; set; }  



        
        

        public Productos()
        {
            CodigoProducto = 0;
            FechaRegistro = DateTime.Now;
            Descripcion = string.Empty;
            Preciocosto = 0;
            PrecioVenta = 0;
            ITBIs = 0;
            CantidadExistente = 0;
            TasaDeDescuento = 0;
            TasaDeGanancia = 0;
            Departamento = string.Empty;
            Comentario = string.Empty;
             

        }
    }
}
