namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MemberMessageState")]
    public partial class MemberMessageState
    {
        public int Id { get; set; }

        public int MemberId { get; set; }

        public int? MessageId { get; set; }

        public bool? Read { get; set; }

        public DateTime? ReadTime { get; set; }
    }
}
