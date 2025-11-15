using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace LoginForm
{
    
    public partial class RegistrationForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=NOANGOLA\MSSQLSERVER01;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public RegistrationForm()
        {
            InitializeComponent();
        }
        public bool checkConnection()
        {
            return (connect.State == ConnectionState.Closed) ? true : false;
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

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (txtRegister_username.Text == "" || txtRegister_Email.Text == "" || txtRegister_pass.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();

                        // CHECK IF THE USERNAME OR EMAIL ALREADY EXISTS
                        string selectQuery = "SELECT * FROM Users1 WHERE Username = @username OR Email = @Email";
                        using (SqlCommand checkUser = new SqlCommand(selectQuery, connect))
                        {
                            checkUser.Parameters.AddWithValue("@username", txtRegister_username.Text.Trim());
                            checkUser.Parameters.AddWithValue("@Email", txtRegister_Email.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            if (table.Rows.Count != 0)
                            {
                                string existingField = table.Rows[0]["Username"].ToString() == txtRegister_username.Text.Trim()
                                    ? "Username" : "Email";

                                MessageBox.Show(existingField + " is already in use", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (txtRegister_pass.Text.Length < 8)
                            {
                                MessageBox.Show("Invalid password, at least 8 characters are needed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                // INSERT THE NEW USER
                                string insertData = @"
                        INSERT INTO Users1 (Username, Email, Password, SubscriptionType, JoinDate)
                        VALUES (@username, @Email, @password, @subscriptionType, @joinDate)";

                                using (SqlCommand insertUser = new SqlCommand(insertData, connect))
                                {
                                    insertUser.Parameters.AddWithValue("@username", txtRegister_username.Text.Trim());
                                    insertUser.Parameters.AddWithValue("@Email", txtRegister_Email.Text.Trim());

                                    // Hash the password before storing it in the database

                                    insertUser.Parameters.AddWithValue("@Password", txtRegister_pass.Text.Trim());

                                    // Default subscription type for new users
                                    insertUser.Parameters.AddWithValue("@subscriptionType", "Free");

                                    // Join date (current date)
                                    insertUser.Parameters.AddWithValue("@joinDate", DateTime.Now);

                                    insertUser.ExecuteNonQuery();

                                    MessageBox.Show("Registered successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Form1 loginForm = new Form1();
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



        private void Register_showpass_CheckedChanged(object sender, EventArgs e)
        {


         txtRegister_pass.PasswordChar = Register_showpass.Checked ? '\0' : '*';


        }

      
    }
}
