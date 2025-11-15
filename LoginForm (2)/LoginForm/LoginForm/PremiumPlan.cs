using LoginForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NEW
{
    public partial class PremiumPlan : Form
    {
        public PremiumPlan()
        {
            InitializeComponent();
        }

        private void btnSubscribeWeekly_Click(object sender, EventArgs e)
        {
            Total_Payment payment = new Total_Payment(80);
            payment.Show();
            this.Hide();

        }

        private void btnSubscribeMonthly_Click(object sender, EventArgs e)
        {
            TotalPaymentt pay = new TotalPaymentt(200);
            pay.Show();
            this.Hide();
               
        }

        private void LoadSubscriptionPanel(UserControl control)
        {

            Subpanle.Controls.Clear();


            Subpanle.Controls.Add(control);

            
            control.Dock = DockStyle.Fill;
        }

        private void PremiumPlan_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UserMainForm mainForm = new UserMainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}



