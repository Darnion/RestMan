namespace RestMan.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PayOptionsAdded1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "PaidByGiftCard", c => c.Int());
            AddColumn("dbo.Orders", "PaidByCash", c => c.Int());
            AddColumn("dbo.Orders", "PaidByCredit", c => c.Int());
            AddColumn("dbo.Orders", "PaidByQR", c => c.Int());
            DropColumn("dbo.MenuItems", "PaidByGiftCard");
            DropColumn("dbo.MenuItems", "PaidByCash");
            DropColumn("dbo.MenuItems", "PaidByCredit");
            DropColumn("dbo.MenuItems", "PaidByQR");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MenuItems", "PaidByQR", c => c.Int());
            AddColumn("dbo.MenuItems", "PaidByCredit", c => c.Int());
            AddColumn("dbo.MenuItems", "PaidByCash", c => c.Int());
            AddColumn("dbo.MenuItems", "PaidByGiftCard", c => c.Int());
            DropColumn("dbo.Orders", "PaidByQR");
            DropColumn("dbo.Orders", "PaidByCredit");
            DropColumn("dbo.Orders", "PaidByCash");
            DropColumn("dbo.Orders", "PaidByGiftCard");
        }
    }
}
