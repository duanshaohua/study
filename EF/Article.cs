namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Article")]
    public partial class Article
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Article()
        {
            ArticleComment = new HashSet<ArticleComment>();
            ArticleImage = new HashSet<ArticleImage>();
        }

        public int Id { get; set; }

        public int? Sort { get; set; }

        public int? CategoryId { get; set; }

        [StringLength(500)]
        public string Title { get; set; }

        [StringLength(20)]
        public string Author { get; set; }

        [StringLength(200)]
        public string Come { get; set; }

        public int? Read { get; set; }

        [StringLength(500)]
        public string Intro { get; set; }

        [Column(TypeName = "text")]
        public string Content { get; set; }

        public bool? Hot { get; set; }

        public bool? Stick { get; set; }

        public bool? Recommend { get; set; }

        public bool? Display { get; set; }

        public DateTime? Time { get; set; }

        [StringLength(500)]
        public string Cover { get; set; }

        public bool? Del { get; set; }

        [Column(TypeName = "text")]
        public string Expand { get; set; }

        [StringLength(300)]
        public string Alias { get; set; }

        public bool? Comment { get; set; }

        public bool? Trial { get; set; }

        public bool? Slides { get; set; }

        [StringLength(1000)]
        public string Link { get; set; }

        [StringLength(3000)]
        public string Tags { get; set; }

        [StringLength(5000)]
        public string SeoTitle { get; set; }

        [StringLength(5000)]
        public string SeoKeywords { get; set; }

        [StringLength(8000)]
        public string SeoDescription { get; set; }

        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArticleComment> ArticleComment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArticleImage> ArticleImage { get; set; }
    }
}
