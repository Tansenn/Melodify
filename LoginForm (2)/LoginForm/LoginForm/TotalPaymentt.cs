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
    public partial class TotalPaymentt : Form
    {
        public TotalPaymentt(int amount)
        {
            InitializeComponent();
            textBoxTotalPayment.Text = amount.ToString() + " Taka";

        }

        private void textBoxTotalPayment_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxValiduntil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            PremiumPlan premiumPlan = new PremiumPlan();
            premiumPlan.Show();
            this.Close();

        }

        private void buttonSubmit_Click_1(object sender, EventArgs e)
        {
            PaymentValidation pay = new PaymentValidation();
            pay.Show();
            this.Close();
            

        }
    }
}
    


