using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class InvitadoDao
    {
        public void AltaInvitado(InvitadoEntity nuevoInvitado, int codigoEvento) 
        {
            try
            {
                using(ContextDb context =  new ContextDb())
                {
                    INVITADO invitadoDb = new INVITADO
                    {
                        ID_EVENTO = codigoEvento,
                        EMAIL = nuevoInvitado.Email,
                        NOMBRE = nuevoInvitado.Nombre,
                        APELLIDO = nuevoInvitado.Apellido
                    };                    

                    context.INVITADO.Add(invitadoDb);

                    context.SaveChanges();
                }
            }
            catch { throw; }
        }


        public void BajaInvitado(int codigoEvento, string InvitadoEmail)
        {
            try
            {
                using (ContextDb context = new ContextDb())
                {
                    var invitadoDb = context.INVITADO.SingleOrDefault(I => I.ID_EVENTO == codigoEvento && I.EMAIL == InvitadoEmail);

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
