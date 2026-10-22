using System;
using System.Drawing;
using System.Windows.Forms;
using GymMembershipSystem.Common;
using GymMembershipSystem.Models;
using GymMembershipSystem.Services;
using GymMembershipSystem.Services.Interfaces;

namespace GymMembershipSystem.Forms.Payments
{
    public partial class PaymentsViewControl : UserControl
    {
        private readonly IPaymentService _paymentService;
        private readonly IMemberService _memberService;

        private class MethodFilterItem
        {
            public PaymentMethod? Method { get; }
            public string Name { get; }

            public MethodFilterItem(PaymentMethod? method, string name)
            {
                Method = method;
                Name = name;
            }

            public override string ToString() => Name;
        }

        public PaymentsViewControl(
            IPaymentService? paymentService = null,
            IMemberService? memberService = null)
        {
            InitializeComponent();
            _paymentService = paymentService ?? new PaymentService();
            _memberService = memberService ?? new MemberService();

            SubscribeEvents();
            PopulateMethodFilter();
            SetDefaultDateRange();
            RefreshAll();
        }

        #region Event-Driven Architecture Subscriptions

        private void SubscribeEvents()
        {
            AppEvents.PaymentReceived += OnPaymentReceived;
            AppEvents.SubscriptionChanged += OnSubscriptionChanged;
            AppEvents.MemberChanged += OnMemberChanged;
            AppEvents.DataReset += OnDataReset;
        }

        private void UnsubscribeEvents()
        {
            AppEvents.PaymentReceived -= OnPaymentReceived;
            AppEvents.SubscriptionChanged -= OnSubscriptionChanged;
            AppEvents.MemberChanged -= OnMemberChanged;
            AppEvents.DataReset -= OnDataReset;
        }

        private void OnPaymentReceived(Payment payment) => RunOnUiThread(RefreshAll);
        private void OnSubscriptionChanged(Subscription subscription, ChangeType changeType) => RunOnUiThread(RefreshAll);
        private void OnMemberChanged(Member member, ChangeType changeType) => RunOnUiThread(RefreshAll);
        private void OnDataReset() => RunOnUiThread(RefreshAll);

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

        #region Filters & Population

        private void PopulateMethodFilter()
        {
            cboMethodFilter.SelectedIndexChanged -= FilterControl_Changed;
            cboMethodFilter.Items.Clear();
            cboMethodFilter.Items.Add(new MethodFilterItem(null, "All Methods"));

            foreach (var method in Enum.GetValues<PaymentMethod>())
            {
                cboMethodFilter.Items.Add(new MethodFilterItem(method, method.ToString()));
            }

            cboMethodFilter.SelectedIndex = 0;
            cboMethodFilter.SelectedIndexChanged += FilterControl_Changed;
        }

        private void SetDefaultDateRange()
        {
            dtpFrom.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpTo.Value = DateTime.Today;
        }

        public void RefreshAll()
        {
            RefreshMetrics();
            LoadPayments();
        }

        private void RefreshMetrics()
        {
            decimal monthlyRevenue = _paymentService.GetMonthlyRevenue();
            decimal lifetimeRevenue = _paymentService.GetTotalRevenue();
            decimal totalOutstanding = _paymentService.GetTotalOutstandingBalance();

            lblMonthVal.Text = monthlyRevenue.ToString("C2");
            lblLifetimeVal.Text = lifetimeRevenue.ToString("C2");
            lblOutstandingVal.Text = totalOutstanding.ToString("C2");

            lblOutstandingVal.ForeColor = totalOutstanding > 0 ? Color.FromArgb(185, 28, 28) : Color.FromArgb(5, 150, 105);
        }

        public void LoadPayments()
        {
            DateTime? fromDate = chkEnableDateFilter.Checked ? dtpFrom.Value.Date : null;
            DateTime? toDate = chkEnableDateFilter.Checked ? dtpTo.Value.Date : null;
            var selectedMethod = (cboMethodFilter.SelectedItem as MethodFilterItem)?.Method;

            dgvPayments.Rows.Clear();
            var payments = _paymentService.GetPayments(
                memberIdFilter: null,
                fromDate: fromDate,
                toDate: toDate,
                methodFilter: selectedMethod,
                searchQuery: txtSearch.Text);

            foreach (var p in payments)
            {
                var member = _memberService.GetMemberById(p.MemberId);
                var memberName = member != null ? $"{member.FullName} (#{member.Id})" : $"Member #{p.MemberId}";
                var dateStr = p.PaymentDate.ToString("yyyy-MM-dd");
                var amountStr = p.Amount.ToString("C2");

                int rowIndex = dgvPayments.Rows.Add(
                    p.Id,
                    dateStr,
                    memberName,
                    amountStr,
                    p.PaymentMethod.ToString(),
                    p.Notes);

                dgvPayments.Rows[rowIndex].Tag = p;
            }
        }

        private void FilterControl_Changed(object? sender, EventArgs e)
        {
            LoadPayments();
        }

        private void chkEnableDateFilter_CheckedChanged(object sender, EventArgs e)
        {
            dtpFrom.Enabled = chkEnableDateFilter.Checked;
            dtpTo.Enabled = chkEnableDateFilter.Checked;
            LoadPayments();
        }

        private void btnResetFilters_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            chkEnableDateFilter.Checked = false;
            cboMethodFilter.SelectedIndex = 0;
            LoadPayments();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshAll();
        }

        #endregion

        #region Actions

        private void btnRecordPayment_Click(object sender, EventArgs e)
        {
            using var dialog = new RecordPaymentDialog(null, _paymentService, _memberService);
            if (dialog.ShowDialog(FindForm()) == DialogResult.OK)
            {
                RefreshAll();
            }
        }

        #endregion
    }
}
