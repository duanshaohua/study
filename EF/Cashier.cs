namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cashier")]
    public partial class Cashier
    {
        public int Id { get; set; }

        public int? Sort { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Icon { get; set; }

        public int? Type { get; set; }

        public int? PoundageType { get; set; }

        public decimal? PoundageAmount { get; set; }

        public bool? Enabled { get; set; }

        public bool? Api { get; set; }

        [StringLength(255)]
        public string ConfigPage { get; set; }

        [StringLength(255)]
        public string ConfigPath { get; set; }

        [StringLength(500)]
        public string Remark { get; set; }
    }
}
