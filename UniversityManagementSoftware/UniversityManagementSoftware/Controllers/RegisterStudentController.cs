using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityManagementSoftware.Models;

namespace UniversityManagementSoftware.Controllers
{
    public class RegisterStudentController : Controller
    {
        private UniversityContextDb db = new UniversityContextDb();
        //
        // GET: /RegisterStudent/
        public ActionResult Create()
        {
            ViewBag.Departments = db.Departments.ToList();
            return View();
        }

        public ActionResult Index(RegisterStudent model)
        {
                      
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(RegisterStudent model)
        {
            if (ModelState.IsValid)
            {
                Department department = db.Departments.Where(x => x.DepartmentName == model.DepartmentName).FirstOrDefault();
                var deparmentName = department.DepartmentCode;
                var year = model.Date.Year;

                model.RegstrationNo = model.DepartmentName + "-" + year + "-" + deparmentName;
                db.RegisterStudents.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index", model);
            }

            return View();
        }
        
        
	}
}