using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Entity
{
    public class Attendance
    {
        public long AttendanceId { get; set; }
        public long StudentId { get; set; }
        public long ClassId { get; set; }
        public DateTime AttendanceDate { get; set; }
        public long AttendanceTypeId { get; set; }
    }
}
