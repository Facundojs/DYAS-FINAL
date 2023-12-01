using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class OrganizadorDao
    {

        public void AltaOrganizador(OrganizadorEntity nuevoOrganizador, string password)
        {
            try
            {
                using (ContextDb context = new ContextDb())
                {
                    var organizadorDb = new ORGANIZADOR
                    {
                        NOMBRE = nuevoOrganizador.Nombre,
                        APELLIDO = nuevoOrganizador.Apellido,
                        DNI = nuevoOrganizador.Dni,
                        EMAIL = nuevoOrganizador.Email,
                        PASSWORD = password
                    };

                    context.ORGANIZADOR.Add(organizadorDb);

                    context.SaveChanges();
                }
            }
            catch { throw; }
        }

        public void ActualizarOrganizador (OrganizadorEntity organizador)
        {
            try
            {
                using (ContextDb context = new ContextDb())
                {
                    var organizadorDb = context.ORGANIZADOR.SingleOrDefault(O => O.ID_ORGANIZADOR == organizador.CodigoOrganizador) 
                        ?? throw new Exception("No se encuentra el organizador seleccionado");

                    organizadorDb.NOMBRE = organizador.Nombre;
                    organizadorDb.APELLIDO = organizador.Apellido;
                    organizadorDb.DNI = organizador.Dni;
                    organizadorDb.EMAIL = organizador.Email;

                    context.SaveChanges();
                }
            }
            catch { throw; }
        }

        public void ActualizarPassword (string email, string password)
        {
            try
            {
                using (ContextDb context = new ContextDb())
                {
                    var organizadorDb = context.ORGANIZADOR.SingleOrDefault(O => O.EMAIL == email) ?? throw new Exception("No se encuentra el organizador seleccionado");

                    organizadorDb.PASSWORD = password;

                    context.SaveChanges();
                }
            }
            catch { throw; }
        }

        public OrganizadorEntity ObtenerOrganizador(string usuario)
        {
            try
            {
                using(ContextDb context = new ContextDb())
                {
                    var organizadorDb = context.ORGANIZADOR.SingleOrDefault(O => O.EMAIL == usuario) ?? throw new Exception("No se encuentra el Organizador");

                    var organizador = new OrganizadorEntity
                    {
                        CodigoOrganizador = organizadorDb.ID_ORGANIZADOR,
                        Dni = Convert.ToInt64(organizadorDb.DNI),
                        Nombre = organizadorDb.NOMBRE,
                        Apellido = organizadorDb.APELLIDO,
                        Email = organizadorDb.EMAIL
                    };

                    return organizador;
                }
            }
            catch { throw; }
        }


        public bool ValidarCredenciales(string usuario, string password)
        {
            try
            {
                using (ContextDb context = new ContextDb())
                {
                    return context.ORGANIZADOR.Any(O => O.EMAIL == usuario && O.PASSWORD == password);
                }
            }
            catch { throw; }
        }
    }
}
