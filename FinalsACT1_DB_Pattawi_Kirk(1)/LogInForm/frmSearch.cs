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
    public partial class frmSearch : Form
    {
        string connStr = "server=localhost; database=recordmgmt; uid=root; pwd=rootAdmin123";
        MySqlConnection conn;

        public frmSearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection(connStr);
            conn.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT * FROM `user` WHERE username = '{txtSearch.Text}'";

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();

            da.Fill(table);
            dataGridView1.DataSource = table;
            conn.Close();
        }
    }
}
