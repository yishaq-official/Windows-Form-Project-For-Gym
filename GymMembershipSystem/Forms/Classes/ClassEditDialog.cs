using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GymMembershipSystem.Models;
using GymMembershipSystem.Services;
using GymMembershipSystem.Services.Interfaces;

namespace GymMembershipSystem.Forms.Classes
{
    public partial class ClassEditDialog : Form
    {
        private readonly IClassService _classService;
        private readonly ITrainerService _trainerService;
        private readonly GymClass? _existingClass;
        private readonly int _activeBookingsCount;

        private class TrainerComboItem
        {
            public int Id { get; }
            public string Name { get; }
            public string Specialty { get; }

            public TrainerComboItem(int id, string name, string specialty)
            {
                Id = id;
                Name = name;
                Specialty = specialty;
            }

            public override string ToString() => $"{Name} ({Specialty})";
        }

        public ClassEditDialog(
            GymClass? existingClass = null,
            IClassService? classService = null,
            ITrainerService? trainerService = null)
        {
            InitializeComponent();
            _classService = classService ?? new ClassService();
            _trainerService = trainerService ?? new TrainerService();
            _existingClass = existingClass;

            PopulateDaysOfWeek();
            PopulateTrainers();

            if (_existingClass != null)
            {
                lblDialogTitle.Text = $"Edit Class #{_existingClass.Id}";
                txtClassName.Text = _existingClass.Name;
                cboDayOfWeek.SelectedItem = _existingClass.DayOfWeek;
                dtpStartTime.Value = DateTime.Today.Add(_existingClass.StartTime);
                numDuration.Value = Math.Clamp(_existingClass.DurationMinutes, numDuration.Minimum, numDuration.Maximum);

                // Enforce Business Rule 6 dynamically
                _activeBookingsCount = _classService.GetActiveBookingCount(_existingClass.Id);
                numCapacity.Minimum = Math.Max(1, _activeBookingsCount);
                numCapacity.Value = Math.Max(numCapacity.Minimum, _existingClass.Capacity);
                chkIsActive.Checked = _existingClass.IsActive;

                lblCapacityNotice.Text = $"ℹ️ Active bookings: {_activeBookingsCount}. Minimum allowed capacity is {_activeBookingsCount}.";
                lblCapacityNotice.ForeColor = _activeBookingsCount > 0 ? Color.FromArgb(220, 38, 38) : Color.FromArgb(71, 85, 105);

                SelectTrainer(_existingClass.TrainerId);
            }
            else
            {
                lblDialogTitle.Text = "Schedule New Fitness Class";
                cboDayOfWeek.SelectedItem = DayOfWeek.Monday;
                dtpStartTime.Value = DateTime.Today.AddHours(9);
                numDuration.Value = 60;
                numCapacity.Value = 20;
                chkIsActive.Checked = true;
                _activeBookingsCount = 0;
            }
        }

        private void PopulateDaysOfWeek()
        {
            cboDayOfWeek.Items.Clear();
            var days = new[]
            {
                DayOfWeek.Monday,
                DayOfWeek.Tuesday,
                DayOfWeek.Wednesday,
                DayOfWeek.Thursday,
                DayOfWeek.Friday,
                DayOfWeek.Saturday,
                DayOfWeek.Sunday
            };

            foreach (var day in days)
            {
                cboDayOfWeek.Items.Add(day);
            }
        }

        private void PopulateTrainers()
        {
            cboTrainer.Items.Clear();
            var trainers = _trainerService.GetAllTrainers(includeInactive: false);

            foreach (var trainer in trainers)
            {
                cboTrainer.Items.Add(new TrainerComboItem(trainer.Id, trainer.FullName, trainer.Specialty));
            }

            if (cboTrainer.Items.Count > 0)
            {
                cboTrainer.SelectedIndex = 0;
            }
        }

        private void SelectTrainer(int trainerId)
        {
            for (int i = 0; i < cboTrainer.Items.Count; i++)
            {
                if (cboTrainer.Items[i] is TrainerComboItem item && item.Id == trainerId)
                {
                    cboTrainer.SelectedIndex = i;
                    return;
                }
            }
        }

        private void txtClassName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClassName.Text))
            {
                errorProvider.SetError(txtClassName, "Class name is required.");
            }
            else
            {
                errorProvider.SetError(txtClassName, string.Empty);
            }
        }

        private void cboTrainer_Validating(object sender, CancelEventArgs e)
        {
            if (cboTrainer.SelectedItem == null)
            {
                errorProvider.SetError(cboTrainer, "A designated trainer is required.");
            }
            else
            {
                errorProvider.SetError(cboTrainer, string.Empty);
            }
        }

        private void numCapacity_Validating(object sender, CancelEventArgs e)
        {
            if (_existingClass != null && (int)numCapacity.Value < _activeBookingsCount)
            {
                errorProvider.SetError(numCapacity, $"Capacity cannot be less than {_activeBookingsCount} active bookings (Rule 6).");
            }
            else
            {
                errorProvider.SetError(numCapacity, string.Empty);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lblErrorMessage.Visible = false;

            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }

            var name = txtClassName.Text.Trim();
            if (cboTrainer.SelectedItem is not TrainerComboItem trainerItem)
            {
                lblErrorMessage.Text = "Please select an assigned trainer.";
                lblErrorMessage.Visible = true;
                return;
            }

            var day = (DayOfWeek)(cboDayOfWeek.SelectedItem ?? DayOfWeek.Monday);
            var startTime = dtpStartTime.Value.TimeOfDay;
            var duration = (int)numDuration.Value;
            var capacity = (int)numCapacity.Value;
            var isActive = chkIsActive.Checked;

            if (_existingClass == null)
            {
                var result = _classService.CreateClass(name, trainerItem.Id, day, startTime, duration, capacity);
                if (result.IsFailure)
                {
                    lblErrorMessage.Text = result.Error;
                    lblErrorMessage.Visible = true;
                    return;
                }
            }
            else
            {
                var result = _classService.UpdateClass(_existingClass.Id, name, trainerItem.Id, day, startTime, duration, capacity, isActive);
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
