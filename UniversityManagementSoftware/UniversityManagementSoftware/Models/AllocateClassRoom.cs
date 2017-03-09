using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniversityManagementSoftware.Models
{
    public class AllocateClassRoom
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Department can't be empty")]
        public string DepartmentId{ get; set; }
       

        [Required(ErrorMessage = "Course Name can't be empty")]
        public string CourseCode { get; set; }

        [Required(ErrorMessage = "Room can't be empty")]
        public string RoomId { get; set; }

        [Required(ErrorMessage = "Day can't be empty")]
        public string DateOfSaven { get; set; }

        [Required(ErrorMessage = "Start time is required")]
        [Display(Name = "From (Formate HH:MM) (24 Hours)")]
        public TimeSpan StartTime { get; set; }


        [Required(ErrorMessage = "End time is required")]
        [Display(Name = "To (Formate HH:MM) (24 Hours)")]
        public TimeSpan EndTime { get; set; }
    }
}