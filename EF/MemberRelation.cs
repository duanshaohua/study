namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MemberRelation")]
    public partial class MemberRelation
    {
        public int Id { get; set; }

        public int? MemberId { get; set; }

        public int? FriendId { get; set; }

        [StringLength(100)]
        public string Remark { get; set; }

        public int? Group { get; set; }

        public DateTime? CreationTime { get; set; }

        public bool? Affirm { get; set; }
    }
}
