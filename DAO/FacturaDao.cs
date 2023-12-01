using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class FacturaDao
    {
        public void AltaFactura(FacturaEntity nuevaFactura, int codigoEvento)
        {
            try
            {
                using(ContextDb context = new ContextDb())
                {
                    var pagoDb = new PAGO 
                    {
                        ID_PAGO = context.PAGO.Count() + 1,
                        ID_EVENTO = codigoEvento,
                        FECHA = DateTime.Now,
                        MONTO = nuevaFactura.Monto
                    };

                    context.PAGO.Add(pagoDb);

                    context.SaveChanges();
                }
            }
            catch { throw; }
        }


        public FacturaEntity ObtenerFactura(int codigoEvento)
        {
            try
            {
                using (ContextDb context = new ContextDb())
                {
                    var pagoDb = context.PAGO.SingleOrDefault(P => P.ID_EVENTO == codigoEvento) ?? throw new Exception("No se encuentra la factura seleccionada"); 
                    
                    var factura = new FacturaEntity
                    {
                        CodigoFactura = pagoDb.ID_PAGO,
                        FechaEmision = Convert.ToDateTime(pagoDb.FECHA),
                        Monto = Convert.ToDouble(pagoDb.MONTO)                        
                    };

                    return factura;
                }
            }
            catch { throw; }
        }


        public bool ExisteFactura(int idEvento)
        {
            try
            {
                using (ContextDb context = new ContextDb())
                {
                    return context.PAGO.Any(P => P.ID_EVENTO == idEvento);
                }
            }
            catch { throw; }
        }
    }
}
