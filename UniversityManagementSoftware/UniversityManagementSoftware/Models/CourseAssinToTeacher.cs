using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityManagementSoftware.Models
{
    public class CourseAssinToTeacher
    {
        public int  Id { get; set; }

        public int DepartmentId { get; set; }

        public string TeacherName { get; set; }

        public float CreditToTaken { get; set; }
        public float RemainCredit { get; set; }

        public string CourseCode { get; set; }

        public string CourseName { get; set; }
        public string CourseCredit { get; set; }
    }
}