using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using ServiceDeliveryPOE.Data;
using System.Configuration;


namespace ServiceDeliveryPOE
{
    public partial class AnnouncementForm : Form
    {
        private Form previousForm;
        private Dictionary<string, ServiceDeliveryPOE.Data.Event> eventsByTitle = new Dictionary<string, ServiceDeliveryPOE.Data.Event>();


        public AnnouncementForm(Form callingForm)
        {
            InitializeComponent();
            previousForm = callingForm;
            LoadCategories();

        }

        private void LoadCategories()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ServiceDeliveryDb"].ConnectionString;
            string query = "SELECT Category FROM Events";

            HashSet<string> uniqueCategories = new HashSet<string>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string category = reader["Category"].ToString();
                        uniqueCategories.Add(category);
                    }
                    reader.Close();

                    cBCategory.Items.Clear();
                    foreach (var cat in uniqueCategories)
                    {
                        cBCategory.Items.Add(cat);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error could not categories: " + ex.Message);
                }
            }
        }



        private ListView listViewEvents;
        private TextBox tBTitle;
        private Button btnSearch;
        private MonthCalendar monthCalendarSearch;
        private ContextMenuStrip contextMenuStrip1;
        private IContainer components;
        private TextBox tBLocation;
        private ComboBox cBCategory;
    }
}
