using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAO
{
    public class EventoDao
    {
        public void AltaEvento(EventoEntity nuevoEvento, int codigoOrganizador) 
        {
            try
            {
                using (ContextDb context = new ContextDb())
                {
                    var eventoDb = new EVENTO 
                    { 
                        ID_ORGANIZADOR = codigoOrganizador,
                        NOMBRE_EVENTO = nuevoEvento.Nombre,
                        FECHA = nuevoEvento.Fecha.Date,
                        HORA = nuevoEvento.Fecha.TimeOfDay,
                        LUGAR = nuevoEvento.Lugar                   
                    };

                    context.EVENTO.Add(eventoDb);

                    context.SaveChanges();
                }
            }
            catch { throw; }            
        }       


        public void BajaEvento(int CodigoEvento)
        {
            try
            {
                using (ContextDb context = new ContextDb())
                {
                    var eventoDb = context.EVENTO.SingleOrDefault(E => E.ID_EVENTO == CodigoEvento);

                    context.EVENTO.Remove(eventoDb);

                    context.SaveChanges();
                }
            }
            catch { throw; }
        }


        public EventoEntity ObtenerEvento(int CodigoEvento)
        {
            try
            {
                using (ContextDb context = new ContextDb())
                {
                    var eventoDb = context.EVENTO.SingleOrDefault(E => E.ID_EVENTO == CodigoEvento);

                    var evento = new EventoEntity
                    {
                        CodigoEvento = eventoDb.ID_EVENTO,
                        Nombre = eventoDb.NOMBRE_EVENTO,
                        Lugar = eventoDb.LUGAR,
                        Fecha = Convert.ToDateTime(eventoDb.FECHA).Add(Convert.ToDateTime(eventoDb.HORA).TimeOfDay)
                    };

                    return evento;
                }
            }
            catch { throw; }
        }


        public List<EventoEntity> ListarEventos(int codigoOrganizador)
        {
            try
            {
                using (ContextDb context = new ContextDb())
                {
                    var eventos = new List<EventoEntity>();

                    var eventosDb = context.EVENTO.Where(E => E.ID_ORGANIZADOR == codigoOrganizador).Select(E => E).ToList();

                    eventosDb.ForEach(E => eventos.Add(this.ObtenerEvento(E.ID_EVENTO)));

                    return eventos;
                }
            }
            catch { throw; }
        }

    }
}
