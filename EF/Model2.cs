namespace EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Model2")
        {
        }

        public virtual DbSet<Advertise> Advertise { get; set; }
        public virtual DbSet<Advertisement> Advertisement { get; set; }
        public virtual DbSet<Article> Article { get; set; }
        public virtual DbSet<ArticleComment> ArticleComment { get; set; }
        public virtual DbSet<ArticleFields> ArticleFields { get; set; }
        public virtual DbSet<ArticleImage> ArticleImage { get; set; }
        public virtual DbSet<Cashier> Cashier { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<CategoryGroup> CategoryGroup { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<DataBind> DataBind { get; set; }
        public virtual DbSet<DataTemplate> DataTemplate { get; set; }
        public virtual DbSet<Feedback> Feedback { get; set; }
        public virtual DbSet<Goods> Goods { get; set; }
        public virtual DbSet<Link> Link { get; set; }
        public virtual DbSet<Manage> Manage { get; set; }
        public virtual DbSet<ManageLog> ManageLog { get; set; }
        public virtual DbSet<Member> Member { get; set; }
        public virtual DbSet<MemberAddress> MemberAddress { get; set; }
        public virtual DbSet<MemberAffair> MemberAffair { get; set; }
        public virtual DbSet<MemberDetailed> MemberDetailed { get; set; }
        public virtual DbSet<MemberFavorites> MemberFavorites { get; set; }
        public virtual DbSet<MemberGrade> MemberGrade { get; set; }
        public virtual DbSet<MemberMessage> MemberMessage { get; set; }
        public virtual DbSet<MemberMessageState> MemberMessageState { get; set; }
        public virtual DbSet<MemberOrders> MemberOrders { get; set; }
        public virtual DbSet<MemberPedigree> MemberPedigree { get; set; }
        public virtual DbSet<MemberRelation> MemberRelation { get; set; }
        public virtual DbSet<MemberTags> MemberTags { get; set; }
        public virtual DbSet<RecruitInfo> RecruitInfo { get; set; }
        public virtual DbSet<RecruitJoin> RecruitJoin { get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<StoreManage> StoreManage { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<WeChat> WeChat { get; set; }
        public virtual DbSet<View_1> View_1 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Advertise>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Advertise>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Advertise>()
                .Property(e => e.Link)
                .IsUnicode(false);

            modelBuilder.Entity<Advertise>()
                .Property(e => e.Intro)
                .IsUnicode(false);

            modelBuilder.Entity<Advertisement>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Advertisement>()
                .Property(e => e.Codein)
                .IsUnicode(false);

            modelBuilder.Entity<Advertisement>()
                .Property(e => e.Codeem)
                .IsUnicode(false);

            modelBuilder.Entity<Advertisement>()
                .Property(e => e.Width)
                .IsUnicode(false);

            modelBuilder.Entity<Advertisement>()
                .Property(e => e.Height)
                .IsUnicode(false);

            modelBuilder.Entity<Advertisement>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Article>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Article>()
                .Property(e => e.Author)
                .IsUnicode(false);

            modelBuilder.Entity<Article>()
                .Property(e => e.Come)
                .IsUnicode(false);

            modelBuilder.Entity<Article>()
                .Property(e => e.Intro)
                .IsUnicode(false);

            modelBuilder.Entity<Article>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<Article>()
                .Property(e => e.Cover)
                .IsUnicode(false);

            modelBuilder.Entity<Article>()
                .Property(e => e.Expand)
                .IsUnicode(false);

            modelBuilder.Entity<Article>()
                .Property(e => e.Alias)
                .IsUnicode(false);

            modelBuilder.Entity<Article>()
                .Property(e => e.Link)
                .IsUnicode(false);

            modelBuilder.Entity<Article>()
                .Property(e => e.Tags)
                .IsUnicode(false);

            modelBuilder.Entity<Article>()
                .Property(e => e.SeoTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Article>()
                .Property(e => e.SeoKeywords)
                .IsUnicode(false);

            modelBuilder.Entity<Article>()
                .Property(e => e.SeoDescription)
                .IsUnicode(false);

            modelBuilder.Entity<ArticleComment>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<ArticleComment>()
                .Property(e => e.Reply)
                .IsUnicode(false);

            modelBuilder.Entity<ArticleFields>()
                .Property(e => e.FieldName)
                .IsUnicode(false);

            modelBuilder.Entity<ArticleFields>()
                .Property(e => e.Aliases)
                .IsUnicode(false);

            modelBuilder.Entity<ArticleFields>()
                .Property(e => e.InitialVal)
                .IsUnicode(false);

            modelBuilder.Entity<ArticleImage>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<ArticleImage>()
                .Property(e => e.Intro)
                .IsUnicode(false);

            modelBuilder.Entity<ArticleImage>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Cashier>()
                .Property(e => e.PoundageAmount)
                .HasPrecision(9, 2);

            modelBuilder.Entity<Category>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.Entitle)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.Template)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.Alias)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.Link)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.Target)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.DataUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.Flash)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.Icon)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.IconFont)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.CustomFields)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.SeoTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.SeoKeywords)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.SeoDescription)
                .IsUnicode(false);

            modelBuilder.Entity<CategoryGroup>()
                .Property(e => e.Alias)
                .IsUnicode(false);

            modelBuilder.Entity<CategoryGroup>()
                .Property(e => e.Link)
                .IsUnicode(false);

            modelBuilder.Entity<City>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<City>()
                .Property(e => e.ZipCode)
                .IsUnicode(false);

            modelBuilder.Entity<City>()
                .Property(e => e.AreaCode)
                .IsUnicode(false);

            modelBuilder.Entity<City>()
                .Property(e => e.Key)
                .IsUnicode(false);

            modelBuilder.Entity<DataBind>()
                .Property(e => e.PartId)
                .IsUnicode(false);

            modelBuilder.Entity<DataBind>()
                .Property(e => e.DataStyle)
                .IsUnicode(false);

            modelBuilder.Entity<DataTemplate>()
                .Property(e => e.HeaderTemplate)
                .IsUnicode(false);

            modelBuilder.Entity<DataTemplate>()
                .Property(e => e.ItemTemplate)
                .IsUnicode(false);

            modelBuilder.Entity<DataTemplate>()
                .Property(e => e.FooterTemplate)
                .IsUnicode(false);

            modelBuilder.Entity<DataTemplate>()
                .Property(e => e.Style)
                .IsUnicode(false);

            modelBuilder.Entity<Goods>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Goods>()
                .Property(e => e.Price)
                .IsUnicode(false);

            modelBuilder.Entity<Goods>()
                .Property(e => e.Agio)
                .IsUnicode(false);

            modelBuilder.Entity<Goods>()
                .Property(e => e.Integral)
                .IsUnicode(false);

            modelBuilder.Entity<Goods>()
                .Property(e => e.Freight)
                .IsUnicode(false);

            modelBuilder.Entity<Goods>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Goods>()
                .Property(e => e.AttrJson)
                .IsUnicode(false);

            modelBuilder.Entity<Link>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Link>()
                .Property(e => e.Url)
                .IsUnicode(false);

            modelBuilder.Entity<Link>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Manage>()
                .Property(e => e.Uid)
                .IsUnicode(false);

            modelBuilder.Entity<Manage>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Manage>()
                .Property(e => e.Nickname)
                .IsUnicode(false);

            modelBuilder.Entity<Manage>()
                .Property(e => e.Rights)
                .IsUnicode(false);

            modelBuilder.Entity<Manage>()
                .Property(e => e.Custos)
                .IsUnicode(false);

            modelBuilder.Entity<Manage>()
                .Property(e => e.Avatar)
                .IsUnicode(false);

            modelBuilder.Entity<Manage>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Manage>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Manage>()
                .Property(e => e.Shortcut)
                .IsUnicode(false);

            modelBuilder.Entity<ManageLog>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.Tags)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.CardNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.Purview)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.NickName)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.HeadPortrait)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.RealName)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.PersonalPhotos)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.Sex)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.BirthdayString)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.BurialPlace)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.Education)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.Occupation)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.Province)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.County)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.Area)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.AddressInDetail)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.CurrentResidence)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.AncestralHome)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.Nation)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.Rmb)
                .HasPrecision(9, 2);

            modelBuilder.Entity<MemberAddress>()
                .Property(e => e.Label)
                .IsUnicode(false);

            modelBuilder.Entity<MemberAddress>()
                .Property(e => e.Consignee)
                .IsUnicode(false);

            modelBuilder.Entity<MemberAddress>()
                .Property(e => e.Province)
                .IsUnicode(false);

            modelBuilder.Entity<MemberAddress>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<MemberAddress>()
                .Property(e => e.County)
                .IsUnicode(false);

            modelBuilder.Entity<MemberAddress>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<MemberAddress>()
                .Property(e => e.ZipCode)
                .IsUnicode(false);

            modelBuilder.Entity<MemberAddress>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<MemberDetailed>()
                .Property(e => e.DealType)
                .IsUnicode(false);

            modelBuilder.Entity<MemberDetailed>()
                .Property(e => e.Amount)
                .IsUnicode(false);

            modelBuilder.Entity<MemberDetailed>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<MemberDetailed>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<MemberFavorites>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<MemberGrade>()
                .Property(e => e.Amount)
                .HasPrecision(9, 2);

            modelBuilder.Entity<MemberGrade>()
                .Property(e => e.Discount)
                .HasPrecision(9, 2);

            modelBuilder.Entity<MemberMessage>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<MemberOrders>()
                .Property(e => e.PayablePrice)
                .HasPrecision(9, 2);

            modelBuilder.Entity<MemberOrders>()
                .Property(e => e.RealPrice)
                .HasPrecision(9, 2);

            modelBuilder.Entity<MemberOrders>()
                .Property(e => e.OrderPrice)
                .HasPrecision(9, 2);

            modelBuilder.Entity<MemberOrders>()
                .Property(e => e.Freight)
                .HasPrecision(9, 2);

            modelBuilder.Entity<MemberOrders>()
                .Property(e => e.InvoiceTitle)
                .IsUnicode(false);

            modelBuilder.Entity<MemberOrders>()
                .Property(e => e.InvoicePrice)
                .HasPrecision(9, 2);

            modelBuilder.Entity<MemberOrders>()
                .Property(e => e.Evaluation)
                .IsUnicode(false);

            modelBuilder.Entity<MemberOrders>()
                .Property(e => e.Feedback)
                .IsUnicode(false);

            modelBuilder.Entity<MemberRelation>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<RecruitInfo>()
                .Property(e => e.Zhiweimingcheng)
                .IsUnicode(false);

            modelBuilder.Entity<RecruitInfo>()
                .Property(e => e.Zhiweileixing)
                .IsUnicode(false);

            modelBuilder.Entity<RecruitInfo>()
                .Property(e => e.Zhiweiyaoqiu)
                .IsUnicode(false);

            modelBuilder.Entity<RecruitInfo>()
                .Property(e => e.Zhaopinbumen)
                .IsUnicode(false);

            modelBuilder.Entity<RecruitInfo>()
                .Property(e => e.Xingbieyaoqiu)
                .IsUnicode(false);

            modelBuilder.Entity<RecruitInfo>()
                .Property(e => e.Gongzuojingyan)
                .IsUnicode(false);

            modelBuilder.Entity<RecruitInfo>()
                .Property(e => e.Gongzuodiqu)
                .IsUnicode(false);

            modelBuilder.Entity<RecruitInfo>()
                .Property(e => e.Yaoqiuyudaiyu)
                .IsUnicode(false);

            modelBuilder.Entity<RecruitInfo>()
                .Property(e => e.Lianxiren)
                .IsUnicode(false);

            modelBuilder.Entity<RecruitInfo>()
                .Property(e => e.Lianxidianhua)
                .IsUnicode(false);

            modelBuilder.Entity<RecruitInfo>()
                .Property(e => e.Danweichuanzhen)
                .IsUnicode(false);

            modelBuilder.Entity<RecruitInfo>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<RecruitInfo>()
                .Property(e => e.Tongxindizhi)
                .IsUnicode(false);

            modelBuilder.Entity<RecruitInfo>()
                .Property(e => e.Xueli)
                .IsUnicode(false);

            modelBuilder.Entity<RecruitJoin>()
                .Property(e => e.Xingming)
                .IsUnicode(false);

            modelBuilder.Entity<RecruitJoin>()
                .Property(e => e.Xingbie)
                .IsUnicode(false);

            modelBuilder.Entity<RecruitJoin>()
                .Property(e => e.Minzu)
                .IsUnicode(false);

            modelBuilder.Entity<RecruitJoin>()
                .Property(e => e.Chushengriqi)
                .IsUnicode(false);

            modelBuilder.Entity<RecruitJoin>()
                .Property(e => e.Shengao)
                .IsUnicode(false);

            modelBuilder.Entity<RecruitJoin>()
                .Property(e => e.Shenfenzhenghao)
                .IsUnicode(false);

            modelBuilder.Entity<RecruitJoin>()
                .Property(e => e.Jiguan)
                .IsUnicode(false);

            modelBuilder.Entity<RecruitJoin>()
                .Property(e => e.Xueli)
                .IsUnicode(false);

            modelBuilder.Entity<RecruitJoin>()
                .Property(e => e.Zanzhudizhi)
                .IsUnicode(false);

            modelBuilder.Entity<RecruitJoin>()
                .Property(e => e.Biyeyuanxiao)
                .IsUnicode(false);

            modelBuilder.Entity<RecruitJoin>()
                .Property(e => e.Waiyushuiping)
                .IsUnicode(false);

            modelBuilder.Entity<RecruitJoin>()
                .Property(e => e.Hunfou)
                .IsUnicode(false);

            modelBuilder.Entity<RecruitJoin>()
                .Property(e => e.Zhuanyetechang)
                .IsUnicode(false);

            modelBuilder.Entity<RecruitJoin>()
                .Property(e => e.Beiyong)
                .IsUnicode(false);

            modelBuilder.Entity<RecruitJoin>()
                .Property(e => e.Yingpingangwei)
                .IsUnicode(false);

            modelBuilder.Entity<RecruitJoin>()
                .Property(e => e.Daiyuyaoqiu)
                .IsFixedLength();

            modelBuilder.Entity<RecruitJoin>()
                .Property(e => e.Lianxidianhua)
                .IsUnicode(false);

            modelBuilder.Entity<RecruitJoin>()
                .Property(e => e.Shouji)
                .IsUnicode(false);

            modelBuilder.Entity<RecruitJoin>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<RecruitJoin>()
                .Property(e => e.Xuexijingli)
                .IsUnicode(false);

            modelBuilder.Entity<RecruitJoin>()
                .Property(e => e.Gongzuojingli)
                .IsUnicode(false);

            modelBuilder.Entity<RecruitJoin>()
                .Property(e => e.Gerenjianli)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.Intro)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.Province)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.District)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.Street)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.Coordinate)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.Contact)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.AboutUs)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.Facade)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .HasMany(e => e.StoreManage)
                .WithOptional(e => e.Store1)
                .HasForeignKey(e => e.Store);

            modelBuilder.Entity<StoreManage>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<View_1>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<View_1>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<View_1>()
                .Property(e => e.Link)
                .IsUnicode(false);

            modelBuilder.Entity<View_1>()
                .Property(e => e.Intro)
                .IsUnicode(false);
        }
    }
}
