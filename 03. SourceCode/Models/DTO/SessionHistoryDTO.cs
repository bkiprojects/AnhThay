using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.DTO
{
    public class SessionHistoryDTO
    {
        public long ClassId { get; set; }
        public string ClassCode { get; set; }
        public string ClassDescription { get; set; }

        public int CurrentSession { get; set; }
    }
}
