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

namespace NewPassword_GUI
{
    public partial class frmNewPassword : Form
    {
        public frmNewPassword()
        {
            InitializeComponent();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string Username = txtUsername.Text;
            string Newpassword = txtNewPassword.Text;
            string ConfirmPassword = txtConfirmPassword.Text;
            if (string.IsNullOrWhiteSpace(txtNewPassword.Text) || string.IsNullOrWhiteSpace(txtConfirmPassword.Text) || string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please fill in all fields", "Notification");
            }
            if (ConfirmPassword != Newpassword)
            {
                MessageBox.Show("Passwords do not match", "Notification");
                return;
            }
            if (Newpassword.Length <= 6)
            {
                MessageBox.Show("Password must be at least 6 characters");
                txtNewPassword.Focus();
                return;
            }
            else if (!Newpassword.Any(Char.IsUpper))
            {
                MessageBox.Show("Password must contain at least one capital letter", "Notification");
                txtNewPassword.Focus();
                return;
            }
            else if (!Newpassword.Any(Char.IsDigit))
            {
                MessageBox.Show("Password must contain at least one number", "Notification");
                txtNewPassword.Focus();
                return;
            }
            else if (!Newpassword.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                MessageBox.Show("Password must contain atleast one special character(@, #, !)");
                txtNewPassword.Focus();
                return;
            }

            StreamReader Login = new StreamReader(@"C:\Users\thandeka\OneDrive\Desktop\reg.txt");
            string line;
            string[] myArray = new string[9];
            //Create an empty list called all lines
            List<string> allLines = new List<string>();
            using (Login)
            {
                line = Login.ReadLine();
                while (line != null)
                {
                    myArray = line.Split('\t');
                    if (myArray.Length >= 9 && myArray[7] == Username)
                    {
                        myArray[8] = Newpassword;
                       
                        // Put the updated information back into the line
                        line = string.Join("\t", myArray);
                    }

                    //Do not loose other people's information as while loop continues
                    allLines.Add(line);
                    line = Login.ReadLine();
                }
            }
























            StreamWriter change = new StreamWriter(@"C:\Users\thandeka\OneDrive\Desktop\reg.txt");
            using (change)
            {
                //Get items from the list containing all lines
                foreach ( string updatedLine in allLines)
                {
                    //Write the changed information
                    change.WriteLine(updatedLine);
                    
                   
                }
                MessageBox.Show("Password Updated successfully", "Notification");
                
                
            }

            frmLogin log = new frmLogin();
            log.Show();
            this.Hide();
            

        }
    }
}
