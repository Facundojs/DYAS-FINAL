using DAO;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ServicioBusiness
    {
        private readonly ServicioDao servicioDao = new ServicioDao();

        public List<ServicioEntity> ListarServicios()
        {
            try
            {
                return servicioDao.ListarServicios();
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
