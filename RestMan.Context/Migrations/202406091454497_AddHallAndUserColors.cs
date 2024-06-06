namespace RestMan.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHallAndUserColors : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Halls", "DisplayColor", c => c.Int());
            AddColumn("dbo.Users", "DisplayColor", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "DisplayColor");
            DropColumn("dbo.Halls", "DisplayColor");
        }
    }
}
