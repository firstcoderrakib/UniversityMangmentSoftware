using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UniversityManagementSoftware.Models
{
    public class Department
    {
        public int Id { get; set; }


        [DisplayName("Code")]
        [Required]
        [Remote(action: "Code", controller: "Departemet", ErrorMessage = "Code Already Exist.")]
        public string DepartmentCode { get; set; }


        [DisplayName("Name")]
        [Required]
        [Remote(action: "Name", controller: "Departemet", ErrorMessage = "Name Already Exist.")]
        public string DepartmentName { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
        
    }
}