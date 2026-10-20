using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;


namespace ABCEnrollmentSystem
{
    public delegate bool EnrollmentFilter(EnrollmentRecord record);
    internal class EnrollmentService
    {
        IRepository<Student> _students;
        IRepository<Subject> _subjects;
        IRepository<Teacher> _teachers;
        IRepository<Section> _sections;
        IEnrollmentRepository _enrollments;

        public EnrollmentService(IRepository<Student> students, IRepository<Subject> subjects, IRepository<Teacher> teachers, IRepository<Section> sections, IEnrollmentRepository enrollments)
        {
            _students = students;
            _subjects = subjects;
            _teachers = teachers;
            _sections = sections;
            _enrollments = enrollments;
        }

        public void Enroll(string studentId, string subjectCode, string sectionCode, string schoolYear)
        {
            Student student = null;
            Subject subject = null;
            Section section = null;


            try
            {
                //existing? naka register na ba?
                student = _students.GetByID(studentId);
                subject = _subjects.GetByID(subjectCode);
                section = _sections.GetByID(sectionCode);
                if (student == null)
                {
                    throw new RecordNotFoundException($"Student with ID {studentId} not found.");
                }
                if (subject == null)
                {
                    throw new RecordNotFoundException($"Subject with code {subjectCode} not found.");
                }
                if (section == null)
                {
                    throw new RecordNotFoundException($"Section with code {sectionCode} not found.");
                }

                EnrollmentRecord record = new EnrollmentRecord();
                record.StudentID = studentId;
                record.SubjectCode = subjectCode;
                record.SectionCode = sectionCode;
                record.SchoolYear = schoolYear;

            }
            catch (RecordNotFoundException)
            {
                throw;
            }
            catch (DuplicateRecordException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Could not enroll the student" + ex.Message);
            }
        }

        public Dictionary<string, List<string>> GetClassListPerSection(EnrollmentFilter filter)
        {
            try
            {
                //Getall students
                Dictionary<string, Student> studentById = new Dictionary<string, Student>();
                foreach (Student s in _students.GetAll())
                {
                    studentById[s.StudentID] = s;
                }

                //Getall sections
                Dictionary<string, Section> sectionByCode = new Dictionary<string, Section>();
                foreach (Section sec in _sections.GetAll())
                {
                    sectionByCode[sec.SectionCode] = sec;
                }

                // Each section has a list for student
                Dictionary<string, List<string>> report = new Dictionary<string, List<string>>();
                foreach (Section sec in _sections.GetAll())
                {
                    report[sec.SectionCode + " - " + sec.SectionName] = new List<string>();
                }

                //Does through enrollment record to add it in its correspanding list
                foreach(EnrollmentRecord e in _enrollments.GetAll())
                {
                    if (filter != null && !filter(e))
                    {
                        continue;
                    }
                    string key = e.SectionCode + " - " + sectionByCode[e.SectionCode].SectionName;
                    string studentName = studentById[e.StudentID].FullName;
                    if (!report[key].Contains(studentName))
                    {
                        report[key].Add(studentName);
                    }
                }
                return report;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Could not create the class list per section report: " + ex.Message);
            }
        }

        //to do:
        //create report for class list per subject
        //report for teacher
    }
        
}   
