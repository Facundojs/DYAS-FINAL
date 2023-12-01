using DAO;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;

namespace Business
{
    public class InvitadoBusiness
    {
        private readonly InvitadoDao invitadoDao = new InvitadoDao();

        public void Crear(InvitadoEntity invitado) 
        {
            using (TransactionScope trx = new TransactionScope())
            {
                try
                {
                    if (string.IsNullOrEmpty(invitado.Nombre))
                        throw new Exception("Ingresa un nombre!");

                    if (string.IsNullOrEmpty(invitado.Apellido))
                        throw new Exception("Ingresa un Apellido!");
                    Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

                    if (string.IsNullOrEmpty(invitado.Email) || !emailRegex.IsMatch(invitado.Email))
                        throw new Exception("Ingresa un mail valido!");

                    invitadoDao.AltaInvitado(invitado);

                    trx.Complete();
                }
                catch (Exception e) { throw e; }
            }
        }

        public void Borrar(InvitadoEntity invitado)
        {
            using (TransactionScope trx = new TransactionScope())
            {
                try
                {
                    invitadoDao.BajaInvitado(invitado);

                    trx.Complete();
                }
                catch (Exception e) { throw e; }
            }
        }

        public List<InvitadoEntity> Listar(int CodigoEvento)
        {
            return invitadoDao.ListarInvitados(CodigoEvento);
        }
    }
}
