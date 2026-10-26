using Packages;
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

namespace Profile_GUI
{
    public partial class frmProfile : Form
    {
        private string loggedInUsername;

        public frmProfile()
        {
        }

        public frmProfile(string username)
        {
            InitializeComponent();
            loggedInUsername = username;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmChooseP ba = new frmChooseP(loggedInUsername);
            ba.Show();
            this.Hide();
        }

        

        private void frmProfile_Load(object sender, EventArgs e)
        {
            try
            {
                bool found = false;
                StreamReader Log = new StreamReader(@"C:\Users\thandeka\OneDrive\Desktop\Reg.txt");
                string line;
                
                while ((line = Log.ReadLine()) != null)
                {
                    string[] myArray = new string[9];
                    myArray = line.Split('\t');
                    if (myArray.Length >= 9 && myArray[7] == loggedInUsername)
                    {
                        myArray = line.Split('\t');
                        lblName.Text = myArray[0] + " " + myArray[1];
                        lblEmail.Text = myArray[3];
                        lblID.Text = myArray[2];
                        lblPackage.Text = myArray[9];
                        lblPrice.Text = myArray[10];
                        found = true;
                        break;

                    }


                }
                if (!found)
                {
                    MessageBox.Show("Could not find a matching record ");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
    }
}
