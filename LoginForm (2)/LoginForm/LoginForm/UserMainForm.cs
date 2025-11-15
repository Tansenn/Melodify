using FSharp.Data.Runtime.WorldBank;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using AxWMPLib;
using WMPLib;
using NEW;

namespace LoginForm
{
    public partial class UserMainForm : Form
    {
        private string connectionString = @"Data Source=NOANGOLA\MSSQLSERVER01;Initial Catalog=""New Database"";Integrated Security=True;Connect Timeout=30;Encrypt=False";

        private AxWindowsMediaPlayer mediaPlayer;

        private UserProfile profileUC = new UserProfile();

        //  private PremiumControl premiumUC = new PremiumControl();
        //   private SettingsControl settingsUC = new SettingsControl();

        public UserMainForm()
        {
            InitializeComponent();
        }
        private int loggedInUserId;
        private string loggedInUserRole;

        public UserMainForm(int userId, string userRole)
        {
            InitializeComponent();
            loggedInUserId = userId;
            loggedInUserRole = userRole;
        }

        private void UserMainForm_Load(object sender, EventArgs e)
        {
            InitializeMediaPlayer();
            LoadMusicLibrary(); // Load music library when the form starts
        }

        private void InitializeMediaPlayer()
        {
            mediaPlayer = new AxWindowsMediaPlayer();
            mediaPlayer.Dock = DockStyle.Bottom;
            mediaPlayer.Name = "mediaPlayer";
            mediaPlayer.Width = this.Width;
            mediaPlayer.Height = 50;
            this.Controls.Add(mediaPlayer);
        }

        private void LoadMusicLibrary()
        {
            string connectionString = "Your_Connection_String_Here";
            string query = "SELECT ID, Title, Artist, FilePath FROM MusicLibrary";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dgvLibrary != null)
                    {
                        dgvLibrary.DataSource = dt;
                        dgvLibrary.Columns["FilePath"].Visible = false; // Hide file path
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading music library: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvLibrary_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string filePath = dgvLibrary.Rows[e.RowIndex].Cells["FilePath"].Value.ToString();
                PlayMusic(filePath);
            }
        }

        private void PlayMusic(string filePath)
        {
            if (System.IO.File.Exists(filePath))
            {
                mediaPlayer.URL = filePath;
                mediaPlayer.Ctlcontrols.play();
            }
            else
            {
                MessageBox.Show("File not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void menu_Click(object sender, EventArgs e)
        {
            MenuTransition.Start();
        }
          // Tracks sidebar state

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {

        }
        private void Library_Click(object sender, EventArgs e)
        {
            MenuTransition.Start();


            // Load music library into DataGridView when switching to Library
            // LoadMusicLibrary();
        }

        

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
        }



        private void pnProfile_Click(object sender, EventArgs e)
        {
            // Retrieve or define the user ID and username (these should come from your application's context or database)
            UserProfile profile = new UserProfile();
            profile.Show();
            this.Hide();
        }

        private void btnHam_Click_1(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick_1(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                Sidebar.Width -= 5;  // Shrinking animation
                if (Sidebar.Width <= 43)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                    // Adjust other panel widths
                    pnProfile.Width = Sidebar.Width;

                    pnTopMixes.Width = Sidebar.Width;

                    btnLogout.Width = Sidebar.Width;

                }
            }
            else
            {
                Sidebar.Width += 5;  // Expanding animation
                if (Sidebar.Width >= 277)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    // Adjust other panel widths
                    pnProfile.Width = Sidebar.Width;
                    pnTopMixes.Width = Sidebar.Width;

                    btnLogout.Width = Sidebar.Width;

                }
            }
        }

        private void pnPremium_Click(object sender, EventArgs e)
        {
            PremiumPlan premium = new PremiumPlan();
            premium.Show();
            this.Hide();

        }
    }
}