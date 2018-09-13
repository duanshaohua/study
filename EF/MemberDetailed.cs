namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MemberDetailed")]
    public partial class MemberDetailed
    {
        public int Id { get; set; }

        public int? MemberId { get; set; }

        [StringLength(50)]
        public string DealType { get; set; }

        [Required]
        [StringLength(100)]
        public string Amount { get; set; }

        [StringLength(200)]
        public string Source { get; set; }

        public DateTime? Time { get; set; }

        [StringLength(800)]
        public string Remark { get; set; }
    }
}
