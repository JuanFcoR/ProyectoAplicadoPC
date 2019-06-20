using ProyectoAplicadoPC.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MySql.Data.EntityFramework;

namespace ProyectoAplicadoPC.BLL
{
    public class ProductosBLL
    {
        public static bool Guardar(Productos Producto)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Productos.Add(Producto) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();

            }
            catch (Exception)
            {

                throw;
            }


            return paso;
        }

        public static bool Modificar(Productos Producto)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(Producto).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

       
        public static Productos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Productos Producto;
            try
            {
                Producto = contexto.Productos.Find(id);
                contexto.Dispose();
            }

            catch (Exception)
            {

                throw;
            }

            return Producto;
        }

        
    }
}
