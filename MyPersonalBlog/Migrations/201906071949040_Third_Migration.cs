namespace MyPersonalBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Third_Migration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kullanıcılar", "ProfileImageFilename", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Kullanıcılar", "ProfileImageFilename");
        }
    }
}
