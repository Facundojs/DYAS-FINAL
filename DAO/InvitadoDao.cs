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
        public void AltaInvitado(InvitadoEntity nuevoInvitado) 
        {
            try
            {
                using(ContextDb context =  new ContextDb())
                {
                    INVITADO invitadoDb = new INVITADO();

                    //mapping

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
    }
}
