namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MemberAddress")]
    public partial class MemberAddress
    {
        public int Id { get; set; }

        public int? MemberId { get; set; }

        [StringLength(100)]
        public string Label { get; set; }

        [StringLength(100)]
        public string Consignee { get; set; }

        [StringLength(200)]
        public string Province { get; set; }

        [StringLength(200)]
        public string City { get; set; }

        [StringLength(200)]
        public string County { get; set; }

        [StringLength(300)]
        public string Address { get; set; }

        [StringLength(100)]
        public string ZipCode { get; set; }

        [StringLength(100)]
        public string Phone { get; set; }

        public bool? Default { get; set; }
    }
}
