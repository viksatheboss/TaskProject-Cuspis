namespace TaskProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "LastName", c => c.String());
            DropColumn("dbo.People", "SecondName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "SecondName", c => c.String());
            DropColumn("dbo.People", "LastName");
        }
    }
}
