namespace UniversityManagementSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createAllocateclassroom : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AllocateClassRooms", "DepartmentId", c => c.String(nullable: false));
            DropColumn("dbo.AllocateClassRooms", "DepartmentName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AllocateClassRooms", "DepartmentName", c => c.String(nullable: false));
            DropColumn("dbo.AllocateClassRooms", "DepartmentId");
        }
    }
}
