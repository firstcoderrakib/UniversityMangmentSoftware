using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityManagementSoftware.Models;

namespace UniversityManagementSoftware.Controllers
{
    public class CourseAssinToTeacherController : Controller
    {
        private UniversityContextDb db = new UniversityContextDb();
        //
        // GET: /CourseAssinToTeacher/
        public ActionResult Course()
        {
            ViewBag.Deparment = db.Departments.ToList();
            return View();
        }

        public ActionResult Course(int departmentid)
        {           
            var courseStatic = from c1 in db.Courses
                               join ct in db.CourseAssinToTeachers on c1.CourseCode equals ct.CourseCode
                               where(c1.DepartmentId == departmentid) && (ct.DepartmentId == departmentid)
                               select new { c1.CourseCode, c1.CourseName, c1.SemesterName, ct.TeacherName };

            List<CourseStaticViewModel> coursesList = new List<CourseStaticViewModel>();
             foreach(var item in courseStatic)
                {
                CourseStaticViewModel course = new CourseStaticViewModel();
                course.CoruseCode = item.CourseCode;
                course.CourseName = item.CourseName;
                course.Semester = item.SemesterName;
                course.TeacherName = item.TeacherName;
                coursesList.Add(course);
                }

            return View(coursesList);
        }


        public ActionResult Create()
        {
            ViewBag.Departments = db.Departments.ToList();
            ViewBag.Teachers = db.Teachers.ToList();
            ViewBag.Courses = db.Courses.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Create(CourseAssinToTeacher model)
        {
            var courseCode = db.CourseAssinToTeachers.Where(x => x.CourseCode == model.CourseCode).FirstOrDefault();
            if(courseCode == null)
            {
                if (ModelState.IsValid)
                {
                    db.CourseAssinToTeachers.Add(model);
                    db.SaveChanges();
                }
                return RedirectToAction("Create");
            }

            TempData["course"] = "This Course" + " "+  model.CourseName + " "+ "Assinded";
            return RedirectToAction("Create");
        }

        [HttpPost]
        public ActionResult GetTeachers(int deparmentId)
        {
            var teachers = db.Teachers.Where(x => x.DepartmentId == deparmentId).Select(x => new { value = x.Id, Text = x.TeacherName, credit = x.CreditToBeTaken }).ToList();

            return Json(teachers);
        }

        [HttpPost]
        public ActionResult GetCourse(int deparmentId)
        {
            var listCorese = db.Courses.Where(x => x.Id == deparmentId).Select(x => new { x.Id, x.CourseCode, x.CourseName, x.Credit }).ToList();

            return Json(listCorese);
        }
    }
}