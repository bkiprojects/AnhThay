using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.DTO
{
    public class StudentDTO
    {
        public long StudentId { get; set; }
        public string PrefixName { get; set; }
        public string SuffixName { get; set; }

        public string StudentName { get; set; }
        public string StudentCode { get; set; }

        public DateTime BirthDay { get; set; }
    }
}
