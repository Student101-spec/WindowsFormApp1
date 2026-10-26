using NewPassword_GUI;
using Packages;
using Profile_GUI;
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
using WindowsFormsApp1;

namespace Login_page
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            StreamReader Login = new StreamReader(@"C:\Users\thandeka\OneDrive\Desktop\Reg.txt");
            string line;
            string username = txtuname.Text;
            string Password = txtpword.Text;
            string[] myArray = new string[9];
            if (string.IsNullOrWhiteSpace(txtuname.Text))
            {
                MessageBox.Show("Enter your username", "Notification.");
                txtuname.Focus();
                return;


            }
            if(string.IsNullOrWhiteSpace(txtpword.Text))
            {
                MessageBox.Show("Enter your password", "Notification.");
                txtpword.Focus();
                return;
                
            }
            if (Password.Length <= 6)
            {
                MessageBox.Show("Password must be 6 characters");
                txtpword.Focus();
                return;
            }
            else if (!Password.Any(Char.IsUpper))
            {
                MessageBox.Show("Password must contain at least one capital letter", "Notification");
                txtpword.Focus();
                return;
            }
           
            else if (!Password.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                MessageBox.Show("Password must contain atleast one special character(@, #, !)");
                txtpword.Focus();
                return;
            }
            using (Login)
            {
                line = Login.ReadLine();
                bool loginsuccessful = false;
                while (line != null)
                {
                    myArray = line.Split('\t');
                    if (myArray.Length >= 9 && username == myArray[7] && Password == myArray[8])
                    {
                        loginsuccessful = true;
                        MessageBox.Show("Login Successful");

                        frmChooseP package = new frmChooseP(username);
                        {
                            package.Show();
                            this.Hide();
                            return;
                        }
                        
                    }

                    line = Login.ReadLine();
                    

                }
                if (!loginsuccessful)
                {
                    MessageBox.Show("Incorrect username or Password");
                    return;

                }
                frmProfile profile = new frmProfile();
                profile.Show();
                this.Hide();







            }   
        }  
        

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            frmNewPassword Update = new frmNewPassword();
            Update.Show();
            this.Hide();
        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            frmRegistration registerForm = new frmRegistration();
            registerForm.Show();
            this.Hide();
        }

        private void txtpword_TextChanged(object sender, EventArgs e)
        {
            txtpword.UseSystemPasswordChar = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmhome back = new frmhome();
            back.Show();
            this.Hide();
        }

        private void btnEye_Click(object sender, EventArgs e)
        {
            if (txtpword.UseSystemPasswordChar == true)
            {
                txtpword.UseSystemPasswordChar = false;
                btnEye.Text = "";
            }
            else
            {
                txtpword.UseSystemPasswordChar = true;
                btnEye.Text = "";
            }
        }
    }
}
