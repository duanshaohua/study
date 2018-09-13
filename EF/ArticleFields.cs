namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ArticleFields
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string FieldName { get; set; }

        [StringLength(100)]
        public string Aliases { get; set; }

        public int? Type { get; set; }

        [StringLength(1000)]
        public string InitialVal { get; set; }
    }
}
