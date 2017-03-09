using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityManagementSoftware.Models;

namespace UniversityManagementSoftware.Controllers
{
    public class CourseController : Controller
    {
        private UniversityContextDb db = new UniversityContextDb();

        public ActionResult Create()
        {
            List<SelectListItem> Semester = new List<SelectListItem>()
            {
             new SelectListItem() { Text = "First Semester", Value = "First Semester"},
             new SelectListItem() { Text = "Secend Semester", Value = "Secend Semester"},
             new SelectListItem() { Text = "Third Semester", Value = "Third Semester"},
             new SelectListItem() { Text = "Four Semester", Value = "Four Semester"},
             new SelectListItem() { Text = "Five Semester", Value = "Five Semester"},
             new SelectListItem() { Text = "Six Semester", Value = "Six Semester"},
               new SelectListItem() { Text = "Seven Semester", Value = "Seven Semester"},
             new SelectListItem() { Text = "Eight Semester", Value = "Eight Semester"},
             new SelectListItem() { Text = "Nine Semester", Value = "Nine Semester"},
             new SelectListItem() { Text = "Ten Semester", Value = "Ten Semester"},
             new SelectListItem() { Text = "Eleven Semester", Value = "Eleven Semester"},
             new SelectListItem() { Text = "Twelve Semester", Value = "Twelve Semester"}
            };
            ViewBag.Semester = Semester;
            ViewBag.Departments = db.Departments.ToList();
            
            return View();
        }

        [HttpPost]
        public ActionResult Create(Course model)
        {
            if(ModelState.IsValid)
            {
                db.Courses.Add(model);
                db.SaveChanges();
            }

            return RedirectToAction("Create");
        }

        //public List<SelectListItem> designation = new List<SelectListItem>()
        //{
        // new SelectListItem() { Text = "AstenProfser", Value = "1"},
        // new SelectListItem() { Text = "pros", Value = "2"}
        //};

        //public ActionResult Edit(int? id)
        //{
        //    Course course = db.Courses.Find(id);
        //    if (course == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentID", "DepartmentName", course.DepartmentID);
        //    ViewBag.SemesterID = new SelectList(db.Semesters, "SemesterID", "SemesterName", course.SemesterID);
        //    return View(course);
        //}
        //[HttpPost]
        //public ActionResult Edit(Course course)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(course).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //   
        //    return View(course);
        //}
    }
}