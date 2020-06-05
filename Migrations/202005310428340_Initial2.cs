namespace TaskProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Companies", "CompanyName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Companies", "ContactNumber", c => c.String(nullable: false));
            AlterColumn("dbo.People", "FirstName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.People", "LastName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.People", "MobileNumber", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "MobileNumber", c => c.String());
            AlterColumn("dbo.People", "LastName", c => c.String());
            AlterColumn("dbo.People", "FirstName", c => c.String());
            AlterColumn("dbo.Companies", "ContactNumber", c => c.String());
            AlterColumn("dbo.Companies", "CompanyName", c => c.String());
        }
    }
}
