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
        public void AltaEvento(EventoEntity nuevEvento) 
        {
            try
            {
                using (ContextDb context = new ContextDb())
                {
                    EVENTO eventoDb = new EVENTO();

                    //mapping

                    context.EVENTO.Add(eventoDb);

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

                    EventoEntity evento = new EventoEntity();

                    //maping

                    return evento;
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
    }
}
