namespace DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EVENTO_SERVICIO
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_EVENTO { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_SERVICIO { get; set; }

        public int? CANTIDAD { get; set; }

        public double? SUBTOTAL { get; set; }

        public virtual EVENTO EVENTO { get; set; }

        public virtual SERVICIO SERVICIO { get; set; }
    }
}
