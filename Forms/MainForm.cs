using ABCEnrollmentSystem.Forms;
using System.Diagnostics.Eventing.Reader;

namespace ABCEnrollmentSystem
{
    public partial class MainForm : Form
    {
        private IRepository<Student> _students;
        private IRepository<Subject> _subjects;
        private IRepository<Teacher> _teachers;
        private IRepository<Section> _sections;
        private IEnrollmentRepository _enrollments;
        private EnrollmentService _service;


        public MainForm()
        {
            InitializeComponent();

            _students = new StudentRepository();
            _subjects = new SubjectRepository();
            _teachers = new TeacherRepository();
            _sections = new SectionRepository();
            _enrollments = new EnrollmentRepository();
            _service = new EnrollmentService(_students, _subjects, _teachers, _sections, _enrollments);

            //nag dudupe yung columns pag wala
            dgvStudents.AutoGenerateColumns = false;
            dgvSubjects.AutoGenerateColumns = false;
            dgvTeachers.AutoGenerateColumns = false;
            dgvSections.AutoGenerateColumns = false;


        }

        private void ShowPanel(Panel panel, string title)
        {
            pnlDashboard.Visible = false;
            pnlStudents.Visible = false;
            pnlSubjects.Visible = false;
            pnlTeachers.Visible = false;
            pnlSections.Visible = false;
            pnlEnroll.Visible = false;
            pnlReports.Visible = false;
            pnlUserLog.Visible = false;
            pnlActivityLog.Visible = false;
            panel.Visible = true;
            panel.BringToFront();
            lblPageTitle.Text = title;
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowDashboard();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            StudentsOpen();
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            SubjectsOpen();
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            TeacherOpen();
        }

        private void btnSections_Click(object sender, EventArgs e)
        {
            SectionsOpen();
        }



        private void btnEnroll_Click(object sender, EventArgs e)
        {
            EnrollOpen(null);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlReports, "Reports");
        }

        //Dashboard
        private void ShowDashboard()
        {
            ShowPanel(pnlDashboard, "Dashboard");
        }
        //Sulit lagay mo dito yung activity log
        // sa Enrollment service yung reports metthod


        //All Student
        private void StudentsOpen()
        {
            ShowPanel(pnlStudents, "Students");
            txtStudentsSearch.Clear();
            StudentShowAll();
        }
        private void btnStudentsSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtStudentsSearch.Text.Trim();
                if (searchTerm == "")
                {
                    StudentShowAll();
                }
                else
                {
                    StudentsShowList(_students.Search(searchTerm));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex.Message);
            }
        }

        private void btnStudentsShowAll_Click(object sender, EventArgs e)
        {
            txtStudentsSearch.Clear();
            StudentShowAll();
        }

        private void btnStudentsAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (StudentDetailsForm form = new StudentDetailsForm(_students, null))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        StudentShowAll();
                        LogRepository.AddActivityLog("Add", "Students", "Added a new student");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex.Message);
            }
        }
        private void btnStudentsUpdate_Click(object sender, EventArgs e)
        {
            Student selected = StudentGetSelected();
            if (selected == null)
            {
                MessageBox.Show("Please select a student to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (StudentDetailsForm form = new StudentDetailsForm(_students, selected))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        StudentShowAll();
                        LogRepository.AddActivityLog("Update", "Students", "Updated student " + selected.StudentId);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex.Message);
            }
        }


        private void btnStudentsDelete_Click(object sender, EventArgs e)
        {
            Student selected = StudentGetSelected();
            if (selected == null)
            {
                MessageBox.Show("Select a student to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No)
            {
                return;
            }
            try
            {
                _students.Delete(selected.StudentId);
                LogRepository.AddActivityLog("Delete", "Students", "Deleted student " + selected.StudentId);   // [NEW]
                MessageBox.Show("Student deletd.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StudentShowAll();
            }
            catch (RecordNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex.Message);
            }
        }

        private void btnStudentsEnroll_Click(object sender, EventArgs e)
        {
            Student selected = StudentGetSelected();
            if (selected == null)
            {
                MessageBox.Show("Please select a student to enroll.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            EnrollOpen(selected.StudentId);
        }

        private void StudentShowAll() //get all student
        {
            try
            {
                StudentsShowList(_students.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load students" + ex.Message);
            }
        }

        private void StudentsShowList(List<Student> students) // put it to the Data grid
        {
            dgvStudents.DataSource = students;
        }

        private Student StudentGetSelected()
        {
            if (dgvStudents.SelectedRows.Count == 0)
            {
                return null;
            }
            return (Student)dgvStudents.SelectedRows[0].DataBoundItem;
        }


        //All Subject
        private void SubjectsOpen()
        {
            ShowPanel(pnlSubjects, "Subjects");
            txtSubjectsSearch.Clear();
            SubjectsShowAll();
        }
        private void btnSubjectsSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtSubjectsSearch.Text.Trim();
                if (searchTerm == "")
                {
                    SubjectsShowAll();
                }
                else
                {
                    SubjectsShowList(_subjects.Search(searchTerm));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex.Message);
            }
        }

        private void btnSubjectsShowAll_Click(object sender, EventArgs e)
        {
            txtSubjectsSearch.Clear();
            SubjectsShowAll();
        }

        private void btnSubjectsAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SubjectDetailsForm form = new SubjectDetailsForm(_subjects, _teachers, null))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        SubjectsShowAll();
                        LogRepository.AddActivityLog("Add", "Subjects", "Added a new subject");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex.Message);
            }
        }

        private void btnSubjectsUpdate_Click(object sender, EventArgs e)
        {
            Subject selected = SubjectGetSelected();
            if (selected == null)
            {
                MessageBox.Show("Select a subject to update ", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SubjectDetailsForm form = new SubjectDetailsForm(_subjects, _teachers, selected))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        SubjectsShowAll();
                        LogRepository.AddActivityLog("Update", "Subjects", "Updated subject " + selected.SubjectCode);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex.Message);
            }
        }

        private void btnSubjectsDelete_Click(object sender, EventArgs e)
        {
            Subject selected = SubjectGetSelected();
            if (selected == null)
            {
                MessageBox.Show("Select a subject to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No)
            {
                return;
            }

            try
            {
                _subjects.Delete(selected.SubjectCode);
                LogRepository.AddActivityLog("Delete", "Subjects", "Deleted subject " + selected.SubjectCode);
                MessageBox.Show("Subject deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SubjectsShowAll();
            }
            catch (RecordNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not delete the record: " + ex.Message);
            }
        }

        private void SubjectsShowAll()
        {
            try
            {
                SubjectsShowList(_subjects.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load subjects" + ex.Message);
            }
        }
        private void SubjectsShowList(List<Subject> subjects)
        {
            dgvSubjects.DataSource = subjects;
        }

        private Subject SubjectGetSelected()
        {
            if (dgvSubjects.SelectedRows.Count == 0)
            {
                return null;
            }
            return (Subject)dgvSubjects.SelectedRows[0].DataBoundItem;
        }

        //All Teacher
        private void TeacherOpen()
        {
            ShowPanel(pnlTeachers, "Teachers");
            txtTeachersSearch.Clear();
            TeachersShowAll();
        }

        private void btnTeachersSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtTeachersSearch.Text.Trim();
                if (searchTerm == "")
                {
                    TeachersShowAll();
                }
                else
                {
                    TeachersShowList(_teachers.Search(searchTerm));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex.Message);

            }
        }

        private void btnTeachersShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                txtTeachersSearch.Clear();
                TeachersShowAll();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex.Message);
            }
        }
        private void btnTeachersAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (TeacherDetailsForm form = new TeacherDetailsForm(_teachers, null))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        TeachersShowAll();
                        LogRepository.AddActivityLog("Add", "Teachers", "Added a new teacher");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex.Message);
            }
        }

        private void btnTeachersUpdate_Click(object sender, EventArgs e)
        {
            Teacher selected = TeacherGetSelected();
            if (selected == null)
            {
                MessageBox.Show("Select a teacher to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (TeacherDetailsForm form = new TeacherDetailsForm(_teachers, selected))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        TeachersShowAll();
                        LogRepository.AddActivityLog("Update", "Teachers", "Updated teacher " + selected.TeacherId);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex.Message);
            }
        }

        private void btnTeachersDelete_Click(object sender, EventArgs e)
        {
            Teacher selected = TeacherGetSelected();
            if (selected == null)
            {
                MessageBox.Show("Select a teacher to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No)
            {
                return;
            }

            try
            {
                _teachers.Delete(selected.TeacherId);
                LogRepository.AddActivityLog("Delete", "Teachers", "Deleted teacher " + selected.TeacherId);
                MessageBox.Show("Teacher deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TeachersShowAll();

            }
            catch (RecordNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not delete the record: " + ex.Message);
            }
        }
        private void TeachersShowAll()
        {
            try
            {
                TeachersShowList(_teachers.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load teachers" + ex.Message);
            }
        }

        private void TeachersShowList(List<Teacher> teachers)
        {
            dgvTeachers.DataSource = teachers;
        }

        private Teacher TeacherGetSelected()
        {
            if (dgvTeachers.SelectedRows.Count == 0)
            {
                return null;
            }
            return (Teacher)dgvTeachers.SelectedRows[0].DataBoundItem;
        }

        //All Section
        private void SectionsOpen()
        {
            ShowPanel(pnlSections, "Sections");
            txtSectionsSearch.Clear();
            SectionsShowAll();
        }

        private void btnSectionsSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtSectionsSearch.Text.Trim();
                if (searchTerm == "")
                {
                    SectionsShowAll();
                }
                else
                {
                    SectionsShowList(_sections.Search(searchTerm));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex.Message);

            }
        }
        private void btnSectionsShowAll_Click(object sender, EventArgs e)
        {
            txtSectionsSearch.Clear();
            SectionsShowAll();
        }

        private void btnSectionsAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SectionDetailsForm form = new SectionDetailsForm(_sections, null))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        SectionsShowAll();
                        LogRepository.AddActivityLog("Add", "Sections", "Added a new section");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex.Message);
            }
        }
        private void btnSectionsUpdate_Click(object sender, EventArgs e)
        {
            Section selected = SectionGetSelected();
            if (selected == null)
            {
                MessageBox.Show("Select a section to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SectionDetailsForm form = new SectionDetailsForm(_sections, selected))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        SectionsShowAll();
                        LogRepository.AddActivityLog("Update", "Sections", "Updated section " + selected.SectionCode);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex.Message);
            }
        }
        private void btnSectionsDelete_Click(object sender, EventArgs e)
        {
            Section selected = SectionGetSelected();
            if (selected == null)
            {
                MessageBox.Show("Select a section to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No)
            {
                return;
            }

            try
            {
                _sections.Delete(selected.SectionCode);
                LogRepository.AddActivityLog("Delete", "Sections", "Deleted section " + selected.SectionCode);
                MessageBox.Show("Section deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SectionsShowAll();

            }
            catch (RecordNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not delete the record: " + ex.Message);
            }
        }
        private void SectionsShowAll()
        {
            try
            {
                SectionsShowList(_sections.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load sections" + ex.Message);
            }
        }

        private void SectionsShowList(List<Section> sections)
        {
            dgvSections.DataSource = sections;
        }

        private Section SectionGetSelected()
        {
            if (dgvSections.SelectedRows.Count == 0)
            {
                return null;
            }
            return (Section)dgvSections.SelectedRows[0].DataBoundItem;
        }
        //All Enroll

        private bool _enrollFromStudents;

        public void EnrollOpen(string selectedStudentId)
        {
            _enrollFromStudents = selectedStudentId != null; //pag may id true, pag wala false
            ShowPanel(pnlEnroll, "Enroll");

            try
            {
                cboEnrollStudent.DataSource = _students.GetAll();
                LoadEnrollSubjects();
                cboEnrollSection.DataSource = _sections.GetAll();

                cboEnrollStudent.Enabled = true;

                if (selectedStudentId != null)
                {
                    cboEnrollStudent.SelectedValue = selectedStudentId;
                    cboEnrollStudent.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load data: " + ex.Message);
            }
        }
        private void btnEnrollSave_Click(object sender, EventArgs e)
        {
            if (cboEnrollStudent.SelectedItem == null || cboEnrollSubject.SelectedItem == null || cboEnrollSection.SelectedItem == null)
            {
                MessageBox.Show("Please select a student, subject, and section.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _service.Enroll(cboEnrollStudent.SelectedValue.ToString(), cboEnrollSubject.SelectedValue.ToString(), cboEnrollSection.SelectedValue.ToString(), txtEnrollSchoolYear.Text);
                string message = cboEnrollStudent.Text + " was enrolled in " + cboEnrollSubject.Text + " (" + cboEnrollSection.Text + ") for " + txtEnrollSchoolYear.Text.Trim() + ".";
                MessageBox.Show(message, "Enrollment successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEnrollSubjects(); 
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not enroll student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEnrollClose_Click(object sender, EventArgs e)
        {
            if (_enrollFromStudents)
            {
                StudentsOpen();
            }
            else
            {
                ShowDashboard();
            }
        }


        private void LoadEnrollSubjects() //Only load subjects student not enrolled
        {
            if (cboEnrollStudent.SelectedValue == null)
            {
                return;
            }

            string studentId = cboEnrollStudent.SelectedValue.ToString();
            List<Subject> available = new List<Subject>();

            foreach (Subject subject in _subjects.GetAll())
            {
                bool taken = false;

                foreach (EnrollmentRecord record in _enrollments.GetAll())
                {
                    if (record.StudentID == studentId && record.SubjectCode == subject.SubjectCode)
                    {
                        taken = true;
                    }
                }

                if (taken == false)
                {
                    available.Add(subject);
                }
            }

            cboEnrollSubject.DataSource = available;
        }

        private void cboEnrollStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadEnrollSubjects();
        }

        // All User Log
        private void btnUserLog_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlUserLog, "User Log");
            txtUserLogSearch.Clear();
            UserLogShowAll();
        }

        private void UserLogShowAll()
        {
            try
            {
                dgvUserLog.DataSource = LogRepository.GetUserLogs(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot load user log: " + ex.Message);
            }
        }

        private void btnUserLogSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvUserLog.DataSource = LogRepository.GetUserLogs(txtUserLogSearch.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed: " + ex.Message);
            }
        }

        private void btnUserLogShowAll_Click(object sender, EventArgs e)
        {
            txtUserLogSearch.Clear();
            UserLogShowAll();
        }

        private void btnActivityLog_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlActivityLog, "Activity Log");
            txtActivityLogSearch.Clear();
            ActivityLogShowAll();
        }

        private void ActivityLogShowAll()
        {
            try
            {
                dgvActivityLog.DataSource = LogRepository.GetActivityLogs(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot load activity log: " + ex.Message);
            }
        }

        private void btnActivityLogSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvActivityLog.DataSource = LogRepository.GetActivityLogs(txtActivityLogSearch.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed: " + ex.Message);
            }
        }

        private void btnActivityLogShowAll_Click(object sender, EventArgs e)
        {
            txtActivityLogSearch.Clear();
            ActivityLogShowAll();
        }

        
    }
}
