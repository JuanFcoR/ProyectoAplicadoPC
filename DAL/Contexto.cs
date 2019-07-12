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
        public DbSet<Productos> Producto { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Ventas> Ventas { get; set; }
        public Contexto(): base("ConStr2") 
        {

        }
    }
}
