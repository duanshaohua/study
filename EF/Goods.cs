namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Goods
    {
        public int Id { get; set; }

        [StringLength(500)]
        public string Title { get; set; }

        public int? StoreId { get; set; }

        [StringLength(100)]
        public string Price { get; set; }

        [StringLength(100)]
        public string Agio { get; set; }

        [StringLength(100)]
        public string Integral { get; set; }

        [StringLength(100)]
        public string Freight { get; set; }

        [StringLength(8000)]
        public string Image { get; set; }

        [StringLength(8000)]
        public string AttrJson { get; set; }

        public virtual Store Store { get; set; }
    }
}
