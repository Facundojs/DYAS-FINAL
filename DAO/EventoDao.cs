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
        public EventoEntity AltaEvento(EventoEntity nuevoEvento) 
        {
            try
            {
                using (ContextDb context = new ContextDb())
                {
                    var eventoDb = new EVENTO 
                    { 
                        ID_ORGANIZADOR = nuevoEvento.CodigoOrganizador,
                        NOMBRE_EVENTO = nuevoEvento.Nombre,
                        HORA = nuevoEvento.Fecha.TimeOfDay,
                        FECHA = nuevoEvento.Fecha.Date,
                        LUGAR = nuevoEvento.Lugar                   
                    };

                    EVENTO evento = context.EVENTO.Add(eventoDb);

                    context.SaveChanges();

                    return ObtenerEvento(evento.ID_EVENTO);
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
                    var eventoDb = context.EVENTO.SingleOrDefault(E => E.ID_EVENTO == CodigoEvento) ?? throw new Exception("No se encuentra el evento seleccionado");

                    context.EVENTO.Remove(eventoDb);

                    context.SaveChanges();
                }
            }
            catch { throw; }
        }

        public void ModificarEvento(EventoEntity evento)
        {
            try
            {
                using (ContextDb context = new ContextDb())
                {
                    var eventoDb = context.EVENTO.SingleOrDefault(E => E.ID_EVENTO == evento.CodigoEvento) ?? throw new Exception("No se encuentra el evento seleccionado");

                    eventoDb.NOMBRE_EVENTO = evento.Nombre;
                    eventoDb.FECHA = evento.Fecha.Date;
                    eventoDb.HORA = evento.Fecha.TimeOfDay;
                    eventoDb.LUGAR = evento.Lugar;

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
                    var eventoDb = context.EVENTO.SingleOrDefault(E => E.ID_EVENTO == CodigoEvento) ?? throw new Exception("No se encuentra el evento seleccionado");

                    var evento = new EventoEntity
                    {
                        Fecha = Convert.ToDateTime(eventoDb.FECHA).Add(Convert.ToDateTime(eventoDb.HORA).TimeOfDay),
                        CodigoOrganizador = (int)eventoDb.ID_ORGANIZADOR,
                        CodigoEvento = eventoDb.ID_EVENTO,
                        Nombre = eventoDb.NOMBRE_EVENTO,
                        Lugar = eventoDb.LUGAR,
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


        public bool EsEventoPago(int codigoEvento)
        {
            try
            {
                using (ContextDb context = new ContextDb())
                {
                    
                    return context.EVENTO.SingleOrDefault(E => E.ID_EVENTO == codigoEvento && E.PAGO == true) != null;
                        
                }
            }
            catch { throw; }
        }

    }
}
