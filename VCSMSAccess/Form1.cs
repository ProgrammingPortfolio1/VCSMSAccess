using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace VCSMSAccess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String query = textBox1.Text;
            String connStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=library.mdb;User Id=admin;Password=;";
            OleDbConnection conn = new OleDbConnection(connStr);
            OleDbCommand cmd = new OleDbCommand(query, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Command Executed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
    }
}
