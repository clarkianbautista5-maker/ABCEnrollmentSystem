using System;
using System.Collections.Generic;
using System.Data;

namespace ABCEnrollmentSystem
{
    internal static class LogRepository
    {
        // User log: Login / Logout
        public static void AddUserLog(string action)
        {
            Save("INSERT INTO UserLogs (Username, Action) VALUES (@Username, @Action)",
                 new Dictionary<string, object>
                 {
                     ["@Username"] = Session.CurrentUser,
                     ["@Action"] = action
                 });
        }

        // Activity log: Add / Update / Delete
        public static void AddActivityLog(string action, string module, string details)
        {
            Save("INSERT INTO ActivityLogs (Username, Action, Module, Details) " +
                 "VALUES (@Username, @Action, @Module, @Details)",
                 new Dictionary<string, object>
                 {
                     ["@Username"] = Session.CurrentUser,
                     ["@Action"] = action,
                     ["@Module"] = (object)module ?? DBNull.Value,
                     ["@Details"] = (object)details ?? DBNull.Value
                 });
        }

        public static DataTable GetUserLogs(string keyword)
        {
            string sql = "SELECT LogDate, Username, Action FROM UserLogs ";
            if (string.IsNullOrWhiteSpace(keyword))
                return Database.GetTable(sql + "ORDER BY LogDate DESC", null);

            return Database.GetTable(sql + "WHERE Username LIKE @k OR Action LIKE @k ORDER BY LogDate DESC",
                                     "%" + keyword.Trim() + "%");
        }

        public static DataTable GetActivityLogs(string keyword)
        {
            string sql = "SELECT LogDate, Username, Action, Module, Details FROM ActivityLogs ";
            if (string.IsNullOrWhiteSpace(keyword))
                return Database.GetTable(sql + "ORDER BY LogDate DESC", null);

            return Database.GetTable(sql + "WHERE Username LIKE @k OR Action LIKE @k OR Module LIKE @k OR Details LIKE @k ORDER BY LogDate DESC",
                                     "%" + keyword.Trim() + "%");
        }

        private static void Save(string sql, Dictionary<string, object> values)
        {
            try { Database.Execute(sql, values); }
            catch { /* logging must never crash the app */ }
        }
    }
}