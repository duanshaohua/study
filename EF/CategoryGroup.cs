namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CategoryGroup")]
    public partial class CategoryGroup
    {
        public int Id { get; set; }

        [StringLength(40)]
        public string Alias { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Describe { get; set; }

        [StringLength(100)]
        public string Link { get; set; }

        public bool? Wicbd { get; set; }

        public bool? Hide { get; set; }
    }
}
