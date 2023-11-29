using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class FacturaEntity
    {
        public int CodigoFactura { get; set; }
        public double Monto { get; set; }
        public DateTime FechaEmision { get; set; }
    }
}
