using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ABCEnrollmentSystem.Forms
{
    public partial class SectionDetailsForm : Form
    {
        private IRepository<Section> _repo;
        private Section _section;

        public SectionDetailsForm(IRepository<Section> repo, Section section)
        {
            InitializeComponent();
            _repo = repo;
            _section = section;

            if (_section != null)
            {
                txtSectionCode.Text = _section.SectionCode;
                txtSectionName.Text = _section.SectionName;
                txtDescription.Text = _section.Description;
                txtSectionCode.ReadOnly = true;
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
                Section s = GetSection();
                if (_section == null)
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
            if (string.IsNullOrWhiteSpace(txtSectionCode.Text))
            {
                MessageBox.Show("Section code is required.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSectionCode.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSectionName.Text))
            {
                MessageBox.Show("Section name is required.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSectionName.Focus();
                return false;
            }
            return true;
        }

        private Section GetSection()
        {
            Section s = new Section();
            s.SectionCode = txtSectionCode.Text.Trim();
            s.SectionName = txtSectionName.Text.Trim();
            s.Description = txtDescription.Text.Trim();
            return s;
        }
    }
}
