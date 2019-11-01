namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakingDateTimeNull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "ExtraPickupDay", c => c.DateTime());
            AlterColumn("dbo.Customers", "Start", c => c.DateTime());
            AlterColumn("dbo.Customers", "End", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "End", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Customers", "Start", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Customers", "ExtraPickupDay", c => c.DateTime(nullable: false));
        }
    }
}
