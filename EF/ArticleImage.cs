namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ArticleImage")]
    public partial class ArticleImage
    {
        public int Id { get; set; }

        public int? ArticleId { get; set; }

        [StringLength(300)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Intro { get; set; }

        [StringLength(200)]
        public string Image { get; set; }

        public bool? Display { get; set; }

        public virtual Article Article { get; set; }
    }
}
