namespace RestMan.Context.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddShifts : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Shifts",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    OpenedAt = c.DateTime(nullable: false),
                    ClosedAt = c.DateTime(),
                })
                .PrimaryKey(t => t.Id);

            AddColumn("dbo.Orders", "ShiftId", c => c.Int(nullable: false));
            CreateIndex("dbo.Orders", "ShiftId");
            AddForeignKey("dbo.Orders", "ShiftId", "dbo.Shifts", "Id", cascadeDelete: true);
        }

        public override void Down()
        {
            DropForeignKey("dbo.Orders", "ShiftId", "dbo.Shifts");
            DropIndex("dbo.Orders", new[] { "ShiftId" });
            DropColumn("dbo.Orders", "ShiftId");
            DropTable("dbo.Shifts");
        }
    }
}
