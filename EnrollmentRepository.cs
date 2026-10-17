using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace ABCEnrollmentSystem
{
    internal class EnrollmentRepository : IEnrollmentRepository
    {
        public void add(EnrollmentRecord e)
        {
            string sql = "INSERT INTO EnrollmentRecords (StudentID, SubjectCode, SectionCode, SchoolYear) " +
                         "VALUES (@StudentID, @SubjectCode, @SectionCode, @SchoolYear)";

            Dictionary<string, object> values = new Dictionary<string, object>();
            values["@StudentID"] = e.StudentID;
            values["@SubjectCode"] = e.SubjectCode;
            values["@SectionCode"] = e.SectionCode;
            values["@SchoolYear"] = e.SchoolYear;

            foreach (EnrollmentRecord existing in GetAll())
            {
                if (existing.StudentID == e.StudentID && existing.SubjectCode == e.SubjectCode && existing.SectionCode == e.SectionCode && existing.SchoolYear == e.SchoolYear)
                {
                    throw new DuplicateRecordException("Enrollment record already exists.");
                }
            }

            Database.Execute(sql, values);
        }

        public List<EnrollmentRecord> GetAll()
        {
           
            DataTable table = Database.GetTable("SELECT * FROM EnrollmentRecords ORDER BY EnrollmentID", null);
            List<EnrollmentRecord> list = new List<EnrollmentRecord>();
            
            foreach (DataRow row in table.Rows)
            {
                EnrollmentRecord record = new EnrollmentRecord
                {
                    EnrollmentID = Convert.ToInt32(row["EnrollmentID"]),
                    StudentID = row["StudentID"].ToString(),
                    SubjectCode = row["SubjectCode"].ToString(),
                    SectionCode = row["SectionCode"].ToString(),
                    SchoolYear = row["SchoolYear"].ToString()
                };
                list.Add(record);
            }
            return list;
        }
    }
}
