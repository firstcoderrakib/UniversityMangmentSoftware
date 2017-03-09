using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniversityManagementSoftware.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        [DisplayName("Name")]
        [Required(ErrorMessage = "Teacher Name Field is required")]
        [MaxLength(100)]
        public string TeacherName { get; set; }

        [DisplayName("Address")]
        [DataType(DataType.MultilineText)]
        public string TeacherAddress { get; set; }

        [Required]
        [EmailAddress]
        public string TeacherEmail { get; set; }

        [DisplayName("Contact No.")]
        [Required(ErrorMessage = "Contact No. Field is required")]
        [StringLength(20, ErrorMessage = "Contact No cannot be longer than 20 characters.")]
        public string TeacherContactNo { get; set; }

         [DisplayName("Designation")]
         [Required(ErrorMessage = "Designation can't empty")]
        public string TeacherDesignation { get; set; }


        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        [DisplayName("Credit")]
        [Required(ErrorMessage = "Course Credit Field is required")]
        [Range(1, 36, ErrorMessage = "Course Credit must be lies between 1  to 36")]
        public float CreditToBeTaken { get; set; }
      
    }
}