using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceDeliveryPOE.Data;

namespace ServiceDeliveryPOE
{
    public partial class ReportStatus : Form
    {
        private Form previousForm;
        private List<Report> allReports;
        private ReportBST reportTree;

        public ReportStatus(Form callingForm)
        {
            InitializeComponent();
            previousForm = callingForm;
            this.Load += ReportStatus_Load;
        }

        private void ReportStatus_Load(object sender, EventArgs e)
        {
            SetupListView();
            LoadReports();
        }

        private void SetupListView()
        {
            listViewReportStatus.View = View.Details;
            listViewReportStatus.FullRowSelect = true;
            listViewReportStatus.Columns.Clear();

            listViewReportStatus.Columns.Add("Report ID", 50);
            listViewReportStatus.Columns.Add("Location", 100);
            listViewReportStatus.Columns.Add("Category", 100);
            listViewReportStatus.Columns.Add("Description", 255);
            listViewReportStatus.Columns.Add("Status", 100);
            listViewReportStatus.Columns.Add("Status Details", 200);
        }

        private void LoadReports()
        {
            listViewReportStatus.Items.Clear();
            try
            {

                using (var db = new ServiceDeliveryDbContext())
                {
                    allReports = db.Reports.ToList();
                    var heap = new PriorityQueue<Report, (int, int)>();

                    foreach (var report in allReports)
                    {
                        int statusPriority = GetStatusPriority(report.Status);
                        heap.Enqueue(report, (statusPriority, report.ReportId));
                    }

                    while (heap.Count > 0)
                    {
                        var report = heap.Dequeue();
                        AddReportToListView(report);
                    }
                    reportTree = new ReportBST(allReports);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reports: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddReportToListView(Report report)
        {
            var item = new ListViewItem(report.ReportId.ToString());
            item.SubItems.Add(report.Location);
            item.SubItems.Add(report.Category);
            item.SubItems.Add(report.Description);
            item.SubItems.Add(GetStatusText(report.Status));
            item.SubItems.Add(report.StatusDetails ?? "N/A");
            listViewReportStatus.Items.Add(item);
        }

        private String GetStatusText(bool? status)
        {
            if (status == null)
                return "Pending";
            else if (status == true)
                return "Approved";
            else
                return "Declined";
        }

        private int GetStatusPriority(bool? status)
        {
            if (status == null)
                return 0;
            else if (status == true) return 1;
            else return 2;
        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbID.Text))
            {
                MessageBox.Show("Please enter a Report ID.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tbID.Text, out int reportId))
            {
                MessageBox.Show("Invalid Report ID. Please enter a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var foundReport = reportTree?.Search(reportId);

            listViewReportStatus.Items.Clear();

            if (foundReport != null)
            {
                AddReportToListView(foundReport);
            }
            else
            {
                MessageBox.Show("Report not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadReports();
            }
        }

        private void listViewReportStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ReportStatus_Load_1(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            previousForm.Show();
        }

        private void btnCleaar_Click(object sender, EventArgs e)
        {
            tbID.Clear();
            LoadReports();

        }
    }
}
