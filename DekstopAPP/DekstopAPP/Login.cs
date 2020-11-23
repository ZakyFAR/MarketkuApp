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
    public partial class FormLogin : Form
    {
        // create connection with database
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Project\C#\Database.accdb");

        
        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            // create dataadabter
            OleDbDataAdapter da = new OleDbDataAdapter("select count(*) from Users where username='" + txtUsername.Text + "' and password ='" + txtPassword.Text + "' ", con);

            //create datatable
            DataTable dt = new DataTable();

            //fill datatble
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                
                FormMenu f2 = new FormMenu();
                f2.Show();
                this.Hide();
                
                
                
            }
            else
            {
                MessageBox.Show("Invalid username or Password");
            }
            
        }

        

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormAccount f2 = new FormAccount();
            f2.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
