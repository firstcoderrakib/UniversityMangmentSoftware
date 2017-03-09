using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using System.Security.AccessControl;

namespace UniversityManagementSoftware.Models
{
    public class UniversityContextDb : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<CourseAssinToTeacher> CourseAssinToTeachers { get; set; }
        public DbSet<RegisterStudent> RegisterStudents  { get; set; }
        public DbSet<AllocateClassRoom> AllocateClassRooms { get; set; }
        public DbSet<EnrollCourse> EnrollCourses { get; set; }
        public DbSet<SaveStudentResult> SaveStudentResults { get; set; }
    }
}