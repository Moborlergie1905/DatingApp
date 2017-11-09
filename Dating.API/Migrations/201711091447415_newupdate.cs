namespace Dating.API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newupdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Profile", "FirstName", c => c.String());
            AlterColumn("dbo.Profile", "LastName", c => c.String());
            AlterColumn("dbo.Profile", "Email", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Profile", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Profile", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Profile", "FirstName", c => c.String(nullable: false));
        }
    }
}
