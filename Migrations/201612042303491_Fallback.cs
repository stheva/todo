namespace TodoList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fallback : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Todos", "UserId", "dbo.Users");
            DropIndex("dbo.Todos", new[] { "UserId" });
            DropColumn("dbo.Todos", "UserId");
            DropTable("dbo.Users");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        EmailAddress = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Todos", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Todos", "UserId");
            AddForeignKey("dbo.Todos", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
    }
}
