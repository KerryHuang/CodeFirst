namespace CodeFirstModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        CompanyId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        DetailedInfo_CompanyId = c.Int(),
                    })
                .PrimaryKey(t => t.CompanyId)
                .ForeignKey("dbo.DetailedInfoes", t => t.DetailedInfo_CompanyId)
                .Index(t => t.DetailedInfo_CompanyId);
            
            CreateTable(
                "dbo.DetailedInfoes",
                c => new
                    {
                        CompanyId = c.Int(nullable: false),
                        Address = c.String(),
                        DateFounded = c.DateTime(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CompanyId);
            
            CreateTable(
                "Company.Employee",
                c => new
                    {
                        PersonId = c.Int(nullable: false),
                        FirstName = c.String(maxLength: 8),
                        LastName = c.String(maxLength: 8),
                        Company_CompanyId = c.Int(),
                    })
                .PrimaryKey(t => t.PersonId)
                .ForeignKey("dbo.Companies", t => t.Company_CompanyId)
                .Index(t => t.Company_CompanyId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Vendors",
                c => new
                    {
                        VendorId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.VendorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Company.Employee", "Company_CompanyId", "dbo.Companies");
            DropForeignKey("dbo.Companies", "DetailedInfo_CompanyId", "dbo.DetailedInfoes");
            DropIndex("Company.Employee", new[] { "Company_CompanyId" });
            DropIndex("dbo.Companies", new[] { "DetailedInfo_CompanyId" });
            DropTable("dbo.Vendors");
            DropTable("dbo.Employees");
            DropTable("Company.Employee");
            DropTable("dbo.DetailedInfoes");
            DropTable("dbo.Companies");
        }
    }
}
