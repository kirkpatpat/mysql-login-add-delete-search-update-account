namespace LogInForm
{
    partial class frmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lnkChange = new System.Windows.Forms.LinkLabel();
            this.lnkAcc = new System.Windows.Forms.LinkLabel();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.lblLogIn = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lnkDelete = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lnkDelete);
            this.panel1.Controls.Add(this.lnkChange);
            this.panel1.Controls.Add(this.lnkAcc);
            this.panel1.Controls.Add(this.btnLogIn);
            this.panel1.Controls.Add(this.lblLogIn);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Location = new System.Drawing.Point(275, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 389);
            this.panel1.TabIndex = 0;
            // 
            // lnkChange
            // 
            this.lnkChange.AutoSize = true;
            this.lnkChange.BackColor = System.Drawing.Color.Transparent;
            this.lnkChange.LinkColor = System.Drawing.Color.Red;
            this.lnkChange.Location = new System.Drawing.Point(162, 355);
            this.lnkChange.Name = "lnkChange";
            this.lnkChange.Size = new System.Drawing.Size(117, 16);
            this.lnkChange.TabIndex = 9;
            this.lnkChange.TabStop = true;
            this.lnkChange.Text = "Change Password";
            this.lnkChange.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDelete_LinkClicked);
            // 
            // lnkAcc
            // 
            this.lnkAcc.AutoSize = true;
            this.lnkAcc.BackColor = System.Drawing.Color.Transparent;
            this.lnkAcc.LinkColor = System.Drawing.Color.Red;
            this.lnkAcc.Location = new System.Drawing.Point(100, 311);
            this.lnkAcc.Name = "lnkAcc";
            this.lnkAcc.Size = new System.Drawing.Size(98, 16);
            this.lnkAcc.TabIndex = 8;
            this.lnkAcc.TabStop = true;
            this.lnkAcc.Text = "Create Account";
            this.lnkAcc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAcc_LinkClicked);
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.White;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.Location = new System.Drawing.Point(83, 257);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(132, 41);
            this.btnLogIn.TabIndex = 7;
            this.btnLogIn.Text = "Login";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // lblLogIn
            // 
            this.lblLogIn.AutoSize = true;
            this.lblLogIn.BackColor = System.Drawing.Color.Transparent;
            this.lblLogIn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogIn.ForeColor = System.Drawing.Color.White;
            this.lblLogIn.Location = new System.Drawing.Point(107, 46);
            this.lblLogIn.Name = "lblLogIn";
            this.lblLogIn.Size = new System.Drawing.Size(79, 25);
            this.lblLogIn.TabIndex = 6;
            this.lblLogIn.Text = "Log In";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Red;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(19, 209);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(260, 30);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Red;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUsername.Location = new System.Drawing.Point(19, 132);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(260, 30);
            this.txtUsername.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(14, 180);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(102, 26);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(14, 103);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(104, 26);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(784, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 26);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lnkDelete
            // 
            this.lnkDelete.AutoSize = true;
            this.lnkDelete.BackColor = System.Drawing.Color.Transparent;
            this.lnkDelete.LinkColor = System.Drawing.Color.Red;
            this.lnkDelete.Location = new System.Drawing.Point(20, 355);
            this.lnkDelete.Name = "lnkDelete";
            this.lnkDelete.Size = new System.Drawing.Size(98, 16);
            this.lnkDelete.TabIndex = 10;
            this.lnkDelete.TabStop = true;
            this.lnkDelete.Text = "Delete Account";
            this.lnkDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDelete_LinkClicked_1);
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(828, 519);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblLogIn;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.LinkLabel lnkAcc;
        private System.Windows.Forms.LinkLabel lnkChange;
        private System.Windows.Forms.LinkLabel lnkDelete;
    }
}