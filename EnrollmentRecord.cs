using System;
using System.Collections.Generic;
using System.Text;

namespace ABCEnrollmentSystem
{
    internal class EnrollmentRecord
    {
        public int EnrollmentID { get; set; }
        public string StudentID { get; set; }
        public string SectionCode { get; set; }
        public string SubjectCode { get; set; }
        public string SchoolYear { get; set; }
    }
}
