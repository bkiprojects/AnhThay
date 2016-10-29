using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Entity
{
    public class AttendanceType
    {
        public int AttendanceTypeId { get; set; }
        public string AttendanceTypeName { get; set; }
        public string ShortcutChar { get; set; }
    }
}
