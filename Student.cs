using System;
using System.Collections.Generic;
using System.Text;

namespace ABCEnrollmentSystem
{
    internal class Student
    {
        public string StudentID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public string HouseNo { get; set; }
        public string Street { get; set; }
        public string Municipality { get; set; }
        public string Province { get; set; }
        public string ZipCode { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }

        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Landline { get; set; }

       public string GuardianName { get; set; }
        public string GuardianMobile { get; set; }
        public string GuardianAddress { get; set; }
        public string GuardianLandline { get; set; }

        public string FullName
        {
            get
            {
                return $"{LastName}, {FirstName} {MiddleName}".Trim();
            }
        }

    }
}
