using System;
using System.ComponentModel;
using System.Windows.Forms;
using GymMembershipSystem.Models;
using GymMembershipSystem.Services;
using GymMembershipSystem.Services.Interfaces;

namespace GymMembershipSystem.Forms.Plans
{
    public partial class PlanEditDialog : Form
    {
        private readonly IPlanService _planService;
        private readonly Plan? _existingPlan;

        public PlanEditDialog(Plan? existingPlan = null, IPlanService? planService = null)
        {
            InitializeComponent();
            _planService = planService ?? new PlanService();
            _existingPlan = existingPlan;

            if (_existingPlan != null)
            {
                lblDialogTitle.Text = $"Edit Plan #{_existingPlan.Id}";
                txtPlanName.Text = _existingPlan.Name;
                numDurationDays.Value = Math.Clamp(_existingPlan.DurationInDays, numDurationDays.Minimum, numDurationDays.Maximum);
                numPrice.Value = Math.Clamp(_existingPlan.Price, numPrice.Minimum, numPrice.Maximum);
                chkIsActive.Checked = _existingPlan.IsActive;
            }
            else
            {
                lblDialogTitle.Text = "Create Membership Plan";
            }
        }

        private void txtPlanName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPlanName.Text))
            {
                errorProvider.SetError(txtPlanName, "Plan name is required.");
            }
            else
            {
                errorProvider.SetError(txtPlanName, string.Empty);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lblErrorMessage.Visible = false;

            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }

            var name = txtPlanName.Text.Trim();
            var duration = (int)numDurationDays.Value;
            var price = numPrice.Value;
            var isActive = chkIsActive.Checked;

            if (_existingPlan == null)
            {
                var result = _planService.CreatePlan(name, duration, price);
                if (result.IsFailure)
                {
                    lblErrorMessage.Text = result.Error;
                    lblErrorMessage.Visible = true;
                    return;
                }
            }
            else
            {
                var result = _planService.UpdatePlan(_existingPlan.Id, name, duration, price, isActive);
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
