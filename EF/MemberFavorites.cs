namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MemberFavorites
    {
        public int Id { get; set; }

        public int? MemberId { get; set; }

        public int? Data { get; set; }

        public bool? Love { get; set; }

        [StringLength(3000)]
        public string Remark { get; set; }
    }
}
