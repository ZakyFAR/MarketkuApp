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
    public partial class FormUpdateBarang : Form
    {
        // create connection with database
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Project\C#\Database.accdb");

        public FormUpdateBarang()
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
            String printah = "UPDATE Product SET Stock= '" + txtStock.Text + "',Harga='" + txtHarga.Text + "' WHERE Nama='" + txtNama.Text + "'";
            OleDbCommand cmd = new OleDbCommand(printah, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Barang telah di Perbarui");
            }
            else
            {
                MessageBox.Show("Salah Masukan Nama atau tidak ada nama tersebut");
            }

            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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
            txtHarga.Text = "";
            txtStock.Text = "";
        }
    }
}
