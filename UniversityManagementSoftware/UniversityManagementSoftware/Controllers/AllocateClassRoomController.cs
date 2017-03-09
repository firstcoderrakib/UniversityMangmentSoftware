using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityManagementSoftware.Models;

namespace UniversityManagementSoftware.Controllers
{
    
    public class AllocateClassRoomController : Controller
    {
        private UniversityContextDb db=new UniversityContextDb();
        //
        // GET: /AllocateClassRoom/

        public ActionResult AllocatRoom()
        {
            ViewBag.Deparment = db.Departments.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult AllocatRoom(int departmentid)
        {
            //var AllocateRoom1 = from c1 in db.CourseAssinToTeacher
            //                   join c2 in db.AllocateClassRoom on c1.CourseCode equals c2.CourseCode
            //                   where (c1.DepartmentId == departmentid) && (c2.DepartmentId == departmentid)
            //                   select new { c2.CourseCode, c1.CourseName, c2.RoomId, c2.DateOfSaven, c2.StartTime, c2.EndTime };

            //List<AllocateRoomViewModel> Allocatelist = new List<AllocateRoomViewModel>();
            //foreach (var item in AllocateRoom1)
            //                {
            //                    AllocateRoomViewModel Allocate = new AllocateRoomViewModel();
            //                    Allocate.CourseCode = item.CourseCode;
            //                    Allocate.CourseName = item.CourseName;
            //                    Allocate.RoomId = item.RoomId;
            //                    Allocate.DateOfSaven = item.DateOfSaven;
            //                    Allocate.StartTime = item.StartTime;
            //                    Allocate.EndTime = item.EndTime;
            //                    Allocatelist.Add(AllocatRoom);
            //                }
            return View();
        }
        public ActionResult Create()
        {
            var categoryDayList = new SelectList(new[] { "SaturDay", "SunDay", " MonDay", "TuesDay", "WesnesDay", "ThursDay", "FriDay" });
            ViewBag.categoryDayList = categoryDayList;
            var categoryRomList = new SelectList(new[] { "R-101", "R-102", " R-103", "R-104", "R-105", "R-106", "R-107" });
            ViewBag.categoryRomList = categoryRomList;
            ViewBag.Departments = db.Departments.ToList();
            ViewBag.Courses = db.Courses.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Create(AllocateClassRoom model)
        {
            if (ModelState.IsValid)
            {
                db.AllocateClassRooms.Add(model);
                db.SaveChanges();
            }
            return RedirectToAction("Create");
        }
	}
}