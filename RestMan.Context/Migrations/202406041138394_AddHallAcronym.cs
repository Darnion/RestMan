namespace RestMan.Context.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddHallAcronym : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Halls", "Acronym", c => c.String(nullable: false, maxLength: 255));
        }

        public override void Down()
        {
            DropColumn("dbo.Halls", "Acronym");
        }
    }
}
