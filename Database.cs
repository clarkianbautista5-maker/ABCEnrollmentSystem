using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;

namespace ABCEnrollmentSystem
{
    internal static class Database
    {
        public const string ConnectionString = "Server=DESKTOP-7LPU3PN\\SQLEXPRESS;Database=ABCEnrollmentDb;Trusted_Connection=True;TrustServerCertificate=True;";

        public static DataTable GetTable(string sql, string keyword)
        {
            DataTable table = new DataTable();

            using (SqlConnection conn = new SqlConnection(ConnectionString)) 
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                if(keyword != null)
                {
                    cmd.Parameters.AddWithValue("@k", keyword);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
            }
            return table;
        }
        
        public static int Execute(string sql, Dictionary<string, object> values)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    foreach (KeyValuePair<string, object> pair in values)
                    {
                        cmd.Parameters.AddWithValue(pair.Key, pair.Value);
                    }
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }

            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601) //if the record is not unique
                {
                    throw new DuplicateRecordException("That record already exists.");
                }
                else if (ex.Number == 547)
                {
                    throw new InvalidOperationException("This record is linked to other records");
                }
                else
                {
                    throw;
                }
            }

        }
    }
}
