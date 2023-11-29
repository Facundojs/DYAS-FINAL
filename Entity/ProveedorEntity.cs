using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ProveedorEntity : PersonaEntity
    {
        public int CodigoProveedor { get; set; }
        public Int64 Dni { get; set; }
        public List<ServicioEntity> ServiciosPublicados { get; set; }
    }
}
