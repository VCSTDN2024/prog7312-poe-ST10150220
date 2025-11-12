using ServiceDeliveryPOE.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceDeliveryPOE
{
    public partial class ReportForm : Form
    {
        private Form previousForm;
        public List<Report> userReports = new List<Report>();

        public ReportForm(Form callingForm)
        {
            InitializeComponent();
            previousForm = callingForm;
        }

        private void locationTxt_TextChanged(object sender, EventArgs e)
        {

        }


        OpenFileDialog fileDialog = new OpenFileDialog();
        private void uploadBtn_Click(object sender, EventArgs e)
        {
            fileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                reportImagePb.ImageLocation = fileDialog.FileName;
            }
        }

        private void reportProgBar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            previousForm.Show();
        }

        private void reportImagePb_Click(object sender, EventArgs e)
        {

        }

        private async void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new ServiceDeliveryDbContext())
                {
                    byte[] imageData = null;

                    if (reportImagePb.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            reportImagePb.Image.Save(ms, reportImagePb.Image.RawFormat);
                            imageData = ms.ToArray();
                        }
                    }

                    reportProgBar.Value = 50;

                    var report = new Report
                    {
                        Location = locationTxt.Text,
                        Category = categoryListBox.Text,
                        Description = descriptionRichTxt.Text,
                        ImageData = imageData
                    };

                    reportProgBar.Value = 75;

                    userReports.Add(report);

                    context.Reports.Add(report);
                    await context.SaveChangesAsync();

                    reportProgBar.Value = 100;

                    MessageBox.Show($"Report Submitted. Your Report ID is: {report.ReportId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ReportDetailsForm detailsForm = new ReportDetailsForm(report, this);
                    detailsForm.Show();
                    this.Hide();

                    locationTxt.Clear();
                    categoryListBox.ClearSelected();
                    descriptionRichTxt.Clear();
                    reportImagePb.Image = null;
                    reportProgBar.Value = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error. Could not submit Report" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void categoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
