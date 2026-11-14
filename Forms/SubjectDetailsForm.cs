using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ABCEnrollmentSystem.Forms
{
    public partial class SubjectDetailsForm : Form
    {
        private IRepository<Subject> _repo;
        private IRepository<Teacher> _teacherRepo;
        private Subject _subject;
        public SubjectDetailsForm(IRepository<Subject> repo, IRepository<Teacher> teacherRepo, Subject subject)
        {
            InitializeComponent();
            _repo = repo;
            _teacherRepo = teacherRepo;
            _subject = subject;

            try
            {
                cboTeacher.DataSource = _teacherRepo.GetAll();
                if (_subject != null)
                {
                    txtSubjectCode.Text = _subject.SubjectCode;
                    txtSubjectName.Text = _subject.SubjectName;
                    txtDescription.Text = _subject.Description;
                    nudUnits.Value = _subject.Units;
                    cboTeacher.SelectedItem = _subject.TeacherId;
                    txtSubjectCode.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) //false if valid //true if invalid
            {
                return;
            }
            try
            {
                Subject s = GetSubject();
                if (_subject == null)
                {
                    _repo.Add(s);
                }
                else
                {
                    _repo.Update(s);
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (DuplicateRecordException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (RecordNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool ValidateInput()
        {
            if(string.IsNullOrWhiteSpace(txtSubjectCode.Text))
            {
                MessageBox.Show("Subject Code is required.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubjectCode.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSubjectName.Text))
            {
                MessageBox.Show("Subject Name is required.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubjectName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Description is required.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescription.Focus();
                return false;
            }
            if (nudUnits.Value <= 0)
            {
                MessageBox.Show("Units must be a positive number.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudUnits.Focus();   
                return false;
            }
            if (cboTeacher.SelectedItem == null)
            {
                MessageBox.Show("Teacher is required.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true; 
        }

        private Subject GetSubject()
        {
            Subject s = new Subject();
            s.SubjectCode = txtSubjectCode.Text.Trim();
            s.SubjectName = txtSubjectName.Text.Trim();
            s.Description = txtDescription.Text.Trim();
            s.Units = (int)nudUnits.Value;
            s.TeacherId = ((Teacher)cboTeacher.SelectedItem).TeacherId;
            return s;
        }
    }
}
