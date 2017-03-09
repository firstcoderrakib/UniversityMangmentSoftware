using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniversityManagementSoftware.Models
{
    public class RegisterStudent
    {
        public int Id { get; set; }

        [DisplayName("Name")]
        [Required(ErrorMessage = "Name Field is required")]
        [MaxLength(100)]
        public string StudentName { get; set; }

        [Required]
        [EmailAddress]
        public string  StudentEmail { get; set; }

        [DisplayName("Contact No.")]
        [Required(ErrorMessage = "Contact No. Field is required")]
        [MaxLength(20)]
        public string StudentContactNo { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Current Date")]
        public DateTime Date { get; set; }

        [DisplayName("Address")]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }

        public string DepartmentName { get; set; }

        [DisplayName("Registration")]
        public string RegstrationNo { get; set; }
    }
}