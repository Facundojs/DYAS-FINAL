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
        private List<EventoEntity> Eventos = new List<EventoEntity>();

        //PROPIEDADES
        public int CodigoOrganizador {  get; set; }
        public Int64 Dni { get; set; }
        public List<EventoEntity> Eventos1 { get => Eventos; set => Eventos = value; }
    }
}
