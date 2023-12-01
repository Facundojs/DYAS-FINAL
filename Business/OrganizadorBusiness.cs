using DAO;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class OrganizadorBusiness
    {
        private readonly OrganizadorDao organizadorDao = new OrganizadorDao();

        public OrganizadorEntity Login(string username, string password)
        {
            bool credencialesValidas = organizadorDao.ValidarCredenciales(username, password);

            if (!credencialesValidas)
                throw new Exception("Las credenciales no son validas");

            return organizadorDao.ObtenerOrganizador(username);
        }
    }
}
