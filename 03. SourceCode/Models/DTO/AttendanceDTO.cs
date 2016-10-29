using System;

namespace Models.DTO
{
    public class AttendanceDTO
    {
        public long AttendanceId { get; set; }
        public long StudentId { get; set; }
        public long ClassId { get; set; }

        public DateTime AttendanceDate { get; set; }
        public long AttendanceTypeId { get; set; }

        public string ShortcutChar { get; set; }
        public string StudentName { get; set; }
    }
}
