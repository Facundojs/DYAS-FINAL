using Entity;
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

                var servicios = new List<ServicioEntity>();

                foreach(var servicioDb in serviciosDb)
                {
                    var servicio = new ServicioEntity 
                    {
                        CodigoServicio = servicioDb.ID_SERVICIO,
                        NombreServicio = servicioDb.NOMBRE_SERVICIO,
                        Descripcion = servicioDb.DESCRIPCION,
                        Precio = Convert.ToDouble(servicioDb.PRECIO)
                    };

                    servicios.Add(servicio);
                }

                return servicios;
            }
        }


        public List<ServicioEntity> ListarServiciosPublicados(int codigoProveedor)
        {
            using (ContextDb context = new ContextDb())
            {
                var serviciosPublicados = new List<ServicioEntity>();

                var serviciosDb = context.SERVICIO.Where(S => S.ID_PROVEEDOR == codigoProveedor);                

                foreach (var servicioDb in serviciosDb)
                {
                    var servicio = new ServicioEntity
                    {
                        CodigoServicio = servicioDb.ID_SERVICIO,
                        NombreServicio = servicioDb.NOMBRE_SERVICIO,
                        Descripcion = servicioDb.DESCRIPCION,
                        Precio = Convert.ToDouble(servicioDb.PRECIO)
                    };

                    serviciosPublicados.Add(servicio);
                }

                return serviciosPublicados;
            }
        }
    }
}
