using System;

namespace Models.Entity
{
    public class Enrollment
    {
        public long EnrollmentId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


        public long StudentId { get; set; }
        public long ClassId { get; set; }
    }
}
