namespace TaskProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        ContactNumber = c.String(),
                        Address_HomeNumber = c.Int(nullable: false),
                        Address_StreetName = c.String(),
                        Address_Town = c.String(),
                        Address_State = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        SecondName = c.String(),
                        MobileNumber = c.String(),
                        Address_HomeNumber = c.Int(nullable: false),
                        Address_StreetName = c.String(),
                        Address_Town = c.String(),
                        Address_State = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
            DropTable("dbo.Companies");
        }
    }
}
