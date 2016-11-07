using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.DTO
{
    public class StudentTagDTO
    {
        public long StudentId { get; set; }
        public string StudentCode { get; set; }
        public string PrefixName { get; set; }

        public string SuffixName { get; set; }
        public string StudentName { get; set; }


        public int TagId { get; set; }
        public string TagName { get; set; }

        public DateTime TagDate { get; set; }
        public string Notes { get; set; }
    }
}
