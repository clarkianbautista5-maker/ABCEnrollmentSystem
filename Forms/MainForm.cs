using ABCEnrollmentSystem.Forms;
using System.Diagnostics.Eventing.Reader;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;
using System.Drawing.Printing;

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

        private List<string> _reportLines;
        private string _reportTitle;
        private string _reportInfo;
        private int _reportIndex;


        public MainForm()
        {
            InitializeComponent();
            timer1.Stop();
            timer1.Interval = 300;
            _students = new StudentRepository();
            _subjects = new SubjectRepository();
            _teachers = new TeacherRepository();
            _sections = new SectionRepository();
            _enrollments = new EnrollmentRepository();
            _service = new EnrollmentService(_students, _subjects, _teachers, _sections, _enrollments);

            this.FormClosing += MainForm_FormClosing; // log logout

            dgvStudents.AutoGenerateColumns = false;
            dgvSubjects.AutoGenerateColumns = false;
            dgvTeachers.AutoGenerateColumns = false;
            dgvSections.AutoGenerateColumns = false;

            ShowDashboard();
        }

        private void ShowPanel(Panel panel, string title)
        {
            pnlDashboard.Visible = false;
            pnlStudents.Visible = false;
            pnlSubjects.Visible = false;
            pnlTeachers.Visible = false;
            pnlSections.Visible = false;
            pnlEnroll.Visible = false;
            pnlUserLog.Visible = false;
            pnlActivityLog.Visible = false;
            pnlReports.Visible = false;
            panel.Visible = true;
            panel.BringToFront();
            lblPageTitle.Text = title;
        }
        private void btnDashboard_Click(object sender, EventArgs eventArgs)
        {
            ShowDashboard();
        }

        private void btnStudents_Click(object sender, EventArgs eventArgs)
        {
            StudentsOpen();
        }

        private void btnSubjects_Click(object sender, EventArgs eventArgs)
        {
            SubjectsOpen();
        }

        private void btnTeachers_Click(object sender, EventArgs eventArgs)
        {
            TeacherOpen();
        }

        private void btnSections_Click(object sender, EventArgs eventArgs)
        {
            SectionsOpen();
        }

        private void btnEnroll_Click(object sender, EventArgs eventArgs)
        {
            EnrollOpen(null);
        }

        private void btnReports_Click(object sender, EventArgs eventArgs)
        {
            ShowPanel(pnlReports, "Reports");
        }

        private void ShowDashboard()
        {
            ShowPanel(pnlDashboard, "Dashboard");
            LoadDashboard();
        }
        private void BuildCharts()
        {
            chartGender = MakeChart("Students by Gender", SeriesChartType.Pie);
            chartSubjects = MakeChart("Enrollments per Subject", SeriesChartType.Column);
            chartActivity = MakeChart("Activity (Last 7 Days)", SeriesChartType.Line);

            tlpDashboard.Controls.Add(chartGender, 0, 1);
            tlpDashboard.Controls.Add(chartSubjects, 1, 1);
            tlpDashboard.Controls.Add(chartActivity, 0, 2);
        }

        private Chart MakeChart(string title, SeriesChartType type)
        {
            Color textColor = Color.FromArgb(232, 238, 252);
            Color gridColor = Color.FromArgb(46, 63, 102);

            Chart chart = new Chart();
            chart.Dock = DockStyle.Fill;
            chart.BackColor = Color.FromArgb(28, 42, 69);

            ChartArea area = new ChartArea("Main");
            area.BackColor = Color.Transparent;
            area.AxisX.LabelStyle.ForeColor = textColor;
            area.AxisY.LabelStyle.ForeColor = textColor;
            area.AxisX.LineColor = gridColor;
            area.AxisY.LineColor = gridColor;
            area.AxisX.MajorGrid.LineColor = gridColor;
            area.AxisY.MajorGrid.LineColor = gridColor;
            chart.ChartAreas.Add(area);

            Series series = new Series("Data");
            series.ChartType = type;
            series.IsValueShownAsLabel = true;
            series.LabelForeColor = textColor;
            chart.Series.Add(series);

            if (type == SeriesChartType.Pie)
            {
                Legend legend = new Legend("Legend");
                legend.BackColor = Color.Transparent;
                legend.ForeColor = textColor;
                chart.Legends.Add(legend);
            }

            chart.Titles.Add(new Title(title, Docking.Top, new Font("Segoe UI", 11F, FontStyle.Bold), Color.White));
            return chart;
        }

        private void LoadDashboard()
        {
            try
            {
                if (chartGender == null)
                {
                    BuildCharts();
                }
                // KPI
                lblKpiStudents.Text = DashboardRepository.CountOf("Students").ToString();
                lblKpiSubjects.Text = DashboardRepository.CountOf("Subjects").ToString();
                lblKpiTeachers.Text = DashboardRepository.CountOf("Teachers").ToString();
                lblKpiSections.Text = DashboardRepository.CountOf("Sections").ToString();

                // Pie
                chartGender.Series[0].Points.Clear();
                foreach (DataRow row in DashboardRepository.GetGenderCounts().Rows)
                    chartGender.Series[0].Points.AddXY(row["Gender"].ToString(), Convert.ToInt32(row["Total"]));

                // Bar
                chartSubjects.Series[0].Points.Clear();
                foreach (DataRow row in DashboardRepository.GetEnrollmentsPerSubject().Rows)
                    chartSubjects.Series[0].Points.AddXY(row["SubjectName"].ToString(), Convert.ToInt32(row["Total"]));

                // Line
                chartActivity.Series[0].Points.Clear();
                foreach (DataRow row in DashboardRepository.GetActivityLast7Days().Rows)
                    chartActivity.Series[0].Points.AddXY(Convert.ToDateTime(row["Day"]).ToString("MMM dd"), Convert.ToInt32(row["Total"]));

                // Recent
                dgvRecent.DataSource = DashboardRepository.GetRecentActivity();
            }
            catch (Exception error)
            {
                MessageBox.Show("Dashboard error: " + error.Message);
            }
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
        private void btnStudentsSearch_Click(object sender, EventArgs eventArgs)
        {
            timer1.Stop();
            StudentsSearch();
        }

        private void btnStudentsShowAll_Click(object sender, EventArgs eventArgs)
        {
            txtStudentsSearch.Clear();
            StudentShowAll();
        }

        private void btnStudentsAdd_Click(object sender, EventArgs eventArgs)
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
            catch (Exception error)
            {
                MessageBox.Show("Something went wrong: " + error.Message);
            }
        }
        private void btnStudentsUpdate_Click(object sender, EventArgs eventArgs)
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
            catch (Exception error)
            {
                MessageBox.Show("Something went wrong: " + error.Message);
            }
        }


        private void btnStudentsDelete_Click(object sender, EventArgs eventArgs)
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
                LogRepository.AddActivityLog("Delete", "Students", "Deleted student " + selected.StudentId);
                MessageBox.Show("Student deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StudentShowAll();
            }
            catch (RecordNotFoundException error)
            {
                MessageBox.Show(error.Message, "Not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception error)
            {
                MessageBox.Show("Something went wrong: " + error.Message);
            }
        }

        private void btnStudentsEnroll_Click(object sender, EventArgs eventArgs)
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
            catch (Exception error)
            {
                MessageBox.Show("Could not load students" + error.Message);
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
        private void btnSubjectsSearch_Click(object sender, EventArgs eventArgs)
        {
            timer1.Stop();
            SubjectsSearch();

        }

        private void btnSubjectsShowAll_Click(object sender, EventArgs eventArgs)
        {
            txtSubjectsSearch.Clear();
            SubjectsShowAll();
        }

        private void btnSubjectsAdd_Click(object sender, EventArgs eventArgs)
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
            catch (Exception error)
            {
                MessageBox.Show("Something went wrong: " + error.Message);
            }
        }

        private void btnSubjectsUpdate_Click(object sender, EventArgs eventArgs)
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
            catch (Exception error)
            {
                MessageBox.Show("Something went wrong: " + error.Message);
            }
        }

        private void btnSubjectsDelete_Click(object sender, EventArgs eventArgs)
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
            catch (RecordNotFoundException error)
            {
                MessageBox.Show(error.Message, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception error)
            {
                MessageBox.Show("Could not delete the record: " + error.Message);
            }
        }

        private void SubjectsShowAll()
        {
            try
            {
                SubjectsShowList(_subjects.GetAll());
            }
            catch (Exception error)
            {
                MessageBox.Show("Could not load subjects" + error.Message);
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

        private void btnTeachersSearch_Click(object sender, EventArgs eventArgs)
        {
            timer1.Stop();
            TeachersSearch();
        }

        private void btnTeachersShowAll_Click(object sender, EventArgs eventArgs)
        {
            try
            {
                txtTeachersSearch.Clear();
                TeachersShowAll();

            }
            catch (Exception error)
            {
                MessageBox.Show("Something went wrong: " + error.Message);
            }
        }
        private void btnTeachersAdd_Click(object sender, EventArgs eventArgs)
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
            catch (Exception error)
            {
                MessageBox.Show("Something went wrong: " + error.Message);
            }
        }

        private void btnTeachersUpdate_Click(object sender, EventArgs eventArgs)
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
            catch (Exception error)
            {
                MessageBox.Show("Something went wrong: " + error.Message);
            }
        }

        private void btnTeachersDelete_Click(object sender, EventArgs eventArgs)
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
            catch (RecordNotFoundException error)
            {
                MessageBox.Show(error.Message, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception error)
            {
                MessageBox.Show("Could not delete the record: " + error.Message);
            }
        }
        private void TeachersShowAll()
        {
            try
            {
                TeachersShowList(_teachers.GetAll());
            }
            catch (Exception error)
            {
                MessageBox.Show("Could not load teachers" + error.Message);
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

        private void btnSectionsSearch_Click(object sender, EventArgs eventArgs)
        {
            timer1.Stop();
            SectionsSearch();

        }
        private void btnSectionsShowAll_Click(object sender, EventArgs eventArgs)
        {
            txtSectionsSearch.Clear();
            SectionsShowAll();
        }

        private void btnSectionsAdd_Click(object sender, EventArgs eventArgs)
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
            catch (Exception error)
            {
                MessageBox.Show("Something went wrong: " + error.Message);
            }
        }
        private void btnSectionsUpdate_Click(object sender, EventArgs eventArgs)
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
            catch (Exception error)
            {
                MessageBox.Show("Something went wrong: " + error.Message);
            }
        }
        private void btnSectionsDelete_Click(object sender, EventArgs eventArgs)
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
            catch (RecordNotFoundException error)
            {
                MessageBox.Show(error.Message, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception error)
            {
                MessageBox.Show("Could not delete the record: " + error.Message);
            }
        }
        private void SectionsShowAll()
        {
            try
            {
                SectionsShowList(_sections.GetAll());
            }
            catch (Exception error)
            {
                MessageBox.Show("Could not load sections" + error.Message);
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
            catch (Exception error)
            {
                MessageBox.Show("Could not load data: " + error.Message);
            }
        }
        private void btnEnrollSave_Click(object sender, EventArgs eventArgs)
        {
            if (cboEnrollStudent.SelectedItem == null || cboEnrollSubject.SelectedItem == null || cboEnrollSection.SelectedItem == null)
            {
                MessageBox.Show("Please select a student, subject, and section.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _service.Enroll(cboEnrollStudent.SelectedValue.ToString(), cboEnrollSubject.SelectedValue.ToString(), cboEnrollSection.SelectedValue.ToString(), txtEnrollSchoolYear.Text);

                // log enroll
                LogRepository.AddActivityLog("Enroll", "Enrollment", "Enrolled " + cboEnrollStudent.Text + " in " + cboEnrollSubject.Text);

                string message = cboEnrollStudent.Text + " was enrolled in " + cboEnrollSubject.Text + " (" + cboEnrollSection.Text + ") for " + txtEnrollSchoolYear.Text.Trim() + ".";
                MessageBox.Show(message, "Enrollment successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEnrollSubjects();

            }
            catch (Exception error)
            {
                MessageBox.Show("Could not enroll student: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEnrollClose_Click(object sender, EventArgs eventArgs)
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

        private void cboEnrollStudent_SelectedIndexChanged(object sender, EventArgs eventArgs)
        {
            LoadEnrollSubjects();
        }

        // All User Log
        private void btnUserLog_Click(object sender, EventArgs eventArgs)
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
            catch (Exception error)
            {
                MessageBox.Show("Cannot load user log: " + error.Message);
            }
        }

        private void btnUserLogSearch_Click(object sender, EventArgs eventArgs)
        {
            try
            {
                dgvUserLog.DataSource = LogRepository.GetUserLogs(txtUserLogSearch.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show("Search failed: " + error.Message);
            }
        }

        private void btnUserLogShowAll_Click(object sender, EventArgs eventArgs)
        {
            txtUserLogSearch.Clear();
            UserLogShowAll();
        }

        private void btnActivityLog_Click(object sender, EventArgs eventArgs)
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
            catch (Exception error)
            {
                MessageBox.Show("Cannot load activity log: " + error.Message);
            }
        }

        private void btnActivityLogSearch_Click(object sender, EventArgs eventArgs)
        {
            timer1.Stop();
            ActivityLogSearch();

        }

        private void btnActivityLogShowAll_Click(object sender, EventArgs eventArgs)
        {
            txtActivityLogSearch.Clear();
            ActivityLogShowAll();
        }

        private void tlpDashboard_Paint(object sender, PaintEventArgs eventArgs)
        {

        }

        private void btnLogout_Click(object sender, EventArgs eventArgs)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }

        //log logout
        private void MainForm_FormClosing(object sender, FormClosingEventArgs eventArgs)
        {
            LogRepository.AddUserLog("Logout");
        }

        private void btnPrintReport_Click(object sender, EventArgs eventArgs)
        {
            if (cboReportType.SelectedIndex < 0)
            {
                MessageBox.Show("Select a report type.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable reportData;
                string reportTitle;

                switch (cboReportType.SelectedIndex)
                {
                    case 0:
                        reportTitle = "Class List Per Section";
                        reportData = ReportRepository.GetClassListPerSection(txtReportsSchoolYear.Text);
                        break;
                    case 1:
                        reportTitle = "Class List Per Subject";
                        reportData = ReportRepository.GetClassListPerSubject(txtReportsSchoolYear.Text);
                        break;
                    default:
                        reportTitle = "Subjects Assigned To Teachers";
                        reportData = ReportRepository.GetSubjectsPerTeacher();
                        break;
                }

                if (reportData.Rows.Count == 0)
                {
                    MessageBox.Show("No records found.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                BuildReport(reportTitle, reportData);

                if (printDialogReport.ShowDialog() == DialogResult.OK)
                {
                    printDocReport.Print();

                    // log print
                    LogRepository.AddActivityLog("Print", "Reports", "Printed report: " + reportTitle);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Report error: " + error.Message);
            }
        }

        // report lines
        private void BuildReport(string reportTitle, DataTable reportData)
        {
            bool isTeacherReport = cboReportType.SelectedIndex == 2;
            string schoolYear = string.IsNullOrWhiteSpace(txtReportsSchoolYear.Text) ? "All" : txtReportsSchoolYear.Text.Trim();
            string today = DateTime.Now.ToString("MMMM dd, yyyy");

            _reportTitle = reportTitle;
            _reportInfo = isTeacherReport ? "Date: " + today : "School Year: " + schoolYear + "   Date: " + today;
            _reportLines = new List<string>();

            string currentGroup = null;
            int groupIndex = 0;
            int itemCount = 0;

            foreach (DataRow row in reportData.Rows)
            {
                string group = row["GroupName"].ToString();
                string item = row["Item"].ToString();

                if (group != currentGroup)
                {
                    if (currentGroup != null)
                    {
                        _reportLines.Add("");
                    }

                    _reportLines.Add(group);
                    groupIndex = _reportLines.Count - 1;
                    currentGroup = group;
                    itemCount = 0;
                }

                if (item != "(none)")
                {
                    itemCount++;
                }

                _reportLines[groupIndex] = group + " (" + itemCount + ")";
                _reportLines.Add("     " + item);
            }
        }

        private void printDocReport_BeginPrint(object sender, PrintEventArgs printArgs)
        {
            _reportIndex = 0; // reset
        }

        private void printDocReport_PrintPage(object sender, PrintPageEventArgs printPageArgs)
        {
            using (Font titleFont = new Font("Arial", 16, FontStyle.Bold))
            using (Font boldFont = new Font("Arial", 11, FontStyle.Bold))
            using (Font normalFont = new Font("Arial", 11))
            {
                float leftMargin = printPageArgs.MarginBounds.Left;
                float currentTop = printPageArgs.MarginBounds.Top;
                float lineHeight = normalFont.GetHeight(printPageArgs.Graphics) + 4;

                printPageArgs.Graphics.DrawString("ABC Senior High", titleFont, Brushes.Black, leftMargin, currentTop);
                currentTop += titleFont.GetHeight(printPageArgs.Graphics) + 4;
                printPageArgs.Graphics.DrawString(_reportTitle, boldFont, Brushes.Black, leftMargin, currentTop);
                currentTop += lineHeight;
                printPageArgs.Graphics.DrawString(_reportInfo, normalFont, Brushes.Black, leftMargin, currentTop);
                currentTop += lineHeight;
                printPageArgs.Graphics.DrawLine(Pens.Black, leftMargin, currentTop, printPageArgs.MarginBounds.Right, currentTop);
                currentTop += lineHeight;

                while (_reportIndex < _reportLines.Count)
                {
                    if (currentTop + lineHeight > printPageArgs.MarginBounds.Bottom)
                    {
                        printPageArgs.HasMorePages = true; // next page
                        return;
                    }

                    string line = _reportLines[_reportIndex];
                    bool isGroupLine = line != "" && !line.StartsWith(" ");
                    Font lineFont = isGroupLine ? boldFont : normalFont;

                    printPageArgs.Graphics.DrawString(line, lineFont, Brushes.Black, leftMargin, currentTop);
                    currentTop += lineHeight;
                    _reportIndex++;
                }

                printPageArgs.HasMorePages = false;
            }
        }
        private Action _pendingSearch;

        private void StartSearchTimer(Action search)
        {
            _pendingSearch = search;
            timer1.Stop();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            if (_pendingSearch != null)
            {
                _pendingSearch();
            }

        }


        private void txtStudentsSearch_TextChanged(object sender, EventArgs e)
        {
            StartSearchTimer(StudentsSearch);

        }
        private void StudentsSearch()
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
            catch (Exception error)
            {
                MessageBox.Show("Something went wrong: " + error.Message);
            }
        }

        private void txtSubjectsSearch_TextChanged(object sender, EventArgs e)
        {
            StartSearchTimer(SubjectsSearch);
        }
        private void SubjectsSearch()
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
            catch (Exception error)
            {
                MessageBox.Show("Something went wrong: " + error.Message);
            }
        }

        private void txtTeachersSearch_TextChanged(object sender, EventArgs e)
        {
            StartSearchTimer(TeachersSearch);

        }
        private void TeachersSearch()
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
            catch (Exception error)
            {
                MessageBox.Show("Something went wrong: " + error.Message);
            }
        }

        private void txtSectionsSearch_TextChanged(object sender, EventArgs e)
        {
            StartSearchTimer(SectionsSearch);

        }
        private void SectionsSearch()
        {
            try
            {
                string searchTerm = txtSectionsSearch.Text.Trim();

                if (searchTerm == "")
                {
                    SectionsShowAll();
                    return;
                }

                List<Section> result = new List<Section>();

                foreach (Section section in _sections.GetAll())
                {
                    bool match =
                        (section.SectionCode ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                        (section.SectionName ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                        (section.Description ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase);

                    if (match)
                    {
                        result.Add(section);
                    }
                }

                SectionsShowList(result);
            }
            catch (Exception error)
            {
                MessageBox.Show("Something went wrong: " + error.Message);
            }
        }

        private void txtUserLogSearch_TextChanged(object sender, EventArgs e)
        {
            StartSearchTimer(UserlogSearch);

        }

        private void btnUserLogSearch_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
            UserlogSearch();

        }
        private void UserlogSearch()
        {
            try
            {
                string keyword = txtUserLogSearch.Text.Trim().ToLower();
                keyword = keyword.Replace(" ", "").Replace(",", "");

                DataTable all = LogRepository.GetUserLogs(null);

                DataTable result = all.Clone();

                foreach (DataRow row in all.Rows)
                {
                    string username = row["Username"].ToString();
                    string action = row["Action"].ToString();

                    string module = "";
                    if (all.Columns.Contains("Module"))
                    {
                        module = row["Module"].ToString();
                    }

                    string details = "";
                    if (all.Columns.Contains("Details"))
                    {
                        details = row["Details"].ToString();
                    }

                    DateTime date = Convert.ToDateTime(row["LogDate"]);
                    string dateText = date.ToString("dd/MM/yyyy h:mm tt");

                    string usernameCheck = username.ToLower().Replace(" ", "").Replace(",", "");
                    string actionCheck = action.ToLower().Replace(" ", "").Replace(",", "");
                    string moduleCheck = module.ToLower().Replace(" ", "").Replace(",", "");
                    string detailsCheck = details.ToLower().Replace(" ", "").Replace(",", "");
                    string dateCheck = dateText.ToLower().Replace(" ", "").Replace(",", "");

                    if (keyword == "" ||
                        usernameCheck.Contains(keyword) ||
                        actionCheck.Contains(keyword) ||
                        moduleCheck.Contains(keyword) ||
                        detailsCheck.Contains(keyword) ||
                        dateCheck.Contains(keyword))
                    {
                        result.ImportRow(row);
                    }
                }
                dgvUserLog.DataSource = result;
            }
            catch (Exception error)
            {
                MessageBox.Show("Something went wrong: " + error.Message);
            }
        }

        private void txtActivityLogSearch_TextChanged(object sender, EventArgs e)
        {
            StartSearchTimer(ActivityLogSearch);

        }
        private void ActivityLogSearch()
        {
            try
            {
                string keyword = txtActivityLogSearch.Text.Trim().ToLower();
                keyword = keyword.Replace(" ", "").Replace(",", "");
                DataTable all = LogRepository.GetActivityLogs(null);
                DataTable result = all.Clone();
                foreach (DataRow row in all.Rows)
                {
                    string action = row["Action"].ToString();
                    string module = row["Module"].ToString();
                    string description = row["Description"].ToString();
                    DateTime date = Convert.ToDateTime(row["LogDate"]);
                    string dateText = date.ToString("dd/MM/yyyy h:mm tt");
                    string actionCheck = action.ToLower().Replace(" ", "").Replace(",", "");
                    string moduleCheck = module.ToLower().Replace(" ", "").Replace(",", "");
                    string descriptionCheck = description.ToLower().Replace(" ", "").Replace(",", "");
                    string dateCheck = dateText.ToLower().Replace(" ", "").Replace(",", "");
                    if (keyword == "" ||
                        actionCheck.Contains(keyword) ||
                        moduleCheck.Contains(keyword) ||
                        descriptionCheck.Contains(keyword) ||
                        dateCheck.Contains(keyword))
                    {
                        result.ImportRow(row);
                    }
                }
                dgvActivityLog.DataSource = result;
            }
            catch (Exception error)
            {
                MessageBox.Show("Something went wrong: " + error.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
    
