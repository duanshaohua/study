namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Manage")]
    public partial class Manage
    {
        public int Id { get; set; }

        [StringLength(40)]
        public string Uid { get; set; }

        [StringLength(100)]
        public string Password { get; set; }

        [StringLength(20)]
        public string Secret { get; set; }

        [StringLength(100)]
        public string Nickname { get; set; }

        public int? Role { get; set; }

        [StringLength(4000)]
        public string Rights { get; set; }

        [StringLength(40)]
        public string Custos { get; set; }

        [StringLength(500)]
        public string Avatar { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(100)]
        public string Shortcut { get; set; }

        public int? Status { get; set; }

        public DateTime? CreationTime { get; set; }
    }
}
