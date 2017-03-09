using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityManagementSoftware.Models;

namespace UniversityManagementSoftware.Controllers
{
    public class TeacherController : Controller
    {
        private UniversityContextDb db = new UniversityContextDb();




        public ActionResult Create()
        {
            List<SelectListItem> Designation = new List<SelectListItem>()
            {
             new SelectListItem() { Text = "Professor", Value = "Professor"},
             new SelectListItem() { Text = "Associate professor", Value = "Associate Professor"},
             new SelectListItem() { Text = "Assistant professor", Value = "Assistant Professor"},
             new SelectListItem() { Text = "Senior Lecturer", Value = "Senior Professor"},
             new SelectListItem() { Text = "Lecturer", Value = "Lecturer"},
             new SelectListItem() { Text = "Assistant Lecturer", Value = "Assistant Lecturer"}
            };
            ViewBag.Designation = Designation;
            ViewBag.Departments = db.Departments.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Create(Teacher model)
        {
            
            if (ModelState.IsValid)
            {
                db.Teachers.Add(model);
                db.SaveChanges();
            }
                   
            return RedirectToAction("Create");
        }

       
    }
}