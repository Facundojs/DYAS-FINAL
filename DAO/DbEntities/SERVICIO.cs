namespace DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SERVICIO")]
    public partial class SERVICIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SERVICIO()
        {
            EVENTO_SERVICIO = new HashSet<EVENTO_SERVICIO>();
        }

        [Key]
        public int ID_SERVICIO { get; set; }

        public int? ID_PROVEEDOR { get; set; }

        [StringLength(50)]
        public string NOMBRE_SERVICIO { get; set; }

        public string DESCRIPCION { get; set; }

        public double? PRECIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EVENTO_SERVICIO> EVENTO_SERVICIO { get; set; }

        public virtual PROVEEDOR PROVEEDOR { get; set; }
    }
}
