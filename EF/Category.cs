namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Category")]
    public partial class Category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Category()
        {
            Article = new HashSet<Article>();
        }

        public int Id { get; set; }

        public int? Use { get; set; }

        public bool? Shortcut { get; set; }

        [StringLength(40)]
        public string Title { get; set; }

        [StringLength(100)]
        public string Entitle { get; set; }

        [StringLength(40)]
        public string Template { get; set; }

        [StringLength(40)]
        public string Alias { get; set; }

        public int? Pid { get; set; }

        public int? Group { get; set; }

        [StringLength(50)]
        public string Action { get; set; }

        public int? DType { get; set; }

        public int? Sequence { get; set; }

        [StringLength(1000)]
        public string Link { get; set; }

        public int? LinkType { get; set; }

        [StringLength(100)]
        public string Target { get; set; }

        [StringLength(100)]
        public string DataUrl { get; set; }

        public int? Paging { get; set; }

        [StringLength(1000)]
        public string Flash { get; set; }

        [StringLength(200)]
        public string Intro { get; set; }

        [Column(TypeName = "text")]
        public string Content { get; set; }

        public bool? Display { get; set; }

        [StringLength(200)]
        public string Image { get; set; }

        [StringLength(200)]
        public string Icon { get; set; }

        [StringLength(50)]
        public string IconFont { get; set; }

        public int? Banner { get; set; }

        [StringLength(200)]
        public string CustomFields { get; set; }

        [StringLength(5000)]
        public string SeoTitle { get; set; }

        [StringLength(5000)]
        public string SeoKeywords { get; set; }

        [StringLength(8000)]
        public string SeoDescription { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Article> Article { get; set; }
    }
}
