namespace UniversityManagementSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RegisterStudent_Update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RegisterStudents", "DepartmentName", c => c.String());
            AlterColumn("dbo.RegisterStudents", "Date", c => c.DateTime(nullable: false));
            DropColumn("dbo.RegisterStudents", "DepartmentId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RegisterStudents", "DepartmentId", c => c.Int(nullable: false));
            AlterColumn("dbo.RegisterStudents", "Date", c => c.String(nullable: false));
            DropColumn("dbo.RegisterStudents", "DepartmentName");
        }
    }
}
