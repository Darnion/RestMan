namespace RestMan.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PayOptionsAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MenuItems", "PaidByGiftCard", c => c.Int());
            AddColumn("dbo.MenuItems", "PaidByCash", c => c.Int());
            AddColumn("dbo.MenuItems", "PaidByCredit", c => c.Int());
            AddColumn("dbo.MenuItems", "PaidByQR", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MenuItems", "PaidByQR");
            DropColumn("dbo.MenuItems", "PaidByCredit");
            DropColumn("dbo.MenuItems", "PaidByCash");
            DropColumn("dbo.MenuItems", "PaidByGiftCard");
        }
    }
}
