namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Link")]
    public partial class Link
    {
        public int Id { get; set; }
        
        [StringLength(40)]
        public string Title { get; set; }

        public int? Type { get; set; }

        [StringLength(200)]
        public string Url { get; set; }

        [StringLength(100)]
        public string Image { get; set; }

        public int? Ordernum { get; set; }

        public bool? Auditing { get; set; }

        public int? Source { get; set; }
    }
}
