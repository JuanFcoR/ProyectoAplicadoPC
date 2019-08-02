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
            Contexto db = new Contexto();
            try
            {
                if (db.Ventas.Add(Venta) != null)
                {
                    paso = db.SaveChanges() > 0;
                    
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }
            

            return paso;
        }

        public static bool Modificar(Ventas Venta)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var Anterior = Buscar(Venta.NumeroFactura);
                foreach (var item in Anterior.Articulos)
                {
                    if (!Venta.Articulos.Exists(d => d.ID == item.ID))
                        db.Entry(item).State = EntityState.Deleted;
                }

                foreach (var item in Venta.Articulos)
                {
                    if (item.ID == 0)
                    {
                        db.Entry(item).State = EntityState.Added;
                    }
                    else
                    {
                        db.Entry(item).State = EntityState.Modified;
                    }
                }

                db.Entry(Venta).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var eliminar = db.Ventas.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }

        public static Ventas Buscar(int id)
        {
            Contexto db = new Contexto();
            Ventas Venta;
            try
            {
                Venta = db.Ventas.Find(id);
                Venta.Articulos.Count();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
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
