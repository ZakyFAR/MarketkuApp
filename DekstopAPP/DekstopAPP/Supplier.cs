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

    public partial class FormSupplier : Form
    {
        // create connection with database
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Project\C#\Database.accdb");

        public FormSupplier()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String printah = "INSERT INTO Supplier (Nama,Alamat,NoTelfon,Piutang) values ('" + txtNama.Text + "', '" + txtAlamat.Text + "', '" + txtTelfon.Text + "', '" + txtPiutang.Text + "')";
            OleDbCommand cmd = new OleDbCommand(printah, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Supplier telah di tambahkan");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string printah = "select * from Supplier ";
            OleDbDataAdapter da = new OleDbDataAdapter(printah, con);
            DataTable dt = new DataTable();
            //OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // create dataadabter
            OleDbDataAdapter da = new OleDbDataAdapter("select count(*) from Supplier where Nama='" + txtNama.Text + "' ", con);

            //create datatable
            DataTable dt = new DataTable();

            //fill datatble
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                con.Open();
                string printah = "DELETE FROM Supplier WHERE Nama='" + txtNama.Text + "'";
                OleDbDataAdapter da2 = new OleDbDataAdapter(printah, con);
                DataTable dt2 = new DataTable();
                //OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da2.Fill(dt2);

                con.Close();
                MessageBox.Show("Data Supplier telah dihapus");

            }
            else
            {
                MessageBox.Show("Salah Masukan Nama atau tidak ada nama tersebut");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNama.Text = "";
            txtAlamat.Text = "";
            txtPiutang.Text = ""; 
            txtTelfon.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormMenu f2 = new FormMenu();
            f2.Show();
            this.Hide();
        }
    }
}
