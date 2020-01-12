namespace MyPersonalBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First_Migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ek Bilgiler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Content = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kullanıcılar", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Kullanıcılar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Firtname = c.String(),
                        Lastname = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        IsAdmin = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Makaleler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryId = c.Int(nullable: false),
                        ArticleTitle = c.String(),
                        ArticleContent = c.String(),
                        IsDraft = c.Boolean(nullable: false),
                        ArticleCreatedDate = c.DateTime(nullable: false),
                        ArticleModifiedDate = c.DateTime(nullable: false),
                        ArticleCreatedUserId = c.Int(nullable: false),
                        ArticleModifiedUserId = c.Int(nullable: false),
                        ImageURL = c.String(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kategoriler", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Kullanıcılar", t => t.User_Id)
                .Index(t => t.CategoryId)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Kategoriler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryTitle = c.String(),
                        CategoryDescription = c.String(),
                        CategoryCreatedDate = c.DateTime(nullable: false),
                        CategoriModifiedDate = c.DateTime(nullable: false),
                        CategoryCreatedUserId = c.Int(nullable: false),
                        CategoryModifiedUserId = c.Int(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kullanıcılar", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Sertifikalar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CertificateName = c.String(),
                        CertificateReceived = c.String(),
                        DateOfReceiptOfCertificate = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kullanıcılar", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Yorumlar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ArticleId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        Nick = c.String(),
                        CommentText = c.String(),
                        CommentCreatedDate = c.DateTime(nullable: false),
                        CommentModifiedDate = c.DateTime(nullable: false),
                        CommentCreatedUserId = c.Int(nullable: false),
                        CommentModifiedUserId = c.Int(nullable: false),
                        IsApproval = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Makaleler", t => t.ArticleId, cascadeDelete: true)
                .ForeignKey("dbo.Kullanıcılar", t => t.UserId, cascadeDelete: true)
                .Index(t => t.ArticleId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.İletişim",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Firstname = c.String(),
                        Lastname = c.String(),
                        Email = c.String(),
                        TopicTitle = c.String(),
                        Message = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Beğenmeme",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ArticleId = c.Int(nullable: false),
                        ArticleDislikedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Makaleler", t => t.ArticleId, cascadeDelete: true)
                .Index(t => t.ArticleId);
            
            CreateTable(
                "dbo.Görüntüleme",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ArticleId = c.Int(nullable: false),
                        ArticleDisplayedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Makaleler", t => t.ArticleId, cascadeDelete: true)
                .Index(t => t.ArticleId);
            
            CreateTable(
                "dbo.Eğitim Bilgileri",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SchoolName = c.String(),
                        CountryOfSchool = c.String(),
                        CityOfSchool = c.String(),
                        DiplomaScore = c.Single(nullable: false),
                        StartedDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        IsContinue = c.Boolean(nullable: false),
                        LevelOfEducation = c.String(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kullanıcılar", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.İş Tecrübesi",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        WorkedCountry = c.String(),
                        WorkedCity = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        IsContinue = c.Boolean(nullable: false),
                        TheWorkDone = c.String(),
                        Position = c.String(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kullanıcılar", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Beğenme",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ArticleId = c.Int(nullable: false),
                        ArticleLikedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Makaleler", t => t.ArticleId, cascadeDelete: true)
                .Index(t => t.ArticleId);
            
            CreateTable(
                "dbo.Seminerler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SeminarName = c.String(),
                        TakenSeminarDate = c.DateTime(nullable: false),
                        TakenInstitution = c.String(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kullanıcılar", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Yetenekler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SkillName = c.String(),
                        SkillLevel = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kullanıcılar", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Aboneler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        ActiveGuid = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Yetenekler", "UserId", "dbo.Kullanıcılar");
            DropForeignKey("dbo.Seminerler", "UserId", "dbo.Kullanıcılar");
            DropForeignKey("dbo.Beğenme", "ArticleId", "dbo.Makaleler");
            DropForeignKey("dbo.İş Tecrübesi", "UserId", "dbo.Kullanıcılar");
            DropForeignKey("dbo.Eğitim Bilgileri", "UserId", "dbo.Kullanıcılar");
            DropForeignKey("dbo.Görüntüleme", "ArticleId", "dbo.Makaleler");
            DropForeignKey("dbo.Beğenmeme", "ArticleId", "dbo.Makaleler");
            DropForeignKey("dbo.Yorumlar", "UserId", "dbo.Kullanıcılar");
            DropForeignKey("dbo.Yorumlar", "ArticleId", "dbo.Makaleler");
            DropForeignKey("dbo.Sertifikalar", "UserId", "dbo.Kullanıcılar");
            DropForeignKey("dbo.Makaleler", "User_Id", "dbo.Kullanıcılar");
            DropForeignKey("dbo.Makaleler", "CategoryId", "dbo.Kategoriler");
            DropForeignKey("dbo.Kategoriler", "User_Id", "dbo.Kullanıcılar");
            DropForeignKey("dbo.Ek Bilgiler", "UserId", "dbo.Kullanıcılar");
            DropIndex("dbo.Yetenekler", new[] { "UserId" });
            DropIndex("dbo.Seminerler", new[] { "UserId" });
            DropIndex("dbo.Beğenme", new[] { "ArticleId" });
            DropIndex("dbo.İş Tecrübesi", new[] { "UserId" });
            DropIndex("dbo.Eğitim Bilgileri", new[] { "UserId" });
            DropIndex("dbo.Görüntüleme", new[] { "ArticleId" });
            DropIndex("dbo.Beğenmeme", new[] { "ArticleId" });
            DropIndex("dbo.Yorumlar", new[] { "UserId" });
            DropIndex("dbo.Yorumlar", new[] { "ArticleId" });
            DropIndex("dbo.Sertifikalar", new[] { "UserId" });
            DropIndex("dbo.Kategoriler", new[] { "User_Id" });
            DropIndex("dbo.Makaleler", new[] { "User_Id" });
            DropIndex("dbo.Makaleler", new[] { "CategoryId" });
            DropIndex("dbo.Ek Bilgiler", new[] { "UserId" });
            DropTable("dbo.Aboneler");
            DropTable("dbo.Yetenekler");
            DropTable("dbo.Seminerler");
            DropTable("dbo.Beğenme");
            DropTable("dbo.İş Tecrübesi");
            DropTable("dbo.Eğitim Bilgileri");
            DropTable("dbo.Görüntüleme");
            DropTable("dbo.Beğenmeme");
            DropTable("dbo.İletişim");
            DropTable("dbo.Yorumlar");
            DropTable("dbo.Sertifikalar");
            DropTable("dbo.Kategoriler");
            DropTable("dbo.Makaleler");
            DropTable("dbo.Kullanıcılar");
            DropTable("dbo.Ek Bilgiler");
        }
    }
}
