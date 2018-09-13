namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MemberAffair")]
    public partial class MemberAffair
    {
        public int Id { get; set; }

        public int? Type { get; set; }

        [StringLength(100)]
        public string ClaimMan { get; set; }

        public int? Applicant { get; set; }

        public int? ApplyMember { get; set; }

        public int? Respondent { get; set; }

        [StringLength(1000)]
        public string Msg { get; set; }

        public DateTime? Time { get; set; }

        public byte? Agree { get; set; }

        public int? For { get; set; }

        [StringLength(100)]
        public string Relation { get; set; }
    }
}
