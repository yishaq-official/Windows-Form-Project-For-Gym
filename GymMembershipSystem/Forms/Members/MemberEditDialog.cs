using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using GymMembershipSystem.Models;
using GymMembershipSystem.Services;
using GymMembershipSystem.Services.Interfaces;

namespace GymMembershipSystem.Forms.Members
{
    public partial class MemberEditDialog : Form
    {
        private readonly IMemberService _memberService;
        private readonly Member? _existingMember;

        public Member? SavedMember { get; private set; }

        public MemberEditDialog(Member? existingMember = null, IMemberService? memberService = null)
        {
            InitializeComponent();
            _memberService = memberService ?? new MemberService();
            _existingMember = existingMember;

            // Populate Genders
            cboGender.DataSource = Enum.GetValues(typeof(Gender));

            dtpDateOfBirth.MaxDate = DateTime.Today;

            if (_existingMember != null)
            {
                lblDialogTitle.Text = $"Edit Member #{_existingMember.Id:D4}";
                txtFullName.Text = _existingMember.FullName;
                cboGender.SelectedItem = _existingMember.Gender;
                dtpDateOfBirth.Value = _existingMember.DateOfBirth;
                txtPhone.Text = _existingMember.Phone;
                txtEmail.Text = _existingMember.Email;
                txtAddress.Text = _existingMember.Address;
                dtpJoinDate.Value = _existingMember.JoinDate;
                chkIsActive.Checked = _existingMember.IsActive;
            }
            else
            {
                lblDialogTitle.Text = "Register New Member";
                cboGender.SelectedItem = Gender.Male;
                dtpDateOfBirth.Value = DateTime.Today.AddYears(-25);
                dtpJoinDate.Value = DateTime.Today;
            }
        }

        private void txtFullName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
                errorProvider.SetError(txtFullName, "Full name is required.");
            else if (txtFullName.Text.Trim().Length < 2)
                errorProvider.SetError(txtFullName, "Full name must be at least 2 characters.");
            else
                errorProvider.SetError(txtFullName, string.Empty);
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            var phone = txtPhone.Text.Trim();
            if (string.IsNullOrWhiteSpace(phone))
                errorProvider.SetError(txtPhone, "Phone number is required.");
            else if (!Regex.IsMatch(phone, @"^[0-9\+\-\(\)\s]{7,25}$"))
                errorProvider.SetError(txtPhone, "Please enter a valid phone number.");
            else
                errorProvider.SetError(txtPhone, string.Empty);
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            var email = txtEmail.Text.Trim();
            if (string.IsNullOrWhiteSpace(email))
                errorProvider.SetError(txtEmail, "Email address is required.");
            else if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase))
                errorProvider.SetError(txtEmail, "Please enter a valid email address format.");
            else
                errorProvider.SetError(txtEmail, string.Empty);
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
                errorProvider.SetError(txtAddress, "Residential address is required.");
            else
                errorProvider.SetError(txtAddress, string.Empty);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lblErrorMessage.Visible = false;

            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }

            var name = txtFullName.Text.Trim();
            var gender = (Gender)cboGender.SelectedItem!;
            var dob = dtpDateOfBirth.Value.Date;
            var phone = txtPhone.Text.Trim();
            var email = txtEmail.Text.Trim();
            var address = txtAddress.Text.Trim();
            var joinDate = dtpJoinDate.Value.Date;
            var isActive = chkIsActive.Checked;

            if (_existingMember == null)
            {
                var result = _memberService.RegisterMember(name, gender, dob, phone, email, address, joinDate);
                if (result.IsFailure)
                {
                    lblErrorMessage.Text = result.Error;
                    lblErrorMessage.Visible = true;
                    return;
                }
                SavedMember = result.Value;
            }
            else
            {
                var result = _memberService.UpdateMember(_existingMember.Id, name, gender, dob, phone, email, address, isActive);
                if (result.IsFailure)
                {
                    lblErrorMessage.Text = result.Error;
                    lblErrorMessage.Visible = true;
                    return;
                }
                SavedMember = _memberService.GetMemberById(_existingMember.Id);
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
