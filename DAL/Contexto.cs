using ProyectoAplicadoPC.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoAplicadoPC.DAL
{
    public class Contexto:DbContext
    {
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public Contexto(): base(@"Server =localhost;Database= id9920472_pa; Uid = id9920472_root; Pwd=12345")
        {

        }
    }
}
