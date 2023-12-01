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
        private readonly InvitadoDao invitadoDao = new InvitadoDao();
        private readonly EventoDao eventoDao = new EventoDao();

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

                    if(evento.Invitados.Count > 0)
                    {
                        foreach(InvitadoEntity invitado in evento.Invitados)
                            AñadirInvitado(eventoCreado.CodigoEvento, invitado);

                        eventoCreado.Invitados = invitadoDao.ListarInvitados(eventoCreado.CodigoEvento);
                    }

                    if(evento.ServiciosContratados.Count > 0)
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

        public void AñadirInvitado(int idEvento, InvitadoEntity invitado)
        {
            using(TransactionScope trx = new TransactionScope())
            {
                try
                {
                    if(string.IsNullOrEmpty(invitado.Nombre))
                        throw new Exception("Ingresa un nombre!");

                    if (string.IsNullOrEmpty(invitado.Apellido))
                        throw new Exception("Ingresa un Apellido!");

                    Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

                    if (string.IsNullOrEmpty(invitado.Email) || !emailRegex.IsMatch(invitado.Email))
                        throw new Exception("Ingresa un mail valido!");

                    invitadoDao.AltaInvitado(invitado, idEvento);

                    trx.Complete();
                }
                catch (Exception e){ throw e; }
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

        public List<EventoEntity> ListarEventos(int codigoOrganizador)
        {
            return eventoDao.ListarEventos(codigoOrganizador);
        }
      
      

      

        //public void GenerarFacturas()
        //public EventoEntity ObtenerEvento()
        //{

        //}
        //        using(TransactionScope trx = new TransactionScope())
        //{
        //    try { trx.Complete(); }
        //    catch (Exception e){ throw e; }
        //}
    }
}
