namespace TeenTasks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Profiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false),
                        Type = c.Int(nullable: false),
                        FirstName = c.String(nullable: false),
                        LastInitial = c.String(nullable: false, maxLength: 1),
                        OwnerId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.OwnerId)
                .Index(t => t.OwnerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Profiles", "OwnerId", "dbo.AspNetUsers");
            DropIndex("dbo.Profiles", new[] { "OwnerId" });
            DropTable("dbo.Profiles");
        }
    }
}
