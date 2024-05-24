namespace RestMan.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ActiveUsersCheck : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "IsOnShift", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "IsOnShift");
        }
    }
}
