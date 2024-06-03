namespace RestMan.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHallAcronym1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Halls", "Acronym", c => c.String(nullable: false, maxLength: 8));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Halls", "Acronym", c => c.String(nullable: false, maxLength: 255));
        }
    }
}
