using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GymMembershipSystem.Common;
using GymMembershipSystem.Models;
using GymMembershipSystem.Services;
using GymMembershipSystem.Services.Interfaces;

namespace GymMembershipSystem.Forms.Trainers
{
    public partial class TrainersViewControl : UserControl
    {
        private readonly ITrainerService _trainerService;

        public TrainersViewControl(ITrainerService? trainerService = null)
        {
            InitializeComponent();
            _trainerService = trainerService ?? new TrainerService();

            SubscribeEvents();
            LoadTrainers();
        }

        #region Event-Driven Architecture Subscriptions

        private void SubscribeEvents()
        {
            AppEvents.TrainerChanged += OnTrainerChanged;
            AppEvents.SubscriptionChanged += OnSubscriptionChanged;
            AppEvents.GymClassChanged += OnGymClassChanged;
            AppEvents.DataReset += OnDataReset;
        }

        private void UnsubscribeEvents()
        {
            AppEvents.TrainerChanged -= OnTrainerChanged;
            AppEvents.SubscriptionChanged -= OnSubscriptionChanged;
            AppEvents.GymClassChanged -= OnGymClassChanged;
            AppEvents.DataReset -= OnDataReset;
        }

        private void OnTrainerChanged(Trainer trainer, ChangeType changeType)
        {
            RunOnUiThread(LoadTrainers);
        }

        private void OnSubscriptionChanged(Subscription subscription, ChangeType changeType)
        {
            RunOnUiThread(LoadTrainers);
        }

        private void OnGymClassChanged(GymClass gymClass, ChangeType changeType)
        {
            RunOnUiThread(LoadTrainers);
        }

        private void OnDataReset()
        {
            RunOnUiThread(LoadTrainers);
        }

        private void RunOnUiThread(Action action)
        {
            if (IsDisposed || Disposing) return;
            if (InvokeRequired)
            {
                try { BeginInvoke(action); } catch (ObjectDisposedException) { }
            }
            else
            {
                action();
            }
        }

        #endregion

        #region Data Population & Search

        public void LoadTrainers()
        {
            dgvTrainers.Rows.Clear();
            var trainers = _trainerService.GetAllTrainers(chkIncludeInactive.Checked, txtSearch.Text);

            foreach (var trainer in trainers)
            {
                int assignedMembers = _trainerService.GetAssignedMemberCount(trainer.Id);
                int scheduledClasses = _trainerService.GetScheduledClassCount(trainer.Id);
                var statusText = trainer.IsActive ? "Active" : "Deactivated";

                int rowIndex = dgvTrainers.Rows.Add(
                    trainer.Id,
                    trainer.FullName,
                    trainer.Specialty,
                    trainer.Phone,
                    assignedMembers,
                    scheduledClasses,
                    statusText);

                var row = dgvTrainers.Rows[rowIndex];
                row.Tag = trainer;

                if (!trainer.IsActive)
                {
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(148, 163, 184);
                    row.DefaultCellStyle.Font = new Font(dgvTrainers.Font, FontStyle.Italic);
                }
            }

            UpdateButtonStates();
        }

        private Trainer? GetSelectedTrainer()
        {
            if (dgvTrainers.SelectedRows.Count == 0) return null;
            return dgvTrainers.SelectedRows[0].Tag as Trainer;
        }

        private void UpdateButtonStates()
        {
            var trainer = GetSelectedTrainer();
            bool hasSelection = trainer != null;

            btnEditTrainer.Enabled = hasSelection;
            btnToggleActive.Enabled = hasSelection;

            if (trainer != null)
            {
                if (trainer.IsActive)
                {
                    btnToggleActive.Text = "⚡ Deactivate";
                    btnToggleActive.ForeColor = Color.FromArgb(220, 38, 38);
                }
                else
                {
                    btnToggleActive.Text = "✅ Reactivate";
                    btnToggleActive.ForeColor = Color.FromArgb(5, 150, 105);
                }
            }
        }

        private void dgvTrainers_SelectionChanged(object sender, EventArgs e)
        {
            UpdateButtonStates();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadTrainers();
        }

        private void chkIncludeInactive_CheckedChanged(object sender, EventArgs e)
        {
            LoadTrainers();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadTrainers();
        }

        #endregion

        #region Action Handlers

        private void btnAddTrainer_Click(object sender, EventArgs e)
        {
            using var dialog = new TrainerEditDialog(null, _trainerService);
            if (dialog.ShowDialog(FindForm()) == DialogResult.OK)
            {
                LoadTrainers();
            }
        }

        private void btnEditTrainer_Click(object sender, EventArgs e)
        {
            var trainer = GetSelectedTrainer();
            if (trainer == null) return;

            using var dialog = new TrainerEditDialog(trainer, _trainerService);
            if (dialog.ShowDialog(FindForm()) == DialogResult.OK)
            {
                LoadTrainers();
            }
        }

        private void dgvTrainers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnEditTrainer_Click(sender, EventArgs.Empty);
            }
        }

        private void btnToggleActive_Click(object sender, EventArgs e)
        {
            var trainer = GetSelectedTrainer();
            if (trainer == null) return;

            if (trainer.IsActive)
            {
                var confirm = MessageBox.Show(
                    $"Are you sure you want to deactivate trainer '{trainer.FullName}'?\n\nDeactivated trainers will remain in historical records but cannot be newly assigned to members or classes.",
                    "Confirm Trainer Deactivation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    var result = _trainerService.DeleteOrDeactivateTrainer(trainer.Id);
                    if (result.IsFailure)
                    {
                        MessageBox.Show(result.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        LoadTrainers();
                    }
                }
            }
            else
            {
                var confirm = MessageBox.Show(
                    $"Reactivate trainer '{trainer.FullName}' for new member and class assignments?",
                    "Confirm Reactivation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    var result = _trainerService.UpdateTrainer(trainer.Id, trainer.FullName, trainer.Specialty, trainer.Phone, true);
                    if (result.IsFailure)
                    {
                        MessageBox.Show(result.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        LoadTrainers();
                    }
                }
            }
        }

        #endregion
    }
}
