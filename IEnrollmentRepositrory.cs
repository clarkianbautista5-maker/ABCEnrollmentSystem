using System;
using System.Collections.Generic;
using System.Text;

namespace ABCEnrollmentSystem
{
    internal interface IEnrollmentRepositrory
    {
        void add (EnrollmentRecord enrollmentRecord);
        List<EnrollmentRecord> GetAll();
    }
}
