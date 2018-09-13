namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Member")]
    public partial class Member
    {
        public int Id { get; set; }

        public int? Grade { get; set; }

        [StringLength(3000)]
        public string Tags { get; set; }

        public bool? Auditing { get; set; }

        [StringLength(100)]
        public string CardNumber { get; set; }

        public int? Status { get; set; }

        [StringLength(20)]
        public string RegIp { get; set; }

        [StringLength(3000)]
        public string Purview { get; set; }

        public DateTime? RegTime { get; set; }

        [StringLength(100)]
        public string WeChatOpenId { get; set; }

        [StringLength(100)]
        public string Password { get; set; }

        [StringLength(20)]
        public string Secret { get; set; }

        public int? CreatePerson { get; set; }

        public bool? Live { get; set; }

        [StringLength(8000)]
        public string Remark { get; set; }

        [StringLength(100)]
        public string UnionID { get; set; }

        public int? Pedigree { get; set; }

        public int? Ranking { get; set; }

        public int? Elder { get; set; }

        public int? Mother { get; set; }

        [StringLength(1000)]
        public string Spouse { get; set; }

        [StringLength(100)]
        public string NickName { get; set; }

        [StringLength(100)]
        public string Phone { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(100)]
        public string UserName { get; set; }

        [StringLength(300)]
        public string HeadPortrait { get; set; }

        [StringLength(100)]
        public string Surname { get; set; }

        [StringLength(100)]
        public string RealName { get; set; }

        [StringLength(300)]
        public string PersonalPhotos { get; set; }

        [StringLength(20)]
        public string Sex { get; set; }

        public DateTime? Birthday { get; set; }

        [StringLength(300)]
        public string BirthdayString { get; set; }

        public byte? BirthdayCalendar { get; set; }

        public bool? LeapMonth { get; set; }

        public DateTime? TimeOfDeath { get; set; }

        [StringLength(500)]
        public string BurialPlace { get; set; }

        [StringLength(300)]
        public string Education { get; set; }

        [StringLength(300)]
        public string Occupation { get; set; }

        [StringLength(500)]
        public string Introduce { get; set; }

        [StringLength(100)]
        public string Country { get; set; }

        [StringLength(100)]
        public string Province { get; set; }

        [StringLength(100)]
        public string City { get; set; }

        [StringLength(100)]
        public string County { get; set; }

        [StringLength(100)]
        public string Area { get; set; }

        [StringLength(300)]
        public string AddressInDetail { get; set; }

        [StringLength(300)]
        public string CurrentResidence { get; set; }

        [StringLength(300)]
        public string AncestralHome { get; set; }

        [StringLength(100)]
        public string Nation { get; set; }

        [StringLength(20)]
        public string QQ { get; set; }

        public decimal? Rmb { get; set; }

        public int? Integral { get; set; }

        public int? Experience { get; set; }

        public int? VirtualCurrency { get; set; }
    }
}
