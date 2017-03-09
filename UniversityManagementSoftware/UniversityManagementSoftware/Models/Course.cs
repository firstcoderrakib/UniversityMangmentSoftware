using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace UniversityManagementSoftware.Models
{
    public class Course
    {
        public int Id { get; set; }

        [DisplayName("Code")]
        [Required(ErrorMessage = "Course Code Field is required")]
        public string CourseCode { get; set; }

        [DisplayName("Name")]
        [Required(ErrorMessage = "Course Name Field is required")]
        public string CourseName { get; set; }

        [DisplayName("Credit")]
        [Required(ErrorMessage = "Course Credit Field is required")]
        [Range(.5, 5, ErrorMessage = "Course Credit must be lies between 0.5  to 5.0")]
        public float Credit { get; set; }

        [DisplayName("Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        public string SemesterName { get; set; }
    }
}