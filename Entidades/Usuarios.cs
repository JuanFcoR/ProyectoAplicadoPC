using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAplicadoPC.Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public string NivelAcceso { get; set; }
        public string Fecha { get; set; }

        public Usuarios()
        {
            UsuarioId = 0;
            Fecha = DateTime.Now.ToString("dd/MM/yyyy");
            Usuario = string.Empty;
            Clave = string.Empty;
            NivelAcceso = 0;
        }
    }
}
