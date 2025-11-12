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
    public partial class AnnouncementForm : Form
    {
        public AnnouncementForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            components = new Container();
            listViewEvents = new ListView();
            tBTitle = new TextBox();
            btnSearch = new Button();
            monthCalendarSearch = new MonthCalendar();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tBLocation = new TextBox();
            cBCategory = new ComboBox();
            SuspendLayout();
     
            listViewEvents.Location = new Point(21, 109);
            listViewEvents.Name = "listViewEvents";
            listViewEvents.Size = new Size(526, 353);
            listViewEvents.TabIndex = 0;
            listViewEvents.UseCompatibleStateImageBehavior = false;
            listViewEvents.SelectedIndexChanged += listView1_SelectedIndexChanged;

            tBTitle.Location = new Point(577, 64);
            tBTitle.Name = "tBTitle";
            tBTitle.PlaceholderText = "Enter TItle";
            tBTitle.Size = new Size(271, 23);
            tBTitle.TabIndex = 1;
            tBTitle.TextChanged += textBox1_TextChanged;

            btnSearch.Location = new Point(663, 476);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += button1_Click;
         
            monthCalendarSearch.Location = new Point(577, 274);
            monthCalendarSearch.Name = "monthCalendarSearch";
            monthCalendarSearch.TabIndex = 3;
       
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
      
            tBLocation.Location = new Point(577, 147);
            tBLocation.Name = "tBLocation";
            tBLocation.PlaceholderText = "Enter Location";
            tBLocation.Size = new Size(100, 23);
            tBLocation.TabIndex = 6;
            tBLocation.TextChanged += textBox2_TextChanged;
       
            cBCategory.FormattingEnabled = true;
            cBCategory.Location = new Point(683, 215);
            cBCategory.Name = "cBCategory";
            cBCategory.Size = new Size(121, 23);
            cBCategory.TabIndex = 5;
            cBCategory.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
   
            ClientSize = new Size(871, 577);
            Controls.Add(tBLocation);
            Controls.Add(cBCategory);
            Controls.Add(monthCalendarSearch);
            Controls.Add(btnSearch);
            Controls.Add(tBTitle);
            Controls.Add(listViewEvents);
            Name = "AnnouncementForm";
            ResumeLayout(false);
            PerformLayout();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedCategory = cBCategory.SelectedItem?.ToString();
            listViewEvents.Items.Clear();

            if (string.IsNullOrEmpty(selectedCategory))
            {
                MessageBox.Show("Please select a category to search.");
                return;
            }

            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ServiceDeliveryDb"].ConnectionString;
            string query = "SELECT Title, Location, EventStart, EventEnd FROM Events WHERE Category = @Category";

            using (var conn = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    var cmd = new Microsoft.Data.SqlClient.SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Category", selectedCategory);
                    var reader = cmd.ExecuteReader();

                    listViewEvents.View = View.Details;
                    listViewEvents.Columns.Clear();
                    listViewEvents.Columns.Add("Title", 150);
                    listViewEvents.Columns.Add("Location", 150);
                    listViewEvents.Columns.Add("Start Date", 100);
                    listViewEvents.Columns.Add("End Date", 100);

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["Title"].ToString());
                        item.SubItems.Add(reader["Location"].ToString());
                        item.SubItems.Add(((DateTime)reader["EventStart"]).ToShortDateString());
                        item.SubItems.Add(((DateTime)reader["EventEnd"]).ToShortDateString());

                        listViewEvents.Items.Add(item);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading events: " + ex.Message);
                }
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
