using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DekstopAPP
{
    public partial class FormAccount : Form
    {
        
        // create connection with database
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Project\C#\Database.accdb");
        

        public FormAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Users values('" + txtUsername.Text + "','" + txtPassword.Text + "','" + txtEmail.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfulyy Create Account");
            Close();
            
            

            
            
        }



        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
