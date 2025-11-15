using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime.Remoting.Contexts;

namespace LoginForm
{
    public partial class PremiumUser : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=NOANGOLA\MSSQLSERVER01;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public PremiumUser()
        {
            InitializeComponent();
            txtPremium_pass.PasswordChar = '*';
        }

        public bool CheckConnection()
        {
            return connect.State == ConnectionState.Closed;
        }
        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (txtPremium_username.Text == "" || txtPremium_Email.Text == "" || txtPremium_pass.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (CheckConnection())
                {
                    try
                    {
                        connect.Open();

                        // CHECK IF THE USERNAME OR EMAIL ALREADY EXISTS
                        string selectQuery = "SELECT * FROM PremiumUsers WHERE Username = @Username OR Email = @Email";
                        using (SqlCommand checkUser = new SqlCommand(selectQuery, connect))
                        {
                            checkUser.Parameters.AddWithValue("@username", txtPremium_username.Text.Trim());
                            checkUser.Parameters.AddWithValue("@Email", txtPremium_Email.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            if (table.Rows.Count != 0)
                            {
                                string existingField = table.Rows[0]["Username"].ToString() == txtPremium_username.Text.Trim()
                                    ? "Username" : "Email";

                                MessageBox.Show(existingField + " is already in use", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (txtPremium_pass.Text.Length < 8)
                            {
                                MessageBox.Show("Invalid password, at least 8 characters are needed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                // INSERT THE NEW USER
                                string insertData = @" INSERT INTO Useer1 (Username, Email, Password, SubscriptionType, JoinDate) VALUES (@username, @Email, @Password, @subscriptionType, @joinDate)";

                                using (SqlCommand insertUser = new SqlCommand(insertData, connect))
                                {
                                    insertUser.Parameters.AddWithValue("@username", txtPremium_username.Text.Trim());
                                    insertUser.Parameters.AddWithValue("@Email", txtPremium_Email.Text.Trim());


                                    insertUser.Parameters.AddWithValue("@Password", txtPremium_pass.Text.Trim());

                                    // Default subscription type for new users
                                    insertUser.Parameters.AddWithValue("@subscriptionType", "Premium");

                                    // Join date (current date)
                                    insertUser.Parameters.AddWithValue("@joinDate", DateTime.Now);

                                    insertUser.ExecuteNonQuery();

                                    MessageBox.Show("Registered successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    PremiumMainForm loginForm = new PremiumMainForm();
                                    loginForm.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed connection: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }

        }

        private void Premium_showpass_CheckedChanged(object sender, EventArgs e)
        {
            txtPremium_pass.PasswordChar = Premium_showpass.Checked ? '\0' : '*';
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_login_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();

            this.Hide();
        }
    }
    
}
