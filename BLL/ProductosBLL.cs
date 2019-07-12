using ProyectoAplicadoPC.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MySql.Data.EntityFramework;
using ProyectoAplicadoPC.Entidades;
using System.Globalization;

namespace ProyectoAplicadoPC.BLL
{
    public class ProductosBLL
    {
        public static bool Guardar(Productos Pro)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Producto.Add(Pro) != null)
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

        public static bool Modificar(Productos Pro)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(Pro).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                Productos Pro = contexto.Producto.Find(id);
                contexto.Producto.Remove(Pro);
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
            Productos Pro;
            try
            {
                Pro = contexto.Producto.Find(id);
                contexto.Dispose();
            }

            catch (Exception)
            {

                throw;
            }

            return Pro;
        }

        public static List<Productos> GetList(Expression<Func<Productos, bool>> expression)
        {
            
            List<Productos> Lista2 = new List<Productos>();
            Contexto db = new Contexto();
            try
            {
                var Lista = db.Producto.Where(expression).ToList();
                
                Lista2 = Lista;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Lista2;
        }

    }
}
