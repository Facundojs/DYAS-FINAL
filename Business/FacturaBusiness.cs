using DAO;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Business
{
    public class FacturaBusiness
    {
        private readonly FacturaDao facturaDao = new FacturaDao();

        public void Crear(FacturaEntity factura, int CodigoEvento)
        {
            if (factura.Monto <= 0)
                throw new Exception("Monto inválido");

            using (TransactionScope trx = new TransactionScope())
            {
                var dto = new FacturaEntity
                {
                    FechaEmision = DateTime.Now,
                    Monto = factura.Monto,
                };

                facturaDao.AltaFactura(factura, CodigoEvento);
            
                trx.Complete();
            }
        }
    
        public FacturaEntity Obtener(int CodigoEvento)
        {
            return facturaDao.ObtenerFactura(CodigoEvento);
        }
    }
}
