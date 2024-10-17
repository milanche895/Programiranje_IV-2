using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkvirZaTekst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            if (txtIme.Text != string.Empty && txtLozinka.Text != string.Empty)
            {

                string ime = txtIme.Text;
                string lozinka = txtLozinka.Text;

                txtInformacije.Text = "Корисник са корисничким именом" + ime + " унео је лозинку " + lozinka;
            }
            else {
                MessageBox.Show("Молимо Вас унесите корисничко име и лозинку!");
            }
        }
    }
}
