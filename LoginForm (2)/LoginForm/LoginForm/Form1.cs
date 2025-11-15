using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        string stringConnection = @"Data Source=NOANGOLA\MSSQLSERVER01;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                try
                {
                    connect.Open();

                    // Ensure correct column and table names
                    string selectQuery = "SELECT COUNT(*) FROM Users1 WHERE Username = @usern AND Password = @pass";

                    using (SqlCommand cmd = new SqlCommand(selectQuery, connect))
                    {
                        cmd.Parameters.AddWithValue("@usern", txtLogin_username.Text.Trim());

                        // Hash the input password before checking
                        cmd.Parameters.AddWithValue("@pass", txtLogin_pass.Text.Trim());
                        

                        int userCount = Convert.ToInt32(cmd.ExecuteScalar()); // Returns number of matches

                        if (userCount > 0)
                        {
                            MessageBox.Show("Login successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            PremiumMainForm mainForm = new PremiumMainForm();
                            mainForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database connection error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        

        private void Login_showpass_CheckedChanged(object sender, EventArgs e)
        {
            txtLogin_pass.PasswordChar = Login_showpass.Checked ? '\0' : '*';
        }

        private void close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            RegistrationForm registerForm = new RegistrationForm();
            registerForm.Show();
            this.Hide();
        }

        private void btnPremium_Click(object sender, EventArgs e)
        {
            PremiumUser premiumUser = new PremiumUser();
            premiumUser.Show();
            this.Hide();
        }
    }
}
