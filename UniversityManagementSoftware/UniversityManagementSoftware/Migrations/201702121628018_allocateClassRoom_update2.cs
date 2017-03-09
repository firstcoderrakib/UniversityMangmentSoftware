namespace UniversityManagementSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class allocateClassRoom_update2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AllocateClassRooms", "RoomId", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AllocateClassRooms", "RoomId", c => c.Int(nullable: false));
        }
    }
}
