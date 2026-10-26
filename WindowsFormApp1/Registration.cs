using Login_page;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Welcome;
using static System.Windows.Forms.LinkLabel;

namespace WindowsFormsApp1
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            StreamWriter reg = new StreamWriter(@"C:\Users\thandeka\OneDrive\Desktop\Reg.txt",true);
            using ( reg ) 

            {

                string fname = txtfname.Text;
                string surname = txtsname.Text;
                string idnum = txtid.Text;
                string email = txtemail.Text;
                string cellnum = txtcellno.Text;
                string address = txtaddress.Text;
                string gender = "";
                int age = (int)nudage.Value;

                if (radfemale.Checked)
                {
                    gender = "Female";
                }
                else if (radmale.Checked)
                {
                    gender = "Male";
                }

                string username = txtuname.Text;
                string password = txtpword.Text;
                string confpassord = txtcpword.Text;


                if (string.IsNullOrWhiteSpace(txtfname.Text))
                {
                    MessageBox.Show("First name is required", "Notification.");
                    txtfname.Focus();
                    return;

                }

                if (string.IsNullOrWhiteSpace(txtsname.Text))
                {
                    MessageBox.Show("Surname is required", "Notification.");
                    txtsname.Focus();
                    return;

                }

                if (string.IsNullOrWhiteSpace(txtid.Text))
                {
                    MessageBox.Show("ID number is required", "Notification.");
                    txtid.Focus();
                    return;

                }
                if (txtid.Text.Length != 13)
                {
                    MessageBox.Show("ID number must be exactly 13 digits.", "Notification");
                    txtid.Focus();
                    return;

                }

                if (string.IsNullOrWhiteSpace(txtemail.Text))
                {
                    MessageBox.Show("Email is required", "Notification.");
                    txtemail.Focus();
                    return;

                }
                if (!txtemail.Text.Contains("@gmail.com"))
                {
                    MessageBox.Show("Email must end with @gmail.com", "Notification");
                    txtemail.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtcellno.Text))
                {
                    MessageBox.Show("Cell phone number is required", "Notification");
                    txtcellno.Focus();
                    return;

                }
                if (txtcellno.Text.Length != 10)
                {
                    MessageBox.Show("Phone number must be 10 digits");
                    txtcellno.Focus();
                    return;
                }
                if (age < 16)
                {
                    MessageBox.Show("You must be atleast 16 years old to register", "Notification");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtaddress.Text))
                {
                    MessageBox.Show(" Address is required", "Notification.");
                    txtaddress.Focus();
                    return;

                }







                if (!radmale.Checked && !radfemale.Checked)
                {
                    MessageBox.Show("Select your gender ", "Notification.");
                    radfemale.Focus();
                    radmale.Focus();
                    return;

                }




                if (string.IsNullOrWhiteSpace(txtuname.Text))
                {
                    MessageBox.Show("Username is required", "Notification.");
                    txtuname.Focus();
                    return;

                }

                if (string.IsNullOrWhiteSpace(txtpword.Text))
                {
                    MessageBox.Show("Create a password.", "Notification.");
                    txtpword.Focus();
                    return;

                }
                if (password.Length <= 6)
                {
                    MessageBox.Show("Password must be at least 6 characters");
                    txtpword.Focus();
                    return;
                }
                else if (!password.Any(Char.IsUpper))
                {
                    MessageBox.Show("Password must contain at least one capital letter", "Notification");
                    txtpword.Focus();
                    return;
                }
                else if (!password.Any(Char.IsDigit))
                {
                    MessageBox.Show("Password must contain at least one number", "Notification");
                    txtpword.Focus();
                    return;
                }
                else if (!password.Any(ch => !char.IsLetterOrDigit(ch)))
                {
                    MessageBox.Show("Password must contain atleast one special character(@, #, !)");
                    txtpword.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtcpword.Text))
                {
                    MessageBox.Show("Confirm your password.", "Notification.");
                    txtcpword.Focus();
                    return;

                }
                if (confpassord != password)
                {
                    MessageBox.Show("Password does not match.", "Notification.");
                    txtcpword.Focus();
                    return;
                }



                using (reg)
                {
                    reg.Write(fname + "\t");
                    reg.Write(surname + "\t");
                    reg.Write(idnum + "\t");
                    reg.Write(email + "\t");
                    reg.Write(cellnum + "\t");
                    reg.Write(address + "\t");
                    reg.Write(gender + "\t");
                    reg.Write(username + "\t");
                    reg.Write(password + "\n");





                    MessageBox.Show("Successfully Registered!");



                    frmLogin Login = new frmLogin();
                    Login.Show();
                    this.Hide();




                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmhome Reverse = new frmhome();
            Reverse.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtfname.Clear();
            txtsname.Clear();
            txtid.Clear();
            txtemail.Clear();
            txtcellno.Clear();
            txtaddress.Clear();
            txtuname.Clear();
            txtpword.Clear();
            txtcpword.Clear();
        }
    }
    
}
