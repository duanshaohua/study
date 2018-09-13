namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MemberMessage")]
    public partial class MemberMessage
    {
        public int Id { get; set; }

        public int? Type { get; set; }

        public int? MemberGroup { get; set; }

        public int? Sender { get; set; }

        public int? Accept { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(1000)]
        public string Content { get; set; }

        public DateTime? SenderTime { get; set; }

        public DateTime? ReadTime { get; set; }

        public bool? Read { get; set; }
    }
}
