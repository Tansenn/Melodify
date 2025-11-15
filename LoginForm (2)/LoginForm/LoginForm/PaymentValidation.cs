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
    public partial class PaymentValidation : Form
    {
        public PaymentValidation()
        {
            InitializeComponent();
        }


        private void btnBacktoHome_Click(object sender, EventArgs e)
        {
            UserMainForm pay = new UserMainForm();
            pay.Show();
            this.Close();
            
        }

    }
}
      
