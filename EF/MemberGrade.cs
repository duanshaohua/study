namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MemberGrade")]
    public partial class MemberGrade
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        public int? Grade { get; set; }

        public int? UpgradeExperience { get; set; }

        public bool? AutoUpgrade { get; set; }

        public decimal? Amount { get; set; }

        public int? Experience { get; set; }

        public decimal? Discount { get; set; }

        public bool? Default { get; set; }

        public bool? Lock { get; set; }
    }
}
