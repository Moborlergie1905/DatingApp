namespace Dating.API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialMig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Message",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProfileID = c.Int(nullable: false),
                        Recipient = c.Int(nullable: false),
                        MsgContent = c.String(),
                        TimeSent = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Profile", t => t.ProfileID, cascadeDelete: true)
                .Index(t => t.ProfileID);
            
            CreateTable(
                "dbo.Profile",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(),
                        Gender = c.String(),
                        DOB = c.DateTime(nullable: false),
                        Country = c.String(),
                        City = c.String(),
                        Province = c.String(),
                        Marital = c.String(),
                        Height = c.String(),
                        Weight = c.String(),
                        BodyType = c.String(),
                        HaveChild = c.String(),
                        WantChild = c.String(),
                        Education = c.String(),
                        Ethnicity = c.String(),
                        Religion = c.String(),
                        Occupation = c.String(),
                        Smoke = c.String(),
                        Drink = c.String(),
                        RelationshipType = c.String(),
                        Mobile = c.String(),
                        Nickname = c.String(),
                        Desc = c.String(),
                        IsActivated = c.String(),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.DateRegister",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AgeMin = c.Int(nullable: false),
                        AgeMax = c.Int(nullable: false),
                        City = c.String(),
                        HasChild = c.String(),
                        WantChild = c.String(),
                        Height = c.Int(nullable: false),
                        Weight = c.Int(nullable: false),
                        BodyType = c.String(),
                        Education = c.String(),
                        Ethnicity = c.String(),
                        Religion = c.String(),
                        Smoke = c.String(),
                        Drink = c.String(),
                        RelationshipType = c.String(),
                        ProfileID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Profile", t => t.ProfileID, cascadeDelete: true)
                .Index(t => t.ProfileID);
            
            CreateTable(
                "dbo.Interest",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProfileID = c.Int(nullable: false),
                        Recepient = c.Int(nullable: false),
                        Acknowledged = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Profile", t => t.ProfileID, cascadeDelete: true)
                .Index(t => t.ProfileID);
            
            CreateTable(
                "dbo.ProfileImage",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ImagePath = c.String(),
                        ProfileID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Profile", t => t.ProfileID, cascadeDelete: true)
                .Index(t => t.ProfileID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProfileImage", "ProfileID", "dbo.Profile");
            DropForeignKey("dbo.Message", "ProfileID", "dbo.Profile");
            DropForeignKey("dbo.Interest", "ProfileID", "dbo.Profile");
            DropForeignKey("dbo.DateRegister", "ProfileID", "dbo.Profile");
            DropIndex("dbo.ProfileImage", new[] { "ProfileID" });
            DropIndex("dbo.Interest", new[] { "ProfileID" });
            DropIndex("dbo.DateRegister", new[] { "ProfileID" });
            DropIndex("dbo.Message", new[] { "ProfileID" });
            DropTable("dbo.ProfileImage");
            DropTable("dbo.Interest");
            DropTable("dbo.DateRegister");
            DropTable("dbo.Profile");
            DropTable("dbo.Message");
        }
    }
}
