using System;

namespace Models.DTO
{
    public class AttendanceDTO
    {
        public long AttendanceId { get; set; }
        public long StudentId { get; set; }
        public string StudentCode { get; set; }

        public string PrefixName { get; set; }
        public string SuffixName { get; set; }
        public long ClassId { get; set; }

        public DateTime AttendanceDate { get; set; }
        public long AttendanceTypeId { get; set; }

        public string ShortcutKey { get; set; }
        public string StudentName { get; set; }
    }
}
