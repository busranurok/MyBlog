namespace MyPersonalBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Four_Migration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.İş Tecrübesi", "WorkDescription", c => c.String());
            AlterColumn("dbo.İş Tecrübesi", "TheWorkDone", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.İş Tecrübesi", "TheWorkDone", c => c.String());
            DropColumn("dbo.İş Tecrübesi", "WorkDescription");
        }
    }
}
