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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPegawai f2 = new FormPegawai();
            f2.Show();
            this.Hide();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnKasir_Click(object sender, EventArgs e)
        {
            FormKasir f2 = new FormKasir();
            f2.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            FormSupplier f2 = new FormSupplier();
            f2.Show();
            this.Hide();
        }
    }
}
