namespace DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PROVEEDOR")]
    public partial class PROVEEDOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROVEEDOR()
        {
            SERVICIO = new HashSet<SERVICIO>();
        }

        [Key]
        public int ID_PROVEEDOR { get; set; }

        [StringLength(50)]
        public string NOMBRE { get; set; }

        [StringLength(50)]
        public string APELLIDO { get; set; }

        public long? DNI { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        [StringLength(10)]
        public string PASSWORD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVICIO> SERVICIO { get; set; }
    }
}
