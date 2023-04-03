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
    public partial class frmDeleteAccount : Form
    {
        string connStr = "server=localhost; database=recordmgmt; uid=root; pwd=rootAdmin123";
        MySqlConnection conn;

        public frmDeleteAccount()
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

        private void btnDeleteClick(object sender, EventArgs e)
        {
            conn = new MySqlConnection(connStr);
            conn.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"DELETE FROM `recordmgmt`.`user` WHERE (`username` = '{txtUsername.Text}')";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Account successfully deleted.");
            this.Close();
            
        }
    }
}
