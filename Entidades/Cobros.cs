using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAplicadoPC.Entidades
{
    public class Cobros
    {
     
        [Key]

        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public int Cedula { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Abonado { get; set; }
        public decimal Deuda { get; set; }

        public Cobros(int idCliente, string nombre, int cedula, DateTime fecha, decimal abonado, decimal deuda)
        {
            IdCliente = idCliente;
            Nombre = nombre;
            Cedula = cedula;
            Fecha = fecha;
            Abonado = abonado;
            Deuda = deuda;
        }

        public Cobros()
        {
            IdCliente = 0;
            Nombre = string.Empty;
            Cedula = 0;
            Fecha = DateTime.Now;
            Abonado = 0;
            Deuda = 0;
        }
    }
}
