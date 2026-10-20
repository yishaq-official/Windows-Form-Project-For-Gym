using System;
using System.ComponentModel;
using System.Windows.Forms;
using GymMembershipSystem.Models;
using GymMembershipSystem.Services;
using GymMembershipSystem.Services.Interfaces;

namespace GymMembershipSystem.Forms.Trainers
{
    public partial class TrainerEditDialog : Form
    {
        private readonly ITrainerService _trainerService;
        private readonly Trainer? _existingTrainer;

        public TrainerEditDialog(Trainer? existingTrainer = null, ITrainerService? trainerService = null)
        {
            InitializeComponent();
            _trainerService = trainerService ?? new TrainerService();
            _existingTrainer = existingTrainer;

            if (_existingTrainer != null)
            {
                lblDialogTitle.Text = $"Edit Trainer #{_existingTrainer.Id}";
                txtFullName.Text = _existingTrainer.FullName;
                cboSpecialty.Text = _existingTrainer.Specialty;
                txtPhone.Text = _existingTrainer.Phone;
                chkIsActive.Checked = _existingTrainer.IsActive;
            }
            else
            {
                lblDialogTitle.Text = "Register Personal Trainer";
                cboSpecialty.SelectedIndex = 0;
            }
        }

        private void txtFullName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                errorProvider.SetError(txtFullName, "Trainer full name is required.");
            }
            else
            {
                errorProvider.SetError(txtFullName, string.Empty);
            }
        }

        private void cboSpecialty_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboSpecialty.Text))
            {
                errorProvider.SetError(cboSpecialty, "Specialty is required.");
            }
            else
            {
                errorProvider.SetError(cboSpecialty, string.Empty);
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                errorProvider.SetError(txtPhone, "Phone number is required.");
            }
            else
            {
                errorProvider.SetError(txtPhone, string.Empty);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lblErrorMessage.Visible = false;

            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }

            var name = txtFullName.Text.Trim();
            var specialty = cboSpecialty.Text.Trim();
            var phone = txtPhone.Text.Trim();
            var isActive = chkIsActive.Checked;

            if (_existingTrainer == null)
            {
                var result = _trainerService.CreateTrainer(name, specialty, phone);
                if (result.IsFailure)
                {
                    lblErrorMessage.Text = result.Error;
                    lblErrorMessage.Visible = true;
                    return;
                }
            }
            else
            {
                var result = _trainerService.UpdateTrainer(_existingTrainer.Id, name, specialty, phone, isActive);
                if (result.IsFailure)
                {
                    lblErrorMessage.Text = result.Error;
                    lblErrorMessage.Visible = true;
                    return;
                }
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
