namespace UniversityManagementSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_RegisterStudent : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RegisterStudents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentName = c.String(nullable: false, maxLength: 100),
                        StudentEmail = c.String(nullable: false),
                        StudentContactNo = c.String(nullable: false, maxLength: 20),
                        Date = c.String(nullable: false),
                        Address = c.String(),
                        DepartmentId = c.Int(nullable: false),
                        RegstrationNo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RegisterStudents");
        }
    }
}
