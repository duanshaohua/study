namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MemberPedigree")]
    public partial class MemberPedigree
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        public int? AccessType { get; set; }

        [StringLength(100)]
        public string AccessProblem { get; set; }

        [StringLength(100)]
        public string AccessKey { get; set; }

        public int? CreatePerson { get; set; }

        [StringLength(501)]
        public string Remark { get; set; }

        public DateTime? CreationTime { get; set; }

        [StringLength(20)]
        public string Surname { get; set; }

        [StringLength(501)]
        public string Origin { get; set; }

        public int? Relation { get; set; }

        [StringLength(3000)]
        public string Participation { get; set; }
    }
}
