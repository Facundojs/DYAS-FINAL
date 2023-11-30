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
