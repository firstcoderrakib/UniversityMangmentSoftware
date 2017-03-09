using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityManagementSoftware.Models;

namespace UniversityManagementSoftware.Controllers
{
    public class EnrollCourseController : Controller
    {
        private UniversityContextDb db=new UniversityContextDb();
        //
        // GET: /EnrollCourse/
        public ActionResult Create()
        {
            ViewBag.RegisterStudents = db.RegisterStudents.ToList();
            ViewBag.Courses = db.Courses.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Create(EnrollCourse model)
        {
            if (ModelState.IsValid)
            {
                db.EnrollCourses.Add(model);
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