using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityManagementSoftware.Models
{
    public class AllocateRoomViewModel
    {
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public string RoomId { get; set; }
        public string DateOfSaven { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
}