using System;
using System.Collections.Generic;
using System.Text;

namespace ABCEnrollmentSystem
{
    internal interface IEnrollmentRepository
    {
        void add (EnrollmentRecord enrollmentRecord);
        List<EnrollmentRecord> GetAll();
    }
}
