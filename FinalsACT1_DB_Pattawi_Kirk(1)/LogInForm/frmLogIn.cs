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
    public partial class frmLogIn : Form
    {
        MySqlConnection conn;
        String connectionStr = "server=localhost; database=recordmgmt; uid=root; pwd=rootAdmin123";
        String username, password;

        public frmLogIn()
        {
            InitializeComponent();
        }


        private void Login_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(150, 0, 0, 0);
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {           
            conn = new MySqlConnection(connectionStr);
            //conn.ConnectionString = connectionStr;
            conn.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT username, password FROM user WHERE username = '{txtUsername.Text}' and password = '{txtPassword.Text}'";
            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                rdr.Read();
                username = rdr["username"].ToString();
                password = rdr["password"].ToString();

                if(txtUsername.Text == username && txtPassword.Text == password)
                {
                    frmSearch frm = new frmSearch();
                    frm.ShowDialog();
                    conn.Close();
                    txtUsername.Clear();
                    txtPassword.Clear();
                }
            }
            else
            {
                MessageBox.Show("Login Failed. The username or password you entered is incorrect.", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                conn.Close();
            }
        }

        private void lnkAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddAccount addAccount = new frmAddAccount();
            addAccount.ShowDialog();
        }

        private void lnkDelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmUpdateAccount updateAccount = new frmUpdateAccount();
            updateAccount.ShowDialog(); 
        }

        private void lnkDelete_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDeleteAccount deleteAccount = new frmDeleteAccount();
            deleteAccount.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
