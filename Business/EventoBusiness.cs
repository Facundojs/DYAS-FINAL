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
                    var evento = eventoDao.ObtenerEvento(CodigoEvento) ?? throw new Exception("Evento no encontrado");
                    
                    // Si ya se pagaron los servicios no se puede eliminar
                    if (evento.Pago)
                        throw new Exception("No se puede eliminar un evento ya pago");

                    // Elimino invitados
                    var invitados = invitadoBusiness.Listar(CodigoEvento);

                    foreach (var invitado in invitados)
                        invitadoBusiness.Borrar(invitado);

                    // Elimino servicios contratados
                    var serviciosContratados = servicioContratadoDao.ListarServiciosContrados(CodigoEvento);

                    foreach (var servicioContratado in serviciosContratados)
                        servicioContratadoDao.QuitarServicioContratado(servicioContratado, CodigoEvento);


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
