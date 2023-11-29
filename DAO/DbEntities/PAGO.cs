namespace DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PAGO")]
    public partial class PAGO
    {
        [Key]
        public int ID_PAGO { get; set; }

        public int? ID_EVENTO { get; set; }

        public DateTime? FECHA { get; set; }

        public double? MONTO { get; set; }

        public virtual EVENTO EVENTO { get; set; }
    }
}
