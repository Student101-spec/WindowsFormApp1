namespace WindowsFormsApp1
{
    partial class frmRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistration));
            this.lblNewAcc = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.radfemale = new System.Windows.Forms.RadioButton();
            this.radmale = new System.Windows.Forms.RadioButton();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtsname = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtcellno = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtuname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtpword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcpword = new System.Windows.Forms.TextBox();
            this.btnreg = new System.Windows.Forms.Button();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.nudage = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNewAcc
            // 
            this.lblNewAcc.AutoSize = true;
            this.lblNewAcc.BackColor = System.Drawing.Color.Red;
            this.lblNewAcc.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewAcc.ForeColor = System.Drawing.Color.White;
            this.lblNewAcc.Location = new System.Drawing.Point(110, 25);
            this.lblNewAcc.Name = "lblNewAcc";
            this.lblNewAcc.Size = new System.Drawing.Size(295, 32);
            this.lblNewAcc.TabIndex = 0;
            this.lblNewAcc.Text = "Register a new account:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(67, 107);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(132, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "First Name(s):";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.BackColor = System.Drawing.Color.Transparent;
            this.lblSurname.ForeColor = System.Drawing.Color.White;
            this.lblSurname.Location = new System.Drawing.Point(67, 148);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(89, 20);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Surname:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(67, 185);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(105, 20);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "ID Number:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(62, 227);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(137, 20);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cell phone number:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(62, 548);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(161, 20);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Physical Address:";
            // 
            // grpGender
            // 
            this.grpGender.BackColor = System.Drawing.Color.Transparent;
            this.grpGender.Controls.Add(this.radfemale);
            this.grpGender.Controls.Add(this.radmale);
            this.grpGender.ForeColor = System.Drawing.Color.White;
            this.grpGender.Location = new System.Drawing.Point(70, 375);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(200, 100);
            this.grpGender.TabIndex = 7;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Gender:";
            // 
            // radfemale
            // 
            this.radfemale.AutoSize = true;
            this.radfemale.Location = new System.Drawing.Point(7, 74);
            this.radfemale.Name = "radfemale";
            this.radfemale.Size = new System.Drawing.Size(91, 24);
            this.radfemale.TabIndex = 1;
            this.radfemale.TabStop = true;
            this.radfemale.Text = "Female";
            this.radfemale.UseVisualStyleBackColor = true;
            // 
            // radmale
            // 
            this.radmale.AutoSize = true;
            this.radmale.Location = new System.Drawing.Point(7, 27);
            this.radmale.Name = "radmale";
            this.radmale.Size = new System.Drawing.Size(70, 24);
            this.radmale.TabIndex = 0;
            this.radmale.TabStop = true;
            this.radmale.Text = "Male";
            this.radmale.UseVisualStyleBackColor = true;
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(302, 100);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(226, 27);
            this.txtfname.TabIndex = 12;
            // 
            // txtsname
            // 
            this.txtsname.Location = new System.Drawing.Point(302, 137);
            this.txtsname.Name = "txtsname";
            this.txtsname.Size = new System.Drawing.Size(226, 27);
            this.txtsname.TabIndex = 13;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(302, 178);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(226, 27);
            this.txtid.TabIndex = 14;
            // 
            // txtcellno
            // 
            this.txtcellno.Location = new System.Drawing.Point(302, 272);
            this.txtcellno.Name = "txtcellno";
            this.txtcellno.Size = new System.Drawing.Size(226, 27);
            this.txtcellno.TabIndex = 16;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(305, 541);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(226, 27);
            this.txtaddress.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(881, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 32);
            this.label3.TabIndex = 21;
            this.label3.Text = "Sign Up";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(657, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Username:";
            // 
            // txtuname
            // 
            this.txtuname.Location = new System.Drawing.Point(859, 93);
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(196, 27);
            this.txtuname.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(660, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Password:";
            // 
            // txtpword
            // 
            this.txtpword.Location = new System.Drawing.Point(859, 241);
            this.txtpword.Name = "txtpword";
            this.txtpword.Size = new System.Drawing.Size(196, 27);
            this.txtpword.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(657, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Confirm Password:";
            // 
            // txtcpword
            // 
            this.txtcpword.Location = new System.Drawing.Point(859, 306);
            this.txtcpword.Name = "txtcpword";
            this.txtcpword.Size = new System.Drawing.Size(201, 27);
            this.txtcpword.TabIndex = 27;
            // 
            // btnreg
            // 
            this.btnreg.BackColor = System.Drawing.Color.Red;
            this.btnreg.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreg.ForeColor = System.Drawing.Color.White;
            this.btnreg.Location = new System.Drawing.Point(859, 464);
            this.btnreg.Name = "btnreg";
            this.btnreg.Size = new System.Drawing.Size(226, 56);
            this.btnreg.TabIndex = 28;
            this.btnreg.Text = "REGISTER";
            this.btnreg.UseVisualStyleBackColor = false;
            this.btnreg.Click += new System.EventHandler(this.btnreg_Click);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(305, 224);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(223, 27);
            this.txtemail.TabIndex = 29;
            this.txtemail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(66, 330);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "Age:";
            // 
            // nudage
            // 
            this.nudage.Location = new System.Drawing.Point(302, 327);
            this.nudage.Name = "nudage";
            this.nudage.Size = new System.Drawing.Size(214, 27);
            this.nudage.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(859, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 90);
            this.panel1.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(24, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(360, 20);
            this.label14.TabIndex = 3;
            this.label14.Text = "*Must contain capital letters and numbers";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(15, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(328, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "*Must have special characters( !,#,@)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(19, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(324, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "*Password must be 6 characters long";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(4, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 20);
            this.label11.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(12, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 35;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 37);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 30);
            this.btnClear.TabIndex = 36;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1368, 607);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nudage);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.btnreg);
            this.Controls.Add(this.txtcpword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtpword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtuname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtcellno);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtsname);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNewAcc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRegistration";
            this.Text = "Registration Page";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewAcc;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton radfemale;
        private System.Windows.Forms.RadioButton radmale;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txtsname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtcellno;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtuname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtpword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcpword;
        private System.Windows.Forms.Button btnreg;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClear;
    }
}

