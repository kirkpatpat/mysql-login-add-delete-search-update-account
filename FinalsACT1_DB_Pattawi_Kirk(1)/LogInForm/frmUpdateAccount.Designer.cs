namespace LogInForm
{
    partial class frmUpdateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateAccount));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtNew = new System.Windows.Forms.TextBox();
            this.lblRegistration = new System.Windows.Forms.Label();
            this.lblNew = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtConfirm);
            this.panel1.Controls.Add(this.lblConfirm);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.txtNew);
            this.panel1.Controls.Add(this.lblRegistration);
            this.panel1.Controls.Add(this.lblNew);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Location = new System.Drawing.Point(34, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 329);
            this.panel1.TabIndex = 1;
            // 
            // txtConfirm
            // 
            this.txtConfirm.BackColor = System.Drawing.Color.Magenta;
            this.txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirm.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirm.Location = new System.Drawing.Point(29, 206);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(348, 21);
            this.txtConfirm.TabIndex = 3;
            this.txtConfirm.UseSystemPasswordChar = true;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirm.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm.ForeColor = System.Drawing.Color.White;
            this.lblConfirm.Location = new System.Drawing.Point(25, 183);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(144, 20);
            this.lblConfirm.TabIndex = 23;
            this.lblConfirm.Text = "Confirm Password";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(139, 258);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(155, 34);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update Account";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdateClick);
            // 
            // txtNew
            // 
            this.txtNew.BackColor = System.Drawing.Color.Magenta;
            this.txtNew.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNew.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNew.Location = new System.Drawing.Point(29, 145);
            this.txtNew.Name = "txtNew";
            this.txtNew.Size = new System.Drawing.Size(348, 21);
            this.txtNew.TabIndex = 2;
            this.txtNew.UseSystemPasswordChar = true;
            // 
            // lblRegistration
            // 
            this.lblRegistration.AutoSize = true;
            this.lblRegistration.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistration.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistration.ForeColor = System.Drawing.Color.White;
            this.lblRegistration.Location = new System.Drawing.Point(134, 16);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(193, 25);
            this.lblRegistration.TabIndex = 12;
            this.lblRegistration.Text = "Change Password";
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.BackColor = System.Drawing.Color.Transparent;
            this.lblNew.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNew.ForeColor = System.Drawing.Color.White;
            this.lblNew.Location = new System.Drawing.Point(25, 122);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(79, 20);
            this.lblNew.TabIndex = 7;
            this.lblNew.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(25, 64);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(82, 20);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Magenta;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(29, 87);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(348, 21);
            this.txtUsername.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Magenta;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(714, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 25);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmUpdateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(760, 448);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmUpdateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.frmReg_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.TextBox txtNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label lblConfirm;
    }
}