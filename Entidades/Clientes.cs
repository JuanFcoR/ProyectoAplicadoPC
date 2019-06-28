using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAplicadoPC.Entidades
{
    public class Clientes
    {
        [Key]
        public int Codigo { get; set; }
        public DateTime Fecha { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string TelefonoDeReferencia { get; set; }
        public string Direccion { get; set; }
        public float LimiteDeCredito { get; set; }

        public Clientes()
        {
                
        }
        
    }
}
 