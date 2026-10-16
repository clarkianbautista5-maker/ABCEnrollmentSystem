using System;
using System.Collections.Generic;
using System.Text;

namespace ABCEnrollmentSystem
{
    internal class TeacherRepository : IRepository<Teacher>
    {
        public List<Teacher> GetAll() //1
        {
            return ToList(Database.GetTable("SELECT * FROM Teachers ORDER BY LastName, FirstName", null));
        }

        public Teacher GetByID(string id) //2
        {
            List<Teacher> list = ToList(Database.GetTable("SELECT * FROM Teachers WHERE TeacherId=@k", id));
            if (list.Count == 0)
            {
                return null;
            }
            return list[0];
        }

        public List<Teacher> Search(string keyword) //3
        {
            string sql =
                "SELECT * FROM Teachers WHERE " +
                "TeacherId LIKE @k OR FirstName LIKE @k OR MiddleName LIKE @k OR LastName LIKE @k " +
                "OR (FirstName + ' ' + LastName) LIKE @k " +
                "OR (FirstName + ' ' + MiddleName + ' ' + LastName) LIKE @k " +
                "OR (LastName + ', ' + FirstName) LIKE @k " +
                "ORDER BY LastName, FirstName";
            return ToList(Database.GetTable(sql, "%" + keyword + "%"));
        }

        public void Add(Teacher t)
        {
            string sql =
                "INSERT INTO Teachers (TeacherId, FirstName, MiddleName, LastName) " +
                "VALUES (@TeacherId, @FirstName, @MiddleName, @LastName)";
            if (GetByID(t.TeacherId) != null)
            {
                throw new DuplicateRecordException($"Teacher ID {t.TeacherId} already exists.");
            }
            Database.Execute(sql, ToValues(t));
        }

        public void Update(Teacher t)
        {
            string sql =
                "UPDATE Teachers SET FirstName=@FirstName, MiddleName=@MiddleName, LastName=@LastName " +
                "WHERE TeacherId=@TeacherId";
            int rows = Database.Execute(sql, ToValues(t));
            if (rows == 0)
            {
                throw new RecordNotFoundException($"Teacher ID {t.TeacherId} not found.");
            }
        }

        public void Delete(string id)
        {
            Dictionary<string, object> values = new Dictionary<string, object>();
            values["@id"] = id; 
            int rows = Database.Execute("DELETE FROM Teachers WHERE TeacherId=@id", values);
            if (rows == 0)
            {
                throw new RecordNotFoundException($"Teacher ID {id} not found.");
            }

        }


        private Dictionary<string, object> ToValues(Teacher t)
        {
            Dictionary<string, object> values = new Dictionary<string, object>();
            values["@TeacherId"] = t.TeacherId;
            values["@FirstName"] = t.FirstName;
            values["@MiddleName"] = t.MiddleName;
            values["@LastName"] = t.LastName;
            return values;
        }

        private List<Teacher> ToList(System.Data.DataTable table)
        {
            List<Teacher> list = new List<Teacher>();
            foreach (System.Data.DataRow row in table.Rows)
            {
                Teacher t = new Teacher
                {
                    TeacherId = row["TeacherId"].ToString(),
                    FirstName = row["FirstName"].ToString(),
                    MiddleName = row["MiddleName"].ToString(),
                    LastName = row["LastName"].ToString()
                };
                list.Add(t);
            }
            return list;
        }

    }
}
