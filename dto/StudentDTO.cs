using System;
using System.Collections.Generic;

namespace efLazyLoading.dto
{
    public class StudentDTO
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public long EnrollmentCount { get; set; }
    }
}
