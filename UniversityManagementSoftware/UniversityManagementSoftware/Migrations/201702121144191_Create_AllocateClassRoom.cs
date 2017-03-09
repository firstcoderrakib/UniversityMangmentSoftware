namespace UniversityManagementSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_AllocateClassRoom : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AllocateClassRooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartmentID = c.Int(nullable: false),
                        CourseCode = c.String(nullable: false),
                        RoomId = c.Int(nullable: false),
                        DateOfSaven = c.String(nullable: false),
                        Start = c.String(nullable: false),
                        End = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AllocateClassRooms");
        }
    }
}
