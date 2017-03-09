namespace UniversityManagementSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_CourseAssintoTeacher : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CourseAssinToTeachers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartmentId = c.String(),
                        TeacherId = c.String(),
                        CreditToTaken = c.Single(nullable: false),
                        RemainCredit = c.Single(nullable: false),
                        CourseCodeId = c.String(),
                        CourseName = c.String(),
                        CourseCredit = c.String(),
                        Course_Id = c.Int(),
                        Department_Id = c.Int(),
                        Teacher_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.Course_Id)
                .ForeignKey("dbo.Departments", t => t.Department_Id)
                .ForeignKey("dbo.Teachers", t => t.Teacher_Id)
                .Index(t => t.Course_Id)
                .Index(t => t.Department_Id)
                .Index(t => t.Teacher_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CourseAssinToTeachers", "Teacher_Id", "dbo.Teachers");
            DropForeignKey("dbo.CourseAssinToTeachers", "Department_Id", "dbo.Departments");
            DropForeignKey("dbo.CourseAssinToTeachers", "Course_Id", "dbo.Courses");
            DropIndex("dbo.CourseAssinToTeachers", new[] { "Teacher_Id" });
            DropIndex("dbo.CourseAssinToTeachers", new[] { "Department_Id" });
            DropIndex("dbo.CourseAssinToTeachers", new[] { "Course_Id" });
            DropTable("dbo.CourseAssinToTeachers");
        }
    }
}
