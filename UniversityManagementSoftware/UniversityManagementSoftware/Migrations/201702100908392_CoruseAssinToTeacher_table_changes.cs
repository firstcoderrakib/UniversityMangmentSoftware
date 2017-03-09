namespace UniversityManagementSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CoruseAssinToTeacher_table_changes : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CourseAssinToTeachers", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.CourseAssinToTeachers", "Department_Id", "dbo.Departments");
            DropForeignKey("dbo.CourseAssinToTeachers", "Teacher_Id", "dbo.Teachers");
            DropIndex("dbo.CourseAssinToTeachers", new[] { "Course_Id" });
            DropIndex("dbo.CourseAssinToTeachers", new[] { "Department_Id" });
            DropIndex("dbo.CourseAssinToTeachers", new[] { "Teacher_Id" });
            AddColumn("dbo.CourseAssinToTeachers", "TeacherName", c => c.String());
            AddColumn("dbo.CourseAssinToTeachers", "CourseCode", c => c.String());
            AlterColumn("dbo.CourseAssinToTeachers", "DepartmentId", c => c.Int(nullable: false));
            DropColumn("dbo.CourseAssinToTeachers", "TeacherId");
            DropColumn("dbo.CourseAssinToTeachers", "CourseCodeId");
            DropColumn("dbo.CourseAssinToTeachers", "Course_Id");
            DropColumn("dbo.CourseAssinToTeachers", "Department_Id");
            DropColumn("dbo.CourseAssinToTeachers", "Teacher_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CourseAssinToTeachers", "Teacher_Id", c => c.Int());
            AddColumn("dbo.CourseAssinToTeachers", "Department_Id", c => c.Int());
            AddColumn("dbo.CourseAssinToTeachers", "Course_Id", c => c.Int());
            AddColumn("dbo.CourseAssinToTeachers", "CourseCodeId", c => c.String());
            AddColumn("dbo.CourseAssinToTeachers", "TeacherId", c => c.String());
            AlterColumn("dbo.CourseAssinToTeachers", "DepartmentId", c => c.String());
            DropColumn("dbo.CourseAssinToTeachers", "CourseCode");
            DropColumn("dbo.CourseAssinToTeachers", "TeacherName");
            CreateIndex("dbo.CourseAssinToTeachers", "Teacher_Id");
            CreateIndex("dbo.CourseAssinToTeachers", "Department_Id");
            CreateIndex("dbo.CourseAssinToTeachers", "Course_Id");
            AddForeignKey("dbo.CourseAssinToTeachers", "Teacher_Id", "dbo.Teachers", "Id");
            AddForeignKey("dbo.CourseAssinToTeachers", "Department_Id", "dbo.Departments", "Id");
            AddForeignKey("dbo.CourseAssinToTeachers", "Course_Id", "dbo.Courses", "Id");
        }
    }
}
