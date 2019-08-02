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
    public class ClientesBLL
    {
        public static bool Guardar(Clientes Cliente)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Clientes.Add(Cliente)!=null)
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

        public static bool Modificar(Clientes Cliente)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(Cliente).State = EntityState.Modified;
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
                Clientes Cliente = contexto.Clientes.Find(id);
                contexto.Clientes.Remove(Cliente);
                paso = contexto.SaveChanges() > 0;
                contexto.Dispose();
            }

            catch (Exception)
            {

                throw;
            }

            return paso;
        }

        public static Clientes Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Clientes Cliente;
            try
            {
                Cliente = contexto.Clientes.Find(id);
                contexto.Dispose();
            }

            catch (Exception)
            {

                throw;
            }

            return Cliente;
        }

        public static List<Clientes> GetList(Expression<Func<Clientes, bool>> persona)
        {
            List<Clientes> Lista = new List<Clientes>();
            Contexto db = new Contexto();
            try
            {
                Lista = db.Clientes.Where(persona).ToList();
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

