using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ABCEnrollmentSystem
{
    internal class StudentRepository :IRepository<Student>
    {
        public List<Student> GetAll() //1
        {
            DataTable table = Database.GetTable("SELECT * FROM Students ORDER BY LastName, FirstName", null);
            return ToList(table);
        }

        public Student GetByID(string id) //2
        {
            DataTable table = Database.GetTable("SELECT * FROM Students WHERE StudentID=@k", id);

            List<Student> list = ToList(table);

            if (list.Count == 0) // no no student id found
            {
                return null;
            }
            return list[0];
        }

        public List<Student> Search(string keyword) //3
        {
            string sql =
                "Select * Students Where " +
                "StudentId LIKE @k OR FirstName LIKE @k OR MiddleName LIKE @k OR LastName LIKE @k" +
                "OR (FirstName + ' ' + LastName) LIKE @k " +
                "OR (FirstName + ' ' + MiddleName + ' ' + LastName) LIKE @k " +
                "ORDER BY LastName, FirstName";

            return ToList(Database.GetTable(sql, "%" + keyword + "%"));

        }
        
        public void Add(Student s)
        {
            string sql =
                "INSERT INTO Students (StudentId, FirstName, MiddleName, LastName, HouseNo, Street, " +
                "Municipality, Province, ZipCode, DateOfBirth, Gender, Mobile, Landline, Email, " +
                "GuardianName, GuardianAddress, GuardianMobile, GuardianLandline) " +
                "VALUES (@StudentId, @FirstName, @MiddleName, @LastName, @HouseNo, @Street, " +
                "@Municipality, @Province, @ZipCode, @DateOfBirth, @Gender, @Mobile, @Landline, @Email, " +
                "@GuardianName, @GuardianAddress, @GuardianMobile, @GuardianLandline)";

            if(GetByID(s.StudentID) != null)
            {
                throw new DuplicateRecordException($"Student ID {s.StudentID} already exists.");
            }
            Database.Execute(sql, ToValues(s));
        }

        public void Update(Student s)
        {
            string sql =
                "UPDATE Students SET FirstName=@FirstName, MiddleName=@MiddleName, LastName=@LastName, " +
                "HouseNo=@HouseNo, Street=@Street, Municipality=@Municipality, Province=@Province, " +
                "ZipCode=@ZipCode, DateOfBirth=@DateOfBirth, Gender=@Gender, Mobile=@Mobile, " +
                "Landline=@Landline, Email=@Email, GuardianName=@GuardianName, GuardianAddress=@GuardianAddress, " +
                "GuardianMobile=@GuardianMobile, GuardianLandline=@GuardianLandline WHERE StudentId=@StudentId";
            Database.Execute(sql, ToValues(s));

            int rows = Database.Execute(sql, ToValues(s));
            if (rows == 0)
            {
                throw new RecordNotFoundException($"Student ID {s.StudentID} not found.");
            }
        }

        public void Delete(string id)
        {
            Dictionary<string, object> values = new Dictionary<string, object>();
            values["@id"] = id;

            int rows = Database.Execute("DELETE FROM Students WHERE StudentId=@id", values);

            if (rows == 0)
            {
                throw new RecordNotFoundException($"Student ID {id} not found.");
            }

        }

        private Dictionary<string, object> ToValues(Student s)
        {
            Dictionary<string, object> values = new Dictionary<string, object>();
            values["@StudentId"] = s.StudentID;
            values["@FirstName"] = s.FirstName;
            values["@MiddleName"] = s.MiddleName;
            values["@LastName"] = s.LastName;
            values["@HouseNo"] = s.HouseNo;
            values["@Street"] = s.Street;
            values["@Municipality"] = s.Municipality;
            values["@Province"] = s.Province;
            values["@ZipCode"] = s.ZipCode;
            values["@DateOfBirth"] = s.DateOfBirth;
            values["@Gender"] = s.Gender;
            values["@Mobile"] = s.Mobile;
            values["@Landline"] = s.Landline;
            values["@Email"] = s.Email;
            values["@GuardianName"] = s.GuardianName;
            values["@GuardianAddress"] = s.GuardianAddress;
            values["@GuardianMobile"] = s.GuardianMobile;
            values["@GuardianLandline"] = s.GuardianLandline;
            return values;
        }

        private List<Student> ToList(DataTable table)
        {
            List<Student> list = new List<Student>();
            foreach (DataRow row in table.Rows)
            {
                Student s = new Student();
                s.StudentID = row["StudentId"].ToString();
                s.FirstName = row["FirstName"].ToString();
                s.MiddleName = row["MiddleName"].ToString();
                s.LastName = row["LastName"].ToString();
                s.HouseNo = row["HouseNo"].ToString();
                s.Street = row["Street"].ToString();
                s.Municipality = row["Municipality"].ToString();
                s.Province = row["Province"].ToString();
                s.ZipCode = row["ZipCode"].ToString();
                s.DateOfBirth = Convert.ToDateTime(row["DateOfBirth"]);
                s.Gender = row["Gender"].ToString();
                s.Mobile = row["Mobile"].ToString();
                s.Landline = row["Landline"].ToString();
                s.Email = row["Email"].ToString();
                s.GuardianName = row["GuardianName"].ToString();
                s.GuardianAddress = row["GuardianAddress"].ToString();
                s.GuardianMobile = row["GuardianMobile"].ToString();
                s.GuardianLandline = row["GuardianLandline"].ToString();
                list.Add(s);
            }
            return list;
        }

    }
}
