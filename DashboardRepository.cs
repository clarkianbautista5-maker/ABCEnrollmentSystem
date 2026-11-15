using System;
using System.Collections.Generic;
using System.Data;

namespace ABCEnrollmentSystem
{
    // Dashboard queries. Read-only.
    internal static class DashboardRepository
    {
        // KPI cards: "Students", "Subjects", "Teachers", or "Sections"
        public static int CountOf(string table)
        {
            string[] allowed = { "Students", "Subjects", "Teachers", "Sections" };
            if (Array.IndexOf(allowed, table) < 0)
                throw new ArgumentException("Invalid table name.");

            DataTable t = Database.GetTable("SELECT COUNT(*) AS Total FROM " + table, null);
            return Convert.ToInt32(t.Rows[0]["Total"]);
        }

        // Pie chart: Gender, Total
        public static DataTable GetGenderCounts()
        {
            return Database.GetTable(
                "SELECT ISNULL(NULLIF(Gender, ''), 'Not set') AS Gender, COUNT(*) AS Total " +
                "FROM Students " +
                "GROUP BY ISNULL(NULLIF(Gender, ''), 'Not set')", null);
        }

        // Bar chart: SubjectName, Total
        public static DataTable GetEnrollmentsPerSubject()
        {
            return Database.GetTable(
                "SELECT s.SubjectName, COUNT(e.EnrollmentId) AS Total " +
                "FROM Subjects s " +
                "LEFT JOIN Enrollments e ON e.SubjectCode = s.SubjectCode " +
                "GROUP BY s.SubjectName " +
                "ORDER BY Total DESC", null);
        }

        // Line chart: Day, Total (laging 7 days, 0 kung walang activity)
        public static DataTable GetActivityLast7Days()
        {
            return Database.GetTable(
                "SELECT d.Day, COUNT(a.LogId) AS Total " +
                "FROM (SELECT CAST(DATEADD(DAY, -v.n, GETDATE()) AS DATE) AS Day " +
                "      FROM (VALUES (0),(1),(2),(3),(4),(5),(6)) v(n)) d " +
                "LEFT JOIN ActivityLogs a ON CAST(a.LogDate AS DATE) = d.Day " +
                "GROUP BY d.Day " +
                "ORDER BY d.Day", null);
        }

        // Recent Activity list: last 8 actions
        public static DataTable GetRecentActivity()
        {
            return Database.GetTable(
                "SELECT TOP 8 LogDate, Username, Action, Module, Details " +
                "FROM ActivityLogs ORDER BY LogDate DESC", null);
        }
    }
}