using System.Data;

namespace ABCEnrollmentSystem
{
    internal static class ReportRepository
    {
        private static string Year(string y)
        {
            return string.IsNullOrWhiteSpace(y) ? "%" : y.Trim();
        }

        // per section
        public static DataTable GetClassListPerSection(string schoolYear)
        {
            string sql = "SELECT DISTINCT sc.SectionName AS GroupName, s.LastName + ', ' + s.FirstName AS Item " +
                         "FROM Enrollments e " +
                         "JOIN Students s ON s.StudentId = e.StudentId " +
                         "JOIN Sections sc ON sc.SectionCode = e.SectionCode " +
                         "WHERE e.SchoolYear LIKE @k ORDER BY GroupName, Item";
            return Database.GetTable(sql, Year(schoolYear));
        }

        // per subject
        public static DataTable GetClassListPerSubject(string schoolYear)
        {
            string sql = "SELECT DISTINCT sb.SubjectName AS GroupName, s.LastName + ', ' + s.FirstName AS Item " +
                         "FROM Enrollments e " +
                         "JOIN Students s ON s.StudentId = e.StudentId " +
                         "JOIN Subjects sb ON sb.SubjectCode = e.SubjectCode " +
                         "WHERE e.SchoolYear LIKE @k ORDER BY GroupName, Item";
            return Database.GetTable(sql, Year(schoolYear));
        }

        // per teacher
        public static DataTable GetSubjectsPerTeacher()
        {
            string sql = "SELECT t.LastName + ', ' + t.FirstName AS GroupName, " +
                         "ISNULL(sb.SubjectName, '(none)') AS Item " +
                         "FROM Teachers t " +
                         "LEFT JOIN Subjects sb ON sb.TeacherId = t.TeacherId " +
                         "ORDER BY GroupName, Item";
            return Database.GetTable(sql, null);
        }
    }
}