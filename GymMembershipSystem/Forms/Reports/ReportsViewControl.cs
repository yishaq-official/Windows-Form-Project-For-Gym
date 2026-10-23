using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GymMembershipSystem.Common;
using GymMembershipSystem.Models;
using GymMembershipSystem.Services;
using GymMembershipSystem.Services.Interfaces;

namespace GymMembershipSystem.Forms.Reports
{
    public partial class ReportsViewControl : UserControl
    {
        private readonly IReportService _reportService;

        public ReportsViewControl(IReportService? reportService = null)
        {
            InitializeComponent();
            _reportService = reportService ?? new ReportService();

            SubscribeEvents();

            if (cboMemberFilter.Items.Count > 0)
            {
                cboMemberFilter.SelectedIndex = 0;
            }

            RefreshAll();
        }

        #region Event-Driven Real-Time Architecture

        private void SubscribeEvents()
        {
            AppEvents.MemberChanged += OnMemberChanged;
            AppEvents.SubscriptionChanged += OnSubscriptionChanged;
            AppEvents.PaymentReceived += OnPaymentReceived;
            AppEvents.BookingChanged += OnBookingChanged;
            AppEvents.GymClassChanged += OnGymClassChanged;
            AppEvents.DataReset += OnDataReset;
        }

        private void UnsubscribeEvents()
        {
            AppEvents.MemberChanged -= OnMemberChanged;
            AppEvents.SubscriptionChanged -= OnSubscriptionChanged;
            AppEvents.PaymentReceived -= OnPaymentReceived;
            AppEvents.BookingChanged -= OnBookingChanged;
            AppEvents.GymClassChanged -= OnGymClassChanged;
            AppEvents.DataReset -= OnDataReset;
        }

        private void OnMemberChanged(Member member, ChangeType changeType) => RunOnUiThread(RefreshAll);
        private void OnSubscriptionChanged(Subscription subscription, ChangeType changeType) => RunOnUiThread(RefreshAll);
        private void OnPaymentReceived(Payment payment) => RunOnUiThread(RefreshAll);
        private void OnBookingChanged(Booking booking, ChangeType changeType) => RunOnUiThread(RefreshAll);
        private void OnGymClassChanged(GymClass gymClass, ChangeType changeType) => RunOnUiThread(RefreshAll);
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

        #region Refresh & Data Binding

        public void RefreshAll()
        {
            RefreshDashboardMetrics();
            LoadClassFillRates();
            LoadMonthlyRevenue();
            LoadMemberStatusReport();
        }

        private void RefreshDashboardMetrics()
        {
            var metrics = _reportService.GetDashboardMetrics();

            lblMembersVal.Text = metrics.TotalMembers.ToString("N0");
            lblMembersSub.Text = $"Active: {metrics.ActiveMembers} | Expired: {metrics.ExpiredMembers}";

            lblRevenueVal.Text = metrics.MonthlyRevenue.ToString("C2");
            lblClassesVal.Text = metrics.TotalClassesCount.ToString("N0");
            lblOutstandingVal.Text = metrics.TotalOutstandingBalance.ToString("C2");
        }

        private void LoadClassFillRates()
        {
            var fillRates = _reportService.GetClassFillRates().ToList();
            dgvClassFillRates.AutoGenerateColumns = false;
            dgvClassFillRates.DataSource = fillRates;
        }

        private void LoadMonthlyRevenue()
        {
            var monthly = _reportService.GetMonthlyIncomeSummary().ToList();
            dgvMonthlyRevenue.AutoGenerateColumns = false;
            dgvMonthlyRevenue.DataSource = monthly;
        }

        private void LoadMemberStatusReport()
        {
            string? selectedFilter = cboMemberFilter.SelectedItem?.ToString();
            var members = _reportService.GetMemberStatusReport(selectedFilter).ToList();
            dgvMemberStatus.AutoGenerateColumns = false;
            dgvMemberStatus.DataSource = members;
        }

        #endregion

        #region User Actions & Export

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshAll();
        }

        private void cboMemberFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMemberStatusReport();
        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            DataGridView? currentGrid = null;
            string reportName = "Report";

            switch (tabReports.SelectedIndex)
            {
                case 0:
                    currentGrid = dgvClassFillRates;
                    reportName = "ClassFillRates";
                    break;
                case 1:
                    currentGrid = dgvMonthlyRevenue;
                    reportName = "MonthlyRevenue";
                    break;
                case 2:
                    currentGrid = dgvMemberStatus;
                    reportName = "MembershipStatus";
                    break;
            }

            if (currentGrid == null || currentGrid.Rows.Count == 0)
            {
                MessageBox.Show(
                    "There are no records in the active report tab to export.",
                    "Export Empty",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            using var sfd = new SaveFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*",
                FileName = $"Gym_{reportName}_{DateTime.Now:yyyyMMdd_HHmmss}.csv",
                Title = $"Export {reportName} Report to CSV"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sb = new StringBuilder();

                    // Header row
                    var visibleColumns = currentGrid.Columns.Cast<DataGridViewColumn>()
                        .Where(c => c.Visible)
                        .OrderBy(c => c.DisplayIndex)
                        .ToList();

                    sb.AppendLine(string.Join(",", visibleColumns.Select(c => EscapeCsv(c.HeaderText))));

                    // Data rows
                    foreach (DataGridViewRow row in currentGrid.Rows)
                    {
                        if (row.IsNewRow) continue;
                        var values = visibleColumns.Select(col =>
                        {
                            var cellVal = row.Cells[col.Index].Value?.ToString() ?? string.Empty;
                            return EscapeCsv(cellVal);
                        });
                        sb.AppendLine(string.Join(",", values));
                    }

                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);

                    MessageBox.Show(
                        $"Report successfully exported to:\n{sfd.FileName}",
                        "Export Successful",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Error exporting report: {ex.Message}",
                        "Export Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private static string EscapeCsv(string value)
        {
            if (string.IsNullOrEmpty(value)) return "\"\"";
            if (value.Contains(",") || value.Contains("\"") || value.Contains("\n") || value.Contains("\r"))
            {
                return $"\"{value.Replace("\"", "\"\"")}\"";
            }
            return $"\"{value}\"";
        }

        #endregion
    }
}
