using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace LoginForm
{
    public partial class UserProfile : Form
    {

        private string connectionString = @"Data Source=NOANGOLA\MSSQLSERVER01;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public UserProfile()
        {
            InitializeComponent();
        }
        private void LoadUserProfile()
        {
            try
            {
                int userID = GetCurrentUserID(); // Get the logged-in user's ID
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Username, SubscriptionType, JoinDate FROM dbo.Profile WHERE UserID = @UserID"; // Added schema prefix
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblUserName.Text = "Name: " + reader["Username"].ToString();
                                lblSubscription.Text = "Subscription: " + reader["SubscriptionType"].ToString();
                                lblJoiningDate.Text = "Joined on: " + Convert.ToDateTime(reader["JoinDate"]).ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                MessageBox.Show("User data not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private int GetCurrentUserID()
        {
            return 1; 
        }

        

        private void ba_Click(object sender, EventArgs e)
        {
            UserMainForm mainForm = new UserMainForm();
            mainForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
        }
    }
}

