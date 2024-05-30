namespace RestMan.Context.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class OrderChangeAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "ChangeGiven", c => c.Int());
        }

        public override void Down()
        {
            DropColumn("dbo.Orders", "ChangeGiven");
        }
    }
}
