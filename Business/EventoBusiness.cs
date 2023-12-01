using DAO;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Transactions;

namespace Business
{
    public class EventoBusiness
    {
        private readonly ServicioContratadoDao servicioContratadoDao = new ServicioContratadoDao();
        private readonly InvitadoBusiness invitadoBusiness = new InvitadoBusiness();
        private readonly EventoDao eventoDao = new EventoDao();

        private EventoEntity ObtenerRelaciones(EventoEntity evento)
        {
            evento.ServiciosContratados = servicioContratadoDao.ListarServiciosContrados(evento.CodigoEvento);
            evento.Invitados = invitadoBusiness.Listar(evento.CodigoEvento);

            return evento;
        }

        public EventoEntity CrearEvento(EventoEntity evento)
        {
            using (TransactionScope trx = new TransactionScope())
            {
                try {
                    bool esPosteriorHoy = evento.Fecha > DateTime.Now;

                    if (!esPosteriorHoy)
                        throw new Exception("La fecha del evento debe ser posterior a hoy!");

                    if (string.IsNullOrEmpty(evento.Nombre))
                        throw new Exception("El nombre es obligatorio!");

                    if (string.IsNullOrEmpty(evento.Lugar))
                        throw new Exception("Indica el lugar del evento!");

                    var eventoDto = new EventoEntity
                    {
                        CodigoOrganizador = evento.CodigoOrganizador,
                        Nombre = evento.Nombre,
                        Fecha = evento.Fecha,
                        Lugar = evento.Lugar,
                    };

                    EventoEntity eventoCreado = eventoDao.AltaEvento(eventoDto);

                    if(evento.Invitados != null && evento.Invitados.Count > 0)
                    {
                        foreach(InvitadoEntity invitado in evento.Invitados)
                            invitadoBusiness.Crear(new InvitadoEntity
                                {
                                    Email = invitado.Email,
                                    CodigoEvento = eventoCreado.CodigoEvento,
                                }
                            );

                        eventoCreado.Invitados = invitadoBusiness.Listar(eventoCreado.CodigoEvento);
                    }

                    if(evento.ServiciosContratados != null && evento.ServiciosContratados.Count > 0)
                    {
                        foreach (ServicioContratadoEntity servicioContratado in evento.ServiciosContratados)
                            AñadirServicioContratado(eventoCreado.CodigoEvento, servicioContratado);

                        eventoCreado.ServiciosContratados = servicioContratadoDao.ListarServiciosContrados(eventoCreado.CodigoEvento);
                    }

                    trx.Complete();

                    return eventoCreado;
                }
                catch (Exception e){
                    throw e;
                }
            }
        }

        public void AñadirServicioContratado(int idEvento, ServicioContratadoEntity servicioContratado)
        {
            using (TransactionScope trx = new TransactionScope())
            {
                try {
                    servicioContratadoDao.AgregarServicioContratado(servicioContratado, idEvento);

                    trx.Complete();
                }
                catch (Exception e) { throw e; }
            }
        }
    
        public EventoEntity Obtener(int CodigoEvento)
        {
            try {
                var evento = eventoDao.ObtenerEvento(CodigoEvento);

                return ObtenerRelaciones(evento);
            }
            catch (Exception e) { throw e; }
        }

        public List<EventoEntity> Listar(int CodigoOrganizador) 
        {
            try 
            {
                List<EventoEntity> eventos = new List<EventoEntity>();

                var eventosDb = eventoDao.ListarEventos(CodigoOrganizador);

                foreach (var evento in eventosDb)
                    eventos.Add(ObtenerRelaciones(evento));

                return eventos;
            }
            catch (Exception e) { throw e; }
        }

        public void BorrarEvento(int CodigoEvento)
        {
            try
            {
                using(TransactionScope trx = new TransactionScope())
                {
                    eventoDao.BajaEvento(CodigoEvento);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
