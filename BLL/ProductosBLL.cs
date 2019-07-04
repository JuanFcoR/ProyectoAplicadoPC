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
        public static bool Guardar(Producto Pro)
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

        public static bool Modificar(Producto Pro)
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
                Producto Pro = contexto.Producto.Find(id);
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

        public static Producto Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Producto Pro;
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

        public static List<Producto> GetList(Expression<Func<Producto, bool>> persona)
        {
            List<Producto> Lista = new List<Producto>();
            Contexto db = new Contexto();
            try
            {
                Lista = db.Producto.Where(persona).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Lista;
        }

    }
}
