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
    public partial class FormTambahBarang : Form
    {
        // create connection with database
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Project\C#\Database.accdb");


        public FormTambahBarang()
        {
            InitializeComponent();
        }

        private void btnNewBarang_Click(object sender, EventArgs e)
        {

            con.Open();
            String printah = "INSERT INTO Product (Nama,Stock,Harga) values ('" + txtNewNama.Text + "', '" + txtNewJumlah.Text + "', '" + txtNewHarga.Text + "')";
            OleDbCommand cmd = new OleDbCommand(printah, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Barang Baru telah di tambahkan");


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

        private void FormTambahBarang_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNewNama.Text = "";
            txtNewHarga.Text = "";
            txtNewJumlah.Text = "";
        }
    }
}
