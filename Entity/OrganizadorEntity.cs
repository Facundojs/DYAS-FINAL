using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class OrganizadorEntity : PersonaEntity
    {      
        //ATRIBUTOS
        private List<ServicioContratadoEntity> serviciosContratados = new List<ServicioContratadoEntity>();

        //PROPIEDADES
        public int CodigoOrganizador {  get; set; }
        public Int64 Dni { get; set; }
        public List<ServicioContratadoEntity> ServiciosContratados { get => serviciosContratados; set => serviciosContratados = value; }
    }
}
