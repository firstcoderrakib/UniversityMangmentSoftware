namespace UniversityManagementSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createCourseupdate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "SemesterID", "dbo.Semesters");
            DropIndex("dbo.Courses", new[] { "DepartmentID" });
            DropIndex("dbo.Courses", new[] { "SemesterID" });
            AddColumn("dbo.Courses", "SemesterName", c => c.String());
            CreateIndex("dbo.Courses", "DepartmentId");
            DropColumn("dbo.Courses", "SemesterID");
            DropTable("dbo.Semesters");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Semesters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SemesterName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Courses", "SemesterID", c => c.Int(nullable: false));
            DropIndex("dbo.Courses", new[] { "DepartmentId" });
            DropColumn("dbo.Courses", "SemesterName");
            CreateIndex("dbo.Courses", "SemesterID");
            CreateIndex("dbo.Courses", "DepartmentID");
            AddForeignKey("dbo.Courses", "SemesterID", "dbo.Semesters", "Id", cascadeDelete: true);
        }
    }
}
