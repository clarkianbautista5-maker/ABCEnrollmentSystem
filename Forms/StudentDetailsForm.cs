using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ABCEnrollmentSystem.Forms
{
    public partial class StudentDetailsForm : Form
    {
        private IRepository<Student> _repo;
        private Student _student;
        public StudentDetailsForm(IRepository<Student> repo, Student student)
        {
            InitializeComponent();
            _repo = repo;
            _student = student;

            txtStudentId.ReadOnly = true;

            try
            {
                if (_student != null)
                {
                    txtStudentId.Text = _student.StudentId;
                    txtFirstName.Text = _student.FirstName;
                    txtMiddleName.Text = _student.MiddleName;
                    txtLastName.Text = _student.LastName;
                    txtHouseNo.Text = _student.HouseNo;
                    txtStreet.Text = _student.Street;
                    txtMunicipality.Text = _student.Municipality;
                    txtProvince.Text = _student.Province;
                    txtZipCode.Text = _student.ZipCode;
                    dtpBirthDate.Value = _student.DateOfBirth;
                    cboGender.SelectedItem = _student.Gender;
                    txtMobile.Text = _student.Mobile;
                    txtEmail.Text = _student.Email;
                    txtLandline.Text = _student.Landline;
                    txtGuardianName.Text = _student.GuardianName;
                    txtGuardianMobile.Text = _student.GuardianMobile;
                    txtGuardianAddress.Text = _student.GuardianAddress;
                    txtGuardianLandline.Text = _student.GuardianLandline;
                }
                else
                {
                    txtStudentId.Text = MakeNextStudentId(); 
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
                Student s = GetStudent();
                if (_student == null)
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
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool ValidateInput()
        {
            //student
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

            //loc
            if (string.IsNullOrWhiteSpace(txtHouseNo.Text))
            {
                MessageBox.Show("House No. is required.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHouseNo.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtStreet.Text))
            {
                MessageBox.Show("Street is required.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStreet.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMunicipality.Text))
            {
                MessageBox.Show("Municipality is required.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMunicipality.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtProvince.Text))
            {
                MessageBox.Show("Province is required.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProvince.Focus();
                return false;
            }
            string zipCode = txtZipCode.Text.Trim();
            if (zipCode.Length != 4 || zipCode.Trim("0123456789".ToCharArray()) != "")
            {
                MessageBox.Show("Zip Code must be exactly 4 digits.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtZipCode.Focus();
                return false;
            }

            //dob gender
            if (dtpBirthDate.Value > DateTime.Now)
            {
                MessageBox.Show("Date of Birth cannot be in the future.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpBirthDate.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cboGender.Text))
            {
                MessageBox.Show("Gender is required.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboGender.Focus();
                return false;
            }

            //mob email landline
            string mobile = txtMobile.Text.Trim();
            if (mobile != "" && (mobile.Length != 11 || !mobile.StartsWith("09") || mobile.Trim("0123456789".ToCharArray()) != ""))
            {
                MessageBox.Show("Mobile No. must be 11 digits and start with 09 (example: 09171234567).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMobile.Focus();
                return false;
            }
            string email = txtEmail.Text.Trim();
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email is required.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }
            int at = email.IndexOf('@');
            int dot = email.LastIndexOf('.');
            if (at < 1 || dot < at + 2 || dot == email.Length - 1)
            {
                MessageBox.Show("Email must look like name@example.com.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }
            string landline = txtLandline.Text.Trim();
            if (landline != "" && (landline.Length != 10 || landline.Trim("0123456789".ToCharArray()) != ""))
            {
                MessageBox.Show("Landline No. must be 10 digits (example: 0212345678).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLandline.Focus();
                return false;
            }

            //Guardian
            if (string.IsNullOrWhiteSpace(txtGuardianName.Text))
            {
                MessageBox.Show("Guardian Name is required.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGuardianName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtGuardianAddress.Text))
            {
                MessageBox.Show("Guardian Address is required.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGuardianAddress.Focus();
                return false;
            }
            string guardianMobile = txtGuardianMobile.Text.Trim();
            if (guardianMobile != "" && (guardianMobile.Length != 11 || !guardianMobile.StartsWith("09") || guardianMobile.Trim("0123456789".ToCharArray()) != ""))
            {
                MessageBox.Show("Guardian Mobile must be 11 digits and start with 09 (example: 09171234567).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGuardianMobile.Focus();
                return false;
            }
            string guardianLandline = txtGuardianLandline.Text.Trim();
            if (guardianLandline != "" && (guardianLandline.Length != 10 || guardianLandline.Trim("0123456789".ToCharArray()) != ""))
            {
                MessageBox.Show("Guardian Landline must be 10 digits (example: 0212345678).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGuardianLandline.Focus();
                return false;
            }

            return true;
        }

        private Student GetStudent()
        {
            Student s = new Student();
            s.StudentId = txtStudentId.Text.Trim();
            s.FirstName = txtFirstName.Text.Trim();
            s.MiddleName = txtMiddleName.Text.Trim();
            s.LastName = txtLastName.Text.Trim();

            s.HouseNo = txtHouseNo.Text.Trim();
            s.Street = txtStreet.Text.Trim();
            s.Municipality = txtMunicipality.Text.Trim();
            s.Province = txtProvince.Text.Trim();
            s.ZipCode = txtZipCode.Text.Trim();

            s.DateOfBirth = dtpBirthDate.Value;
            s.Gender = cboGender.SelectedItem?.ToString();
            
            s.Mobile = txtMobile.Text.Trim();
            s.Email = txtEmail.Text.Trim();
            s.Landline = txtLandline.Text.Trim();

            s.GuardianName = txtGuardianName.Text.Trim();
            s.GuardianMobile = txtGuardianMobile.Text.Trim();
            s.GuardianAddress = txtGuardianAddress.Text.Trim();
            s.GuardianLandline = txtGuardianLandline.Text.Trim();

            return s;
        }

        private string MakeNextStudentId()
        {
            string prefix = "02000" + DateTime.Now.ToString("yy");   
            int highest = 0; 

            foreach (Student s in _repo.GetAll())
            {
                if (s.StudentId.StartsWith(prefix))   
                {
                    string numberPart = s.StudentId.Substring(prefix.Length);   
                    int number = 0;
                    try
                    {
                        number = int.Parse(numberPart);
                    }
                    catch (FormatException)
                    {
                        number = 0; 
                    }

                    if (number > highest)
                    {
                        highest = number;
                    }
                }
            }

            return prefix + (highest + 1).ToString("0000"); 
        }
    }
}
