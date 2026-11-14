using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ABCEnrollmentSystem.Forms
{
    public partial class TeacherDetailsForm : Form
    {
        private IRepository<Teacher> _repo;
        private Teacher _teacher;
        public TeacherDetailsForm(IRepository<Teacher> repo, Teacher teacher)
        {
            InitializeComponent();
            _repo = repo;
            _teacher = teacher;

            if (_teacher != null)
            {
                txtTeacherId.Text = _teacher.TeacherId;
                txtFirstName.Text = _teacher.FirstName;
                txtMiddleName.Text = _teacher.MiddleName;
                txtLastName.Text = _teacher.LastName;
                txtTeacherId.ReadOnly = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!ValidateInput()) //false if valid //true if invalid
            {
                return;
            }

            try
            {
                Teacher t = GetTeacher();
                if (_teacher == null)
                {
                    _repo.Add(t);
                }
                else
                {
                    _repo.Update(t);
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

        public bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtTeacherId.Text))
            {
                MessageBox.Show("Teacher ID is required.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTeacherId.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("First Name is required.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Last Name is required.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return false;
            }
            return true;
        }
        public Teacher GetTeacher()
        {
            Teacher t = new Teacher();
            t.TeacherId = txtTeacherId.Text;
            t.FirstName = txtFirstName.Text;
            t.MiddleName = txtMiddleName.Text;
            t.LastName = txtLastName.Text;
            return t;
        }
    }
}
