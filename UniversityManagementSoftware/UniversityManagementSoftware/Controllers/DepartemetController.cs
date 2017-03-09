using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using UniversityManagementSoftware.Models;

namespace UniversityManagementSoftware.Controllers
{
    public class DepartemetController : Controller
    {
        private UniversityContextDb db = new UniversityContextDb();

        #region validation

        public ActionResult Code(string DepartmentCode)
        {
                        
                var departmentName = db.Departments.ToList().FirstOrDefault(m => m.DepartmentCode == DepartmentCode);
                if(departmentName != null)
                {
                    return Json(false, JsonRequestBehavior.AllowGet);
                }
                return Json(true, JsonRequestBehavior.AllowGet);
          
        }


        public ActionResult Name(string DepartmentName)
        {
            var departmentName = db.Departments.ToList().FirstOrDefault(x => x.DepartmentName == DepartmentName);

            if (departmentName != null)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            return Json(true, JsonRequestBehavior.AllowGet);
        }

        #endregion
        public ActionResult Deparment()
        {
            List<Department> department = db.Departments.ToList();

            return View("DepartmentIndex", department);
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Department model)
        {
            if (ModelState.IsValid)
            {
                db.Departments.Add(model);
                db.SaveChanges();
                return RedirectToAction("Create");
            }
            return RedirectToAction("Create");
        }
    }
}