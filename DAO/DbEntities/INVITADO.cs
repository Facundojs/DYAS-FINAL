namespace DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INVITADO")]
    public partial class INVITADO
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string EMAIL { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_EVENTO { get; set; }

        [StringLength(50)]
        public string NOMBRE { get; set; }

        [StringLength(50)]
        public string APELLIDO { get; set; }

        public long? DNI { get; set; }

        public virtual EVENTO EVENTO { get; set; }
    }
}
