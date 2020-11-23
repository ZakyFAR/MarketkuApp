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
    public partial class FormCekStock : Form
    {
        // create connection with database
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Project\C#\Database.accdb");

        public FormCekStock()
        {
            InitializeComponent();
        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            con.Open();
            string printah = "select Stock from Product where nama='" + txtNama.Text + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(printah, con);
            DataTable dt = new DataTable();
            //OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            
            con.Close();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormPegawai f2 = new FormPegawai();
            f2.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNama.Text = "";
        }
    }
}
