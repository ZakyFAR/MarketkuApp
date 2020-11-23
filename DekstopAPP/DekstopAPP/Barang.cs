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
    public partial class FormBarang : Form
    {
        // create connection with database
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Project\C#\Database.accdb");

        public FormBarang()
        {
            InitializeComponent();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            FormDeleteBarang f2 = new FormDeleteBarang();
            f2.Show();
            this.Hide();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FormTambahBarang f2 = new FormTambahBarang();
            f2.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FormUpdateBarang f2 = new FormUpdateBarang();
            f2.Show();
            this.Hide();
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

        private void btnAll_Click(object sender, EventArgs e)
        {
            con.Open();
            string printah = "select * from Product ";
            OleDbDataAdapter da = new OleDbDataAdapter(printah, con);
            DataTable dt = new DataTable();
            //OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            con.Close();
        }
    }
}
