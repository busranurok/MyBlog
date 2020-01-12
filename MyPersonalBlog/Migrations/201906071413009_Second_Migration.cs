namespace MyPersonalBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second_Migration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kullanıcılar", "Firstname", c => c.String());
            DropColumn("dbo.Kullanıcılar", "Firtname");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kullanıcılar", "Firtname", c => c.String());
            DropColumn("dbo.Kullanıcılar", "Firstname");
        }
    }
}
