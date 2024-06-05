namespace RestMan.Context.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddSalt : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MenuItems", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Tables", "HallId", "dbo.Halls");
            DropForeignKey("dbo.Orders", "WaiterId", "dbo.Users");
            DropIndex("dbo.MenuItems", new[] { "CategoryId" });
            DropIndex("dbo.Tables", new[] { "HallId" });
            DropIndex("dbo.Orders", new[] { "WaiterId" });
            DropPrimaryKey("dbo.Categories");
            DropPrimaryKey("dbo.Halls");
            DropPrimaryKey("dbo.Users");
            AddColumn("dbo.MenuItems", "Category_Id", c => c.Long());
            AddColumn("dbo.Tables", "Hall_Id", c => c.Long());
            AddColumn("dbo.Orders", "Waiter_Id", c => c.Long());
            AddColumn("dbo.Users", "Salt", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Categories", "Id", c => c.Long(nullable: false, identity: true));
            AlterColumn("dbo.Halls", "Id", c => c.Long(nullable: false, identity: true));
            AlterColumn("dbo.Users", "Id", c => c.Long(nullable: false, identity: true));
            AddPrimaryKey("dbo.Categories", "Id");
            AddPrimaryKey("dbo.Halls", "Id");
            AddPrimaryKey("dbo.Users", "Id");
            CreateIndex("dbo.MenuItems", "Category_Id");
            CreateIndex("dbo.Tables", "Hall_Id");
            CreateIndex("dbo.Orders", "Waiter_Id");
            AddForeignKey("dbo.MenuItems", "Category_Id", "dbo.Categories", "Id");
            AddForeignKey("dbo.Tables", "Hall_Id", "dbo.Halls", "Id");
            AddForeignKey("dbo.Orders", "Waiter_Id", "dbo.Users", "Id");
        }

        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Waiter_Id", "dbo.Users");
            DropForeignKey("dbo.Tables", "Hall_Id", "dbo.Halls");
            DropForeignKey("dbo.MenuItems", "Category_Id", "dbo.Categories");
            DropIndex("dbo.Orders", new[] { "Waiter_Id" });
            DropIndex("dbo.Tables", new[] { "Hall_Id" });
            DropIndex("dbo.MenuItems", new[] { "Category_Id" });
            DropPrimaryKey("dbo.Users");
            DropPrimaryKey("dbo.Halls");
            DropPrimaryKey("dbo.Categories");
            AlterColumn("dbo.Users", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Halls", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Categories", "Id", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Users", "Salt");
            DropColumn("dbo.Orders", "Waiter_Id");
            DropColumn("dbo.Tables", "Hall_Id");
            DropColumn("dbo.MenuItems", "Category_Id");
            AddPrimaryKey("dbo.Users", "Id");
            AddPrimaryKey("dbo.Halls", "Id");
            AddPrimaryKey("dbo.Categories", "Id");
            CreateIndex("dbo.Orders", "WaiterId");
            CreateIndex("dbo.Tables", "HallId");
            CreateIndex("dbo.MenuItems", "CategoryId");
            AddForeignKey("dbo.Orders", "WaiterId", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Tables", "HallId", "dbo.Halls", "Id", cascadeDelete: true);
            AddForeignKey("dbo.MenuItems", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
        }
    }
}
