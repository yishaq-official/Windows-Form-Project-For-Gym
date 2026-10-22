using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GymMembershipSystem.Models;
using GymMembershipSystem.Services;
using GymMembershipSystem.Services.Interfaces;

namespace GymMembershipSystem.Forms.Payments
{
    public partial class RecordPaymentDialog : Form
    {
        private readonly IPaymentService _paymentService;
        private readonly IMemberService _memberService;
        private readonly int? _preSelectedMemberId;

        private class MemberComboItem
        {
            public Member Member { get; }
            public decimal Balance { get; }

            public MemberComboItem(Member member, decimal balance)
            {
                Member = member;
                Balance = balance;
            }

            public override string ToString()
            {
                var balStr = Balance > 0 ? $"Due: {Balance:C2}" : "Current";
                return $"{Member.FullName} (#{Member.Id}) - [{balStr}]";
            }
        }

        public RecordPaymentDialog(
            int? preSelectedMemberId = null,
            IPaymentService? paymentService = null,
            IMemberService? memberService = null)
        {
            InitializeComponent();
            _paymentService = paymentService ?? new PaymentService();
            _memberService = memberService ?? new MemberService();
            _preSelectedMemberId = preSelectedMemberId;

            PopulatePaymentMethods();
            PopulateMembers();
            dtpPaymentDate.Value = DateTime.Today;
        }

        private void PopulatePaymentMethods()
        {
            cboPaymentMethod.Items.Clear();
            foreach (var method in Enum.GetValues<PaymentMethod>())
            {
                cboPaymentMethod.Items.Add(method);
            }

            if (cboPaymentMethod.Items.Count > 0)
            {
                cboPaymentMethod.SelectedIndex = 0;
            }
        }

        private void PopulateMembers()
        {
            cboMember.SelectedIndexChanged -= cboMember_SelectedIndexChanged;
            cboMember.Items.Clear();

            var members = _memberService.GetMembers();
            int selectedIndex = -1;

            for (int i = 0; i < members.Count; i++)
            {
                var m = members[i];
                decimal balance = _paymentService.GetMemberOutstandingBalance(m.Id);
                cboMember.Items.Add(new MemberComboItem(m, balance));

                if (_preSelectedMemberId.HasValue && m.Id == _preSelectedMemberId.Value)
                {
                    selectedIndex = i;
                }
            }

            cboMember.SelectedIndexChanged += cboMember_SelectedIndexChanged;

            if (selectedIndex >= 0)
            {
                cboMember.SelectedIndex = selectedIndex;
            }
            else if (cboMember.Items.Count > 0)
            {
                cboMember.SelectedIndex = 0;
            }
            else
            {
                btnSave.Enabled = false;
                lblErrorMessage.Text = "No active members found.";
                lblErrorMessage.Visible = true;
            }

            UpdateBalanceDisplay();
        }

        private void cboMember_SelectedIndexChanged(object? sender, EventArgs e)
        {
            UpdateBalanceDisplay();
        }

        private void UpdateBalanceDisplay()
        {
            if (cboMember.SelectedItem is not MemberComboItem item)
            {
                lblBalanceDisplay.Text = "No member selected";
                lblBalanceDisplay.ForeColor = Color.FromArgb(100, 116, 139);
                lblBalanceSubtitle.Text = string.Empty;
                return;
            }

            decimal balance = _paymentService.GetMemberOutstandingBalance(item.Member.Id);
            decimal billed = _paymentService.GetMemberTotalBilled(item.Member.Id);
            decimal paid = _paymentService.GetMemberTotalPaid(item.Member.Id);

            lblBalanceSubtitle.Text = $"Total Billed: {billed:C2}  |  Total Paid: {paid:C2}";

            if (balance > 0)
            {
                lblBalanceDisplay.Text = $"Outstanding Balance: {balance:C2}";
                lblBalanceDisplay.ForeColor = Color.FromArgb(220, 38, 38);

                // Auto-fill amount due up to max allowable
                numAmount.Value = Math.Clamp(balance, numAmount.Minimum, numAmount.Maximum);
            }
            else
            {
                lblBalanceDisplay.Text = "No Outstanding Balance (Account Current)";
                lblBalanceDisplay.ForeColor = Color.FromArgb(5, 150, 105);
            }
        }

        private void cboMember_Validating(object sender, CancelEventArgs e)
        {
            if (cboMember.SelectedItem == null)
            {
                errorProvider.SetError(cboMember, "Member selection is required.");
            }
            else
            {
                errorProvider.SetError(cboMember, string.Empty);
            }
        }

        private void numAmount_Validating(object sender, CancelEventArgs e)
        {
            if (numAmount.Value <= 0)
            {
                errorProvider.SetError(numAmount, "Payment amount must be greater than zero (Rule 9).");
            }
            else
            {
                errorProvider.SetError(numAmount, string.Empty);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lblErrorMessage.Visible = false;

            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }

            if (cboMember.SelectedItem is not MemberComboItem item)
            {
                lblErrorMessage.Text = "Please select a member.";
                lblErrorMessage.Visible = true;
                return;
            }

            var method = (PaymentMethod)(cboPaymentMethod.SelectedItem ?? PaymentMethod.Cash);
            var amount = numAmount.Value;
            var paymentDate = dtpPaymentDate.Value;
            var notes = txtNotes.Text.Trim();

            var result = _paymentService.RecordPayment(item.Member.Id, amount, method, paymentDate, notes);
            if (result.IsFailure)
            {
                lblErrorMessage.Text = result.Error;
                lblErrorMessage.Visible = true;
                return;
            }

            MessageBox.Show(
                $"Payment of {amount:C2} via {method} was successfully recorded for {item.Member.FullName}.",
                "Payment Recorded",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
