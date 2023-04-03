using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace LogInForm
{
    public partial class frmAddAccount : Form
    {
        MySqlConnection conn;
        string connectionStr = "server=localhost; database=recordmgmt; uid=root; pwd=rootAdmin123";

        public frmAddAccount()
        {
            InitializeComponent();
        }

        private void frmReg_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(150, 0, 0, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection(connectionStr);
            //conn.ConnectionString = connectionStr;
            conn.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"INSERT INTO user(`username`, `password`) VALUES('{txtUsername.Text}', '{txtConfirm.Text}')";

            if (String.IsNullOrEmpty(txtUsername.Text) || String.IsNullOrEmpty(txtPassword.Text))
                MessageBox.Show("Username and Password are required!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (String.IsNullOrEmpty(txtConfirm.Text))
                MessageBox.Show("Please enter your password again.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (String.IsNullOrEmpty(txtPassword.Text) || String.IsNullOrEmpty(txtConfirm.Text))
                MessageBox.Show("Enter a password", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            else if (txtPassword.Text == txtConfirm.Text)
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Successfully created an account.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Passwords don't match.");
                conn.Close();
            }
        }
    }
}
