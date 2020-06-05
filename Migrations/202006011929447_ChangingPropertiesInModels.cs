namespace TaskProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangingPropertiesInModels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "Address", c => c.String());
            AddColumn("dbo.People", "Address", c => c.String());
            DropColumn("dbo.Companies", "Address_HomeNumber");
            DropColumn("dbo.Companies", "Address_StreetName");
            DropColumn("dbo.Companies", "Address_Town");
            DropColumn("dbo.Companies", "Address_State");
            DropColumn("dbo.People", "Address_HomeNumber");
            DropColumn("dbo.People", "Address_StreetName");
            DropColumn("dbo.People", "Address_Town");
            DropColumn("dbo.People", "Address_State");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "Address_State", c => c.String());
            AddColumn("dbo.People", "Address_Town", c => c.String());
            AddColumn("dbo.People", "Address_StreetName", c => c.String());
            AddColumn("dbo.People", "Address_HomeNumber", c => c.Int(nullable: false));
            AddColumn("dbo.Companies", "Address_State", c => c.String());
            AddColumn("dbo.Companies", "Address_Town", c => c.String());
            AddColumn("dbo.Companies", "Address_StreetName", c => c.String());
            AddColumn("dbo.Companies", "Address_HomeNumber", c => c.Int(nullable: false));
            DropColumn("dbo.People", "Address");
            DropColumn("dbo.Companies", "Address");
        }
    }
}
