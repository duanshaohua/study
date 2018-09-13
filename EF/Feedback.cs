namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Feedback")]
    public partial class Feedback
    {
        public int Id { get; set; }

        public int? Type { get; set; }

        public int? MemberId { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [Column(TypeName = "ntext")]
        public string Content { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(30)]
        public string Tel { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(30)]
        public string QQ { get; set; }

        public DateTime? MessageTime { get; set; }

        [Column(TypeName = "ntext")]
        public string ReplyContent { get; set; }

        public DateTime? ReplyTime { get; set; }

        public bool? Read { get; set; }

        public bool? Lock { get; set; }
    }
}
