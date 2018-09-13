namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WeChat")]
    public partial class WeChat
    {
        public int Id { get; set; }

        [StringLength(300)]
        public string Name { get; set; }

        [StringLength(501)]
        public string Describe { get; set; }

        [StringLength(300)]
        public string AppId { get; set; }

        [StringLength(300)]
        public string AppSecret { get; set; }

        [StringLength(100)]
        public string CallbackDomain { get; set; }

        [StringLength(300)]
        public string AccessToken { get; set; }

        public DateTime? AccessTokenCreateTime { get; set; }

        public DateTime? AccessTokenOverdueTime { get; set; }

        public int? AccessTokenExpiresIn { get; set; }

        [StringLength(100)]
        public string PublicNumber { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(100)]
        public string OriginalId { get; set; }

        [StringLength(100)]
        public string ManagerOpenid { get; set; }

        [StringLength(300)]
        public string JsTicket { get; set; }

        public DateTime? JsTicketCreateTime { get; set; }

        public DateTime? JsTicketOverdueTime { get; set; }

        public int? JsTicketExpiresIn { get; set; }

        [StringLength(100)]
        public string MerchantNumber { get; set; }

        [StringLength(100)]
        public string PayApiKey { get; set; }
    }
}
