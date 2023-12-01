using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EventoEntity
    {
        //ATRRIBUTOS
        private List<InvitadoEntity> invitados = new List<InvitadoEntity>();
        private List<ServicioContratadoEntity> serviciosContratados = new List<ServicioContratadoEntity>();


        //PROPIEDADES
        public int CodigoOrganizador { get; set; }
        public int CodigoEvento { get; set; }
        public string Nombre { get; set; }
        public string Lugar{ get; set; }
        public DateTime Fecha { get; set; }
        public bool Pago { get; set; }  
        public FacturaEntity Factura { get; set; }
        public List<InvitadoEntity> Invitados { get; set; }
        public List<ServicioContratadoEntity> ServiciosContratados { get; set; }
    }
}
