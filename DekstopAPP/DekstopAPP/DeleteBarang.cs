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
    public partial class FormDeleteBarang : Form
    {
        // create connection with database
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Project\C#\Database.accdb");

        public FormDeleteBarang()
        {
            InitializeComponent();
        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            // create dataadabter
            OleDbDataAdapter da = new OleDbDataAdapter("select count(*) from Product where Nama='" + txtNama.Text + "' ", con);

            //create datatable
            DataTable dt = new DataTable();

            //fill datatble
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                con.Open();
                string printah = "DELETE FROM Product WHERE Nama='" + txtNama.Text + "'";
                OleDbDataAdapter da2 = new OleDbDataAdapter(printah, con);
                DataTable dt2 = new DataTable();
                //OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da2.Fill(dt2);

                con.Close();
                MessageBox.Show("Barang telah dihapus");

            }
            else
            {
                MessageBox.Show("Salah Masukan Nama atau tidak ada nama tersebut");
            }

            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormBarang f2 = new FormBarang();
            f2.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNama.Text = "";
        }
    }
}
