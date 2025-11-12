namespace ServiceDeliveryPOE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void reportMenuBtn_Click(object sender, EventArgs e)
        {
            ReportForm newForm = new ReportForm(this);

            newForm.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnnouncementForm newForm = new AnnouncementForm(this);

            newForm.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReportStatus newForm = new ReportStatus(this);

            newForm.Show();

            this.Hide();
        }
    }
}
