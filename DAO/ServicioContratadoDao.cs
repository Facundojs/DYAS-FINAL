using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ServicioContratadoDao
    {     

        public void AgregarServicioContratado(ServicioContratadoEntity servicioContratado, int codigoEvento)
        {
            try
            {
                using (ContextDb context = new ContextDb())
                {
                    var EventoServicio = new EVENTO_SERVICIO
                    {
                        ID_EVENTO = codigoEvento,
                        ID_SERVICIO = servicioContratado.CodigoServicio,
                        CANTIDAD = servicioContratado.Cantidad,
                        SUBTOTAL = servicioContratado.Subtotal,
                    };

                    context.EVENTO_SERVICIO.Add(EventoServicio);

                    context.SaveChanges();
                }
            }
            catch { throw; }
        }


        public void QuitarServicioContratado(ServicioContratadoEntity servicioContratado, int codigoEvento)
        {
            try
            {
                using (ContextDb context = new ContextDb())
                {
                    var eventoServicio = context.EVENTO_SERVICIO.SingleOrDefault(E => E.ID_EVENTO == codigoEvento && E.ID_SERVICIO == servicioContratado.CodigoServicio) 
                                        ?? throw new Exception("El servicio que desea quitar no existe");

                    
                    context.EVENTO_SERVICIO.Remove(eventoServicio);

                    context.SaveChanges();
                }
            }
            catch { throw; }
        }


        public List<ServicioContratadoEntity> ListarServiciosContrados(int codigoEvento)
        {
            try
            {
                using (ContextDb context = new ContextDb())
                {
                    var servicios = (from a in context.EVENTO_SERVICIO
                                     join b in context.SERVICIO
                                     on a.ID_SERVICIO equals b.ID_SERVICIO
                                     where a.ID_EVENTO == codigoEvento
                                     select new ServicioContratadoEntity
                                     {
                                         CodigoServicio = a.ID_SERVICIO,
                                         NombreServicio = b.NOMBRE_SERVICIO,
                                         Descripcion = b.DESCRIPCION,
                                         Cantidad = Convert.ToInt32(a.CANTIDAD),
                                         Subtotal = Convert.ToDouble(a.SUBTOTAL),
                                         Precio = Convert.ToDouble(Convert.ToDouble(a.SUBTOTAL) / Convert.ToInt32(a.CANTIDAD)),
                                     }).ToList();

                    return servicios;
                }
            }
            catch { throw; }
        }
    }
}
