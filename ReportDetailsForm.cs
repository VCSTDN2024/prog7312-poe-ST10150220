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
    public partial class ReportDetailsForm : Form
    {
        private Form previousForm;
        public ReportDetailsForm(Report report, Form callingForm)
        {
            InitializeComponent();
            previousForm = callingForm;

            locationLbl.Text = report.Location;
            categoryLbl.Text = report.Category;
            descriptionLbl.Text = report.Description;

            if (report.ImageData != null)
            {
                using (var ms = new MemoryStream(report.ImageData))
                {
                    submittedPb.Image = Image.FromStream(ms);
                }
            }
        }

        private void ReportDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            previousForm.Show();
        }
    }
}
