using BrowsePackages_GUI;
using Packages;
using Payment_slip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Versioning;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payment_GUI
{
    public partial class frmPayment : Form
    {
        private string memPlan;
        private double amt;
        public frmPayment(string PackageName, double price)
        {
            InitializeComponent();
            memPlan = PackageName;
            amt = price;
            lblPackage.Text = PackageName;
            lblPrice.Text = price.ToString("C");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string fNmae = txtName.Text;
            string Surname = txtSurname.Text;
            string Email = txtEmail.Text;
            string CellNum = txtPhoneN.Text;
            string AccountH = txtAccountH.Text;
            string CardNum = txtCardNum.Text;
            string Cvv = txtCVV.Text;
            

            

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("First name is required", "Notification");
                txtName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSurname.Text))
            {
                MessageBox.Show("Surname is required", "Notification");
                txtSurname.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email is required", "Notification");
                txtEmail.Focus();
                return;

            }
            if (!txtEmail.Text.Contains("@gmail.com"))
            {
                MessageBox.Show("Email must end with @gmail.com", "Notification");
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhoneN.Text))
            {
                MessageBox.Show("Phone number is required", "Notification");
                txtPhoneN.Focus();
                return;
            }
            if (txtPhoneN.Text.Length != 10)
            {
                MessageBox.Show("Phone number must be 10 digits");
                txtPhoneN.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAccountH.Text))
            {
                MessageBox.Show("Account holder is required", "Notification");
                txtAccountH.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCardNum.Text))
            {
                MessageBox.Show("Card number is required", "Notification");
                txtCardNum.Focus();
                return;
            }
            if (txtCardNum.Text.Length != 16)
            {
                MessageBox.Show("Card number must be 16 digits");
                txtCardNum.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCVV.Text))
            {
                MessageBox.Show("CVV number is required", "Notification");
                txtCVV.Focus();
                return;
            }
            if (txtCVV.Text.Length != 3)
            {
                MessageBox.Show("CVV must be 3 digits");
                txtCVV.Focus();
                return;
            }
            if (dtpExpiryDate.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Expirey date cannot be in the past!");
                return;
            }
            DateTime paymentDate = DateTime.Today;
            DateTime activeFrom = DateTime.Today;

            // Example: membership lasts for one year
            DateTime expiresOn = activeFrom.AddMonths(1);

            // Generate a receipt number
            string receiptNo = "REC" + DateTime.Now.ToString("yyyyMMddHHmmss");

            // Open the receipt form and pass the payment details
            FrmPaymentSlip receipt = new FrmPaymentSlip(
                receiptNo,
                memPlan,
                amt,
                paymentDate,
                activeFrom,
                expiresOn
            );

            receipt.ShowDialog();

            string filePath = @"C:\Users\thandeka\OneDrive\Desktop\Reg.txt";
            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length > 0)
            {
                lines[lines.Length - 1] = lines[lines.Length - 1] + "\t" + memPlan + "\t" + amt;
                File.WriteAllLines(filePath, lines);
            }

                // StreamWriter re = new StreamWriter(@"C:\Users\thandeka\OneDrive\Desktop\Reg.txt", true);
            //using (re)
            //{
               // re.Write(memPlan + "\t");
                //re.Write(amt + "\t");
          //  }

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmChooseP package = new frmChooseP();
            package.Show();
            this.Hide();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            
        }
    }
}
