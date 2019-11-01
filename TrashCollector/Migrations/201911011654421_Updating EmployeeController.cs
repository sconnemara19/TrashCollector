namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatingEmployeeController : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "ApplicationId", c => c.String(maxLength: 128));
            AlterColumn("dbo.Employees", "employeeZipcode", c => c.String());
            CreateIndex("dbo.Employees", "ApplicationId");
            AddForeignKey("dbo.Employees", "ApplicationId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "ApplicationId", "dbo.AspNetUsers");
            DropIndex("dbo.Employees", new[] { "ApplicationId" });
            AlterColumn("dbo.Employees", "employeeZipcode", c => c.Int(nullable: false));
            DropColumn("dbo.Employees", "ApplicationId");
        }
    }
}
