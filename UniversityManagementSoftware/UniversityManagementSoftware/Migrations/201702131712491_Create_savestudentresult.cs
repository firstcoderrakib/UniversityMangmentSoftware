namespace UniversityManagementSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_savestudentresult : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SaveStudentResults",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RegstrationNo = c.String(),
                        StudentName = c.String(),
                        StudentEmail = c.String(),
                        DepartmentName = c.String(),
                        CourseCode = c.String(),
                        GradeLatter = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SaveStudentResults");
        }
    }
}
