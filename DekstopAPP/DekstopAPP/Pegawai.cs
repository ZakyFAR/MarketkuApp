using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DekstopAPP
{
    public partial class FormPegawai : Form
    {
        public FormPegawai()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormBarang f2 = new FormBarang();
            f2.Show();
            this.Hide();
        }

        private void btnCekStock_Click(object sender, EventArgs e)
        {
            FormCekStock f2 = new FormCekStock();
            f2.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormMenu f2 = new FormMenu();
            f2.Show();
            this.Hide();
        }
    }
}
