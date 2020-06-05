namespace TaskProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangingPropertiesInPeopleClass : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "MobileNumber", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "MobileNumber", c => c.String(nullable: false));
        }
    }
}
