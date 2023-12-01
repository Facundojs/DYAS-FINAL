using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;
using System.Threading.Tasks;

namespace DAO
{
    public class InvitadoDao
    {
        public void AltaInvitado(InvitadoEntity nuevoInvitado) 
        {
            try
            {
                using(ContextDb context =  new ContextDb())
                {
                    INVITADO invitadoDb = new INVITADO
                    {
                        ID_EVENTO = nuevoInvitado.CodigoEvento,
                        APELLIDO = nuevoInvitado.Apellido,
                        NOMBRE = nuevoInvitado.Nombre,
                        EMAIL = nuevoInvitado.Email,
                    };                    

                    context.INVITADO.Add(invitadoDb);

                    context.SaveChanges();
                }
            }
            catch { throw; }
        }


        public void BajaInvitado(InvitadoEntity invitado)
        {
            try
            {
                using (ContextDb context = new ContextDb())
                {
                    var invitadoDb = context.INVITADO.SingleOrDefault(I => I.ID_EVENTO == invitado.CodigoEvento && I.EMAIL == invitado.Email);

                    context.INVITADO.Remove(invitadoDb);

                    context.SaveChanges();
                }
            }
            catch { throw; }
        }


        public List<InvitadoEntity> ListarInvitados(int codigoEvento)
        {
            try
            {
                using (ContextDb context = new ContextDb())
                {
                    var invitados = new List<InvitadoEntity>();

                    var invitadosDb = context.INVITADO.Where(I =>I.ID_EVENTO == codigoEvento).Select(I => I).ToList();

                    foreach(var invitadoDb in invitadosDb)
                    {
                        var invitado = new InvitadoEntity 
                        {
                            CodigoEvento = invitadoDb.ID_EVENTO,
                            Nombre = invitadoDb.NOMBRE,
                            Apellido = invitadoDb.APELLIDO,
                            Email = invitadoDb.EMAIL,
                        };

                        invitados.Add(invitado);
                    }
                    return invitados;
                }
            }
            catch { throw; }
        }
    }
}
