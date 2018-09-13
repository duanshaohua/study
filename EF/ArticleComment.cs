namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ArticleComment")]
    public partial class ArticleComment
    {
        public int Id { get; set; }

        public int? Channels { get; set; }

        public int? ArticleId { get; set; }

        public int? ParentId { get; set; }

        public int? MemberId { get; set; }

        [StringLength(500)]
        public string Comment { get; set; }

        public DateTime? CommentTime { get; set; }

        public bool? Lock { get; set; }

        [StringLength(500)]
        public string Reply { get; set; }

        public DateTime? ReplyTime { get; set; }

        public virtual Article Article { get; set; }
    }
}
