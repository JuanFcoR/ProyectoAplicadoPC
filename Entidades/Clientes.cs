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
        public int CodigoCliente { get; set; }
        public string Fecha { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string TelefonoReferencia { get; set; }
        public string Direccion { get; set; }
        public float LimiteDeCredito { get; set; }

        public Clientes()
        {
            CodigoCliente = 0;
            Fecha = DateTime.Now.ToString("dd/MM/yyyy");
            Nombre = string.Empty;
            Apellidos = string.Empty;
            Cedula = string.Empty;
            Telefono = string.Empty;
            Celular = string.Empty;
            TelefonoReferencia = string.Empty;
            Direccion = string.Empty;
            Direccion = string.Empty;
            LimiteDeCredito=0;
        }
        
    }
}
 