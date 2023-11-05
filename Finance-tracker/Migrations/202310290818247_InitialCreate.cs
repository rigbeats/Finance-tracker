namespace Finance_tracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BudgetEntries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Name = c.String(),
                        Amount = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.String(),
                        HolderFullName = c.String(),
                        ValidThru = c.String(),
                        Balance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CardId = c.Int(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Category = c.String(),
                        Date = c.DateTime(nullable: false),
                        Number = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cards", t => t.CardId, cascadeDelete: true)
                .Index(t => t.CardId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Firstname = c.String(),
                        Login = c.String(),
                        Password = c.String(),
                        DefaultCardId = c.Int(nullable: false),
                        UserDataId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserData",
                c => new
                    {
                        UserDataId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        EmailAddress = c.String(),
                        Password = c.String(),
                        PhoneNumber = c.String(),
                        Country = c.String(),
                        City = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.UserDataId)
                .ForeignKey("dbo.Users", t => t.UserDataId)
                .Index(t => t.UserDataId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserData", "UserDataId", "dbo.Users");
            DropForeignKey("dbo.Cards", "UserId", "dbo.Users");
            DropForeignKey("dbo.Transactions", "CardId", "dbo.Cards");
            DropIndex("dbo.UserData", new[] { "UserDataId" });
            DropIndex("dbo.Transactions", new[] { "CardId" });
            DropIndex("dbo.Cards", new[] { "UserId" });
            DropTable("dbo.UserData");
            DropTable("dbo.Users");
            DropTable("dbo.Transactions");
            DropTable("dbo.Cards");
            DropTable("dbo.BudgetEntries");
        }
    }
}
