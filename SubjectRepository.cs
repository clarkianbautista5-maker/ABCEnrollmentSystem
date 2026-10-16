using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ABCEnrollmentSystem
{
    internal class SubjectRepository : IRepository<Subject>
    {
        public List<Subject> GetAll() //1
        {
            return ToList(Database.GetTable("SELECT * FROM Subjects ORDER BY SubjectCode", null));

        }

        public Subject GetByID(string id) //2
        {
            List<Subject> list = ToList(Database.GetTable("SELECT * FROM Subjects WHERE SubjectCode = @k", id));
            if (list.Count == 0)
            {
                return null;
            }
            return list[0];
        }

        public List<Subject> Search(string keyword) //3
        {
            string sql = "SELECT * FROM Subjects WHERE SubjectCode LIKE @k OR SubjectName LIKE @k " +
                         "ORDER BY SubjectCode";
            return ToList(Database.GetTable(sql, "%" + keyword + "%"));
        }

        public void Add(Subject s)
        {
            string sql = "INSERT INTO Subjects (SubjectCode, SubjectName, Description, Units, TeacherId) " +
                         "VALUES (@SubjectCode, @SubjectName, @Description, @Units, @TeacherId)";

            if (GetByID(s.SubjectCode) != null)
            {
                throw new DuplicateRecordException("Subject code " + s.SubjectCode + " already exists.");
            }

            Database.Execute(sql, ToValues(s));
        }

        public void Update(Subject s)
        {
            string sql = "UPDATE Subjects SET SubjectName=@SubjectName, Description=@Description, " +
                         "Units=@Units, TeacherId=@TeacherId WHERE SubjectCode=@SubjectCode";
            int rows = Database.Execute(sql, ToValues(s));
            if (rows == 0)
            {
                throw new RecordNotFoundException("Subject code " + s.SubjectCode + " was not found.");
            }
        }

        public void Delete(string id)
        {
            Dictionary<string, object> values = new Dictionary<string, object>();
            values["@id"] = id;
            int rows = Database.Execute("DELETE FROM Subjects WHERE SubjectCode = @id", values);
            if (rows == 0)
            {
                throw new RecordNotFoundException("Subject code " + id + " was not found.");
            }
        }

        private Dictionary<string, object> ToValues(Subject s)
        {
            Dictionary<string, object> values = new Dictionary<string, object>();
            values["@SubjectCode"] = s.SubjectCode;
            values["@SubjectName"] = s.SubjectName;
            values["@Description"] = s.Description;
            values["@Units"] = s.Units;
            values["@TeacherId"] = s.TeacherId;
            return values;
        }

        private List<Subject> ToList(DataTable table)
        {
            List<Subject> list = new List<Subject>();
            foreach (DataRow row in table.Rows)
            {
                Subject s = new Subject();
                s.SubjectCode = row["SubjectCode"].ToString();
                s.SubjectName = row["SubjectName"].ToString();
                s.Description = row["Description"].ToString();
                s.Units = Convert.ToInt32(row["Units"]);
                s.TeacherId = row["TeacherId"].ToString();
                list.Add(s);
            }
            return list;
        }


    }
}
