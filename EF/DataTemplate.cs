namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DataTemplate")]
    public partial class DataTemplate
    {
        public int Id { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        public int? Type { get; set; }

        [StringLength(5000)]
        public string HeaderTemplate { get; set; }

        [StringLength(5000)]
        public string ItemTemplate { get; set; }

        [StringLength(5000)]
        public string FooterTemplate { get; set; }

        [StringLength(5000)]
        public string Style { get; set; }
    }
}
