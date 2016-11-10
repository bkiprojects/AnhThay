using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Entity
{
    public class AttendanceType
    {
        public int AttendanceTypeId { get; set; }
        public string AttendanceShortName { get; set; }
        public string AttendanceLongName { get; set; }
        public string ShortcutKey { get; set; }
        public string Notes { get; set; }
    }
}
