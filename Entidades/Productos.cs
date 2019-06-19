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
        
        

        public Productos()
        {
            CodigoProducto = 0;
            FechaRegistro = DateTime.Now;
            Descripcion = string.Empty;

        }
    }
}
