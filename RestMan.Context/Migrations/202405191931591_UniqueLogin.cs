namespace RestMan.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UniqueLogin : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "Title", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.MenuItems", "Title", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Shops", "Title", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Halls", "Title", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Tables", "Title", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Users", "Login", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Roles", "Title", c => c.String(nullable: false, maxLength: 255));
            CreateIndex("dbo.Users", "Login", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", new[] { "Login" });
            AlterColumn("dbo.Roles", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Login", c => c.String(nullable: false));
            AlterColumn("dbo.Tables", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Halls", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Shops", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.MenuItems", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Categories", "Title", c => c.String(nullable: false));
        }
    }
}
