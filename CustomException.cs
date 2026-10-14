using System;
using System.Collections.Generic;
using System.Text;

namespace ABCEnrollmentSystem
{
    public class DuplicateRecordException : Exception
    {
        public DuplicateRecordException(string message) : base(message)
        {
        }
    }
    public class  RecordNotFoundException : Exception
    {
        public RecordNotFoundException(string message) : base(message)
        {
        }
    }
}
