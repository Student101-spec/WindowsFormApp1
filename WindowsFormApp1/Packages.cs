using Login_page;
using Payment_GUI;
using Profile_GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Packages
{
    public partial class frmChooseP : Form
    {
        private string loggedInUsername;
        private string username;

        public frmChooseP(string username)
        {
            InitializeComponent();
            loggedInUsername = username;
        }

        public frmChooseP()
        {
        }

        private void re_Load(object sender, EventArgs e)
        {

        }

        private void btnBasic_Click(object sender, EventArgs e)
        {
            string PackageName = "Basic Package";
            double price = 250.00;
            frmPayment payment = new frmPayment(PackageName, price);
            payment.Show();
            this.Hide();
        }

        private void btnStandard_Click(object sender, EventArgs e)
        {
            string PackageName = "Standard Package";
            double price = 450.00;
            frmPayment payment = new frmPayment(PackageName, price);
            payment.Show();
            this.Hide();

        }

        private void btnPremium_Click(object sender, EventArgs e)
        {
            string PackageName = "Premium Package";
            double price = 700.00;
            frmPayment payment = new frmPayment(PackageName, price);
            payment.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmProfile pro = new frmProfile(loggedInUsername);
            pro.Show();
            this.Hide();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogin log = new frmLogin();
            log.Show();
            this.Hide();
        }
    }
}
