namespace UniversityManagementSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class allocateClassRoom_update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AllocateClassRooms", "DepartmentName", c => c.String(nullable: false));
            AddColumn("dbo.AllocateClassRooms", "StartTime", c => c.Time(nullable: false, precision: 7));
            AddColumn("dbo.AllocateClassRooms", "EndTime", c => c.Time(nullable: false, precision: 7));
            DropColumn("dbo.AllocateClassRooms", "DepartmentId");
            DropColumn("dbo.AllocateClassRooms", "Start");
            DropColumn("dbo.AllocateClassRooms", "End");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AllocateClassRooms", "End", c => c.String(nullable: false));
            AddColumn("dbo.AllocateClassRooms", "Start", c => c.String(nullable: false));
            AddColumn("dbo.AllocateClassRooms", "DepartmentId", c => c.Int(nullable: false));
            DropColumn("dbo.AllocateClassRooms", "EndTime");
            DropColumn("dbo.AllocateClassRooms", "StartTime");
            DropColumn("dbo.AllocateClassRooms", "DepartmentName");
        }
    }
}
