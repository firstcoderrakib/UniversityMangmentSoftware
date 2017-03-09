using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityManagementSoftware.Models
{
    public class CourseAssignToTeacher
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public string TeacherName { get; set; }
        public float CreditToTaken { get; set; }
        public float RemainingCredit { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public float Credit { get; set; }
    }
}