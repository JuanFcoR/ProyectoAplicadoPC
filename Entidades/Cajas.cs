using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAplicadoPC.Entidades
{
    public class Cajas
    {
        public int CajaId { get; set; }
        public string Estado { get; set; }
        public string Permisos { get; set; }

        public Cajas()
        {
            CajaId = 0;
            Estado = "Cerrada";
            Permisos="Bloqueado";
        }
    }
}
