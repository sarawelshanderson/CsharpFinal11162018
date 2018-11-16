namespace InspectionApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class somename : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locations", "LocationCity", c => c.String());
            AddColumn("dbo.Locations", "LocationState", c => c.String());
            AddColumn("dbo.Locations", "LocationZip", c => c.String());
            AddColumn("dbo.Locations", "LocationType", c => c.String());
            AddColumn("dbo.Locations", "LocationInspectionDate", c => c.String());
            AddColumn("dbo.Locations", "LocationGrade", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Locations", "LocationGrade");
            DropColumn("dbo.Locations", "LocationInspectionDate");
            DropColumn("dbo.Locations", "LocationType");
            DropColumn("dbo.Locations", "LocationZip");
            DropColumn("dbo.Locations", "LocationState");
            DropColumn("dbo.Locations", "LocationCity");
        }
    }
}
