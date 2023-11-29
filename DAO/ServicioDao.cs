using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ServicioDao
    {
        public List<ServicioEntity> ListarServicios()
        {
            using(ContextDb context = new ContextDb())
            {
                var serviciosDb = context.SERVICIO.ToList();

                List<ServicioEntity> servicios = new List<ServicioEntity>();

                //mapping

                return servicios;
            }
        }
    }
}
