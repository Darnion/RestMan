namespace RestMan.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fix : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderMenuItems", "MenuItemId", "dbo.MenuItems");
            DropIndex("dbo.OrderMenuItems", new[] { "MenuItemId" });
            DropPrimaryKey("dbo.MenuItems");
            AddColumn("dbo.OrderMenuItems", "MenuItem_Id", c => c.Long());
            AlterColumn("dbo.MenuItems", "Id", c => c.Long(nullable: false, identity: true));
            AddPrimaryKey("dbo.MenuItems", "Id");
            CreateIndex("dbo.OrderMenuItems", "MenuItem_Id");
            AddForeignKey("dbo.OrderMenuItems", "MenuItem_Id", "dbo.MenuItems", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderMenuItems", "MenuItem_Id", "dbo.MenuItems");
            DropIndex("dbo.OrderMenuItems", new[] { "MenuItem_Id" });
            DropPrimaryKey("dbo.MenuItems");
            AlterColumn("dbo.MenuItems", "Id", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.OrderMenuItems", "MenuItem_Id");
            AddPrimaryKey("dbo.MenuItems", "Id");
            CreateIndex("dbo.OrderMenuItems", "MenuItemId");
            AddForeignKey("dbo.OrderMenuItems", "MenuItemId", "dbo.MenuItems", "Id", cascadeDelete: true);
        }
    }
}
