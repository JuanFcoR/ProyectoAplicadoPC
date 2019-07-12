using ProyectoAplicadoPC.DAL;
using ProyectoAplicadoPC.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAplicadoPC.BLL
{
    public class VentasBLL
    {
        public static bool Guardar(Ventas Venta)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Ventas.Add(Venta) != null)
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

        public static bool Modificar(Ventas Venta)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(Venta).State = EntityState.Modified;
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
                Ventas Venta = contexto.Ventas.Find(id);
                contexto.Ventas.Remove(Venta);
                paso = contexto.SaveChanges() > 0;
                contexto.Dispose();
            }

            catch (Exception)
            {

                throw;
            }

            return paso;
        }

        public static Ventas Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Ventas Venta;
            try
            {
                Venta = contexto.Ventas.Find(id);
                contexto.Dispose();
            }

            catch (Exception)
            {

                throw;
            }

            return Venta;
        }

        public static List<Ventas> GetList(Expression<Func<Ventas, bool>> persona)
        {
            List<Ventas> Lista = new List<Ventas>();
            Contexto db = new Contexto();
            try
            {
                Lista = db.Ventas.Where(persona).ToList();
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
