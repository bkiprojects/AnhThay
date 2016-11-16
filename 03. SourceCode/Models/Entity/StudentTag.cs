using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Entity
{
    public class StudentTag
    {

        public long StudentId { get; set; }
        public int? TagId { get; set; }
        public int ClassId { get; set; }

        public DateTime? TagDate { get; set; }
        public string Notes { get; set; }

        public string FeeNotes { get; set; }

        public string StudyNotes { get; set; }
    }
}
