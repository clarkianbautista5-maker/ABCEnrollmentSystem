using System;
using System.Collections.Generic;
using System.Text;

namespace ABCEnrollmentSystem
{
    public class Teacher
    {
        public string TeacherId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return $"{LastName}, {FirstName} {MiddleName}".Trim();
            }
        }
    }
}
