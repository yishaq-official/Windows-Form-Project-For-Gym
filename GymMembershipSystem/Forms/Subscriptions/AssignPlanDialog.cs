using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GymMembershipSystem.Models;
using GymMembershipSystem.Services;
using GymMembershipSystem.Services.Interfaces;

namespace GymMembershipSystem.Forms.Subscriptions
{
    public partial class AssignPlanDialog : Form
    {
        private readonly Member _member;
        private readonly ISubscriptionService _subscriptionService;
        private readonly IPlanService _planService;
        private readonly ITrainerService _trainerService;

        public Subscription? CreatedSubscription { get; private set; }

        public AssignPlanDialog(
            Member member,
            ISubscriptionService? subscriptionService = null,
            IPlanService? planService = null,
            ITrainerService? trainerService = null)
        {
            InitializeComponent();
            _member = member ?? throw new ArgumentNullException(nameof(member));
            _subscriptionService = subscriptionService ?? new SubscriptionService();
            _planService = planService ?? new PlanService();
            _trainerService = trainerService ?? new TrainerService();

            PopulateMemberInfo();
            LoadDropdowns();
            UpdateCalculatedExpiry();
        }

        private void PopulateMemberInfo()
        {
            lblMemberName.Text = $"👤 {_member.FullName} (#{_member.Id:D4})";

            var currentSub = _subscriptionService.GetActiveSubscription(_member.Id);
            if (currentSub != null)
            {
                var plan = _planService.GetPlanById(currentSub.PlanId);
                lblCurrentStatus.Text = $"Current Plan: {plan?.Name ?? "Plan"} (Active until {currentSub.ExpiryDate:yyyy-MM-dd})";
                lblCurrentStatus.ForeColor = Color.FromArgb(5, 150, 105);

                // For seamless renewal, default start date to current expiry if it's in the future
                if (currentSub.ExpiryDate.Date >= DateTime.Today)
                {
                    dtpStartDate.Value = currentSub.ExpiryDate.Date;
                }
                else
                {
                    dtpStartDate.Value = DateTime.Today;
                }
            }
            else
            {
                var latestSub = _subscriptionService.GetLatestSubscription(_member.Id);
                if (latestSub != null)
                {
                    lblCurrentStatus.Text = $"Previous Plan: Expired on {latestSub.ExpiryDate:yyyy-MM-dd}";
                    lblCurrentStatus.ForeColor = Color.FromArgb(217, 119, 6);
                }
                else
                {
                    lblCurrentStatus.Text = "No previous subscription found.";
                    lblCurrentStatus.ForeColor = Color.FromArgb(100, 116, 139);
                }
                dtpStartDate.Value = DateTime.Today;
            }
        }

        private void LoadDropdowns()
        {
            // Load Plans
            var plans = _planService.GetAllPlans(includeInactive: false);
            cboPlan.DisplayMember = "DisplayText";
            cboPlan.ValueMember = "Plan";

            var planItems = plans.Select(p => new
            {
                DisplayText = $"{p.Name} — {p.DurationInDays} Days (${p.Price:F2})",
                Plan = p
            }).ToList();

            cboPlan.DataSource = planItems;
            if (cboPlan.Items.Count > 0)
            {
                cboPlan.SelectedIndex = 0;
            }

            // Load Trainers
            var trainers = _trainerService.GetAllTrainers(includeInactive: false);
            cboTrainer.Items.Clear();
            cboTrainer.Items.Add(new TrainerComboItem { Id = 0, DisplayName = "(None — No Personal Trainer)" });

            foreach (var trainer in trainers)
            {
                cboTrainer.Items.Add(new TrainerComboItem
                {
                    Id = trainer.Id,
                    DisplayName = $"{trainer.FullName} ({trainer.Specialty})"
                });
            }

            cboTrainer.SelectedIndex = 0;
        }

        private void UpdateCalculatedExpiry()
        {
            lblErrorMessage.Visible = false;

            if (cboPlan.SelectedItem == null)
            {
                lblCalculatedExpiry.Text = "Please select a plan";
                lblPrice.Text = "Price: $0.00";
                return;
            }

            dynamic selected = cboPlan.SelectedItem;
            Plan plan = selected.Plan;

            var startDate = dtpStartDate.Value.Date;
            var expiryDate = startDate.AddDays(plan.DurationInDays);

            lblCalculatedExpiry.Text = $"Calculated Expiry: {expiryDate:yyyy-MM-dd} ({plan.DurationInDays} days)";
            lblPrice.Text = $"Subscription Fee: ${plan.Price:F2}";
        }

        private void cboPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCalculatedExpiry();
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            UpdateCalculatedExpiry();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            lblErrorMessage.Visible = false;

            if (cboPlan.SelectedItem == null)
            {
                lblErrorMessage.Text = "Please select a membership plan.";
                lblErrorMessage.Visible = true;
                return;
            }

            dynamic selected = cboPlan.SelectedItem;
            Plan plan = selected.Plan;

            int? trainerId = null;
            if (cboTrainer.SelectedItem is TrainerComboItem trainerItem && trainerItem.Id > 0)
            {
                trainerId = trainerItem.Id;
            }

            var startDate = dtpStartDate.Value.Date;

            var result = _subscriptionService.AssignPlan(_member.Id, plan.Id, startDate, trainerId);

            if (result.IsFailure)
            {
                lblErrorMessage.Text = result.Error;
                lblErrorMessage.Visible = true;
                return;
            }

            CreatedSubscription = result.Value;

            MessageBox.Show(
                $"Membership plan '{plan.Name}' assigned to {_member.FullName}!\n\nDuration: {plan.DurationInDays} days\nExpiry Date: {result.Value.ExpiryDate:yyyy-MM-dd}\nAmount Due: ${plan.Price:F2}",
                "Subscription Confirmed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
            Close();
        }

        private class TrainerComboItem
        {
            public int Id { get; set; }
            public string DisplayName { get; set; } = string.Empty;

            public override string ToString() => DisplayName;
        }
    }
}
