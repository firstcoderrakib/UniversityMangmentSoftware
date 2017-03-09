using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniversityManagementSoftware.Models
{
    public class SaveStudentResult
    {
        public int Id { get; set; }
        public string RegstrationNo { get; set; }
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }
        public string DepartmentName { get; set; }
        public string CourseCode { get; set; }
        public string GradeLatter { get; set; }
    }
}