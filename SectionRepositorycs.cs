using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ABCEnrollmentSystem
{
    internal class SectionRepositorycs : IRepository<Section>   
    {
        public List<Section> GetAll() //1
        {
            return ToList(Database.GetTable("SELECT * FROM Sections ORDER BY SectionCode", null));
        }

        public Section GetByID(string id) //2
        {
            List<Section> list = ToList(Database.GetTable("SELECT * FROM Sections WHERE SectionCode = @k", id));
            if (list.Count == 0)
            {
                return null;
            }
            return list[0];
        }

        public List<Section> Search(string keyword) //3
        {
            string sql = "SELECT * FROM Sections WHERE SectionCode LIKE @k OR SectionName LIKE @k " +
                         "ORDER BY SectionCode";
            return ToList(Database.GetTable(sql, "%" + keyword + "%"));
        }

        public void Add(Section s)
        {
            string sql = "INSERT INTO Sections (SectionCode, SectionName, Description) " +
                         "VALUES (@SectionCode, @SectionName, @Description)";
            if (GetByID(s.SectionCode) != null)
            {
                throw new DuplicateRecordException("Section code " + s.SectionCode + " already exists.");
            }
            Database.Execute(sql, ToValues(s));
        }

        public void Update(Section s)
        {
            string sql = "UPDATE Sections SET SectionName=@SectionName, Description=@Description " +
                         "WHERE SectionCode=@SectionCode";
            int rows = Database.Execute(sql, ToValues(s));
            if (rows == 0)
            {
                throw new RecordNotFoundException("Section code " + s.SectionCode + " was not found.");
            }
        }

        public void Delete(string id)
        {
            Dictionary<string, object> values = new Dictionary<string, object>();
            values["@id"] = id;
            int rows = Database.Execute("DELETE FROM Sections WHERE SectionCode=@id", values);
            if (rows == 0)
            {
                throw new RecordNotFoundException("Section code " + id + " was not found.");
            }
        }

        private Dictionary<string, object> ToValues(Section s)
        {
            Dictionary<string, object> values = new Dictionary<string, object>();
            values["@SectionCode"] = s.SectionCode;
            values["@SectionName"] = s.SectionName;
            values["@Description"] = s.Description;
            return values;
        }

        public List<Section> ToList(DataTable table)
        {
            List<Section> list = new List<Section>();
            foreach (DataRow row in table.Rows)
            {
                Section s = new Section();
                s.SectionCode = row["SectionCode"].ToString();
                s.SectionName = row["SectionName"].ToString();
                s.Description = row["Description"].ToString();
                list.Add(s);
            }
            return list;
        }
    }
}
