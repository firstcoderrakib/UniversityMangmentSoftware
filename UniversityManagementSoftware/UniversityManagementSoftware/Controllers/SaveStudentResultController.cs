using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityManagementSoftware.Models;

namespace UniversityManagementSoftware.Controllers
{
    public class SaveStudentResultController : Controller
    {
        private UniversityContextDb db=new UniversityContextDb();
        //
        // GET: /SaveStudentResult/
        public ActionResult Create()
        {
            ViewBag.RegisterStudents = db.RegisterStudents.ToList();
            ViewBag.Courses = db.Courses.ToList();
            ViewBag.SelectGradLetter = new SelectList(new[] { "A+", "A", "A-", "B+", "B", "B-", "C+", "C", "D", "F" });
            
            return View();
        }

        [HttpPost]
        public ActionResult Create(SaveStudentResult model)
        {
            if (ModelState.IsValid)
            {
                db.SaveStudentResults.Add(model);
                db.SaveChanges();
            }

            return RedirectToAction("Create");
        }
        public ActionResult GetEnrollCourse(string registrationNo)
        {
            var registerStudent = db.RegisterStudents.Where(x => x.RegstrationNo == registrationNo).Select(x => new { value = x.Id, Text = x.StudentName, Email = x.StudentEmail, Department = x.DepartmentName }).ToList();

            return Json(registerStudent);
        }
	}
}