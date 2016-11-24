using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.DTO
{
    public class StudentDTO
    {
        public long StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string StudentName { get; set; }
        public string StudentCode { get; set; }

        public DateTime? Birthday { get; set; }
        public string PhoneNumber { get; set; }
        public string CurrentWorkplace { get; set; }

        public string Facebook { get; set; }
        public string Email { get; set; }
    }
}
