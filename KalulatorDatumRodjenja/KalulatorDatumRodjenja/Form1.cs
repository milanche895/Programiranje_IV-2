using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalulatorDatumRodjenja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dan = int.Parse(txtDan.Text);
            int mesec = int.Parse(txtMesec.Text);
            int godina = int.Parse(txtGodina.Text);
            DateTime datumRodjenja = new DateTime(godina, mesec, dan);
            DateTime danas = DateTime.Now;
            TimeSpan starost = danas.Subtract(datumRodjenja);
            int brojGodina = (int)starost.TotalDays/365;
            string poruka = string.Format("{0} danas ima {1} godina", txtIme.Text, (int)starost.TotalDays / 365);
            lblGodine.Text = poruka;
            if (brojGodina > 30)
            {
                lblGodine.BackColor = Color.Red;
            }
            else { 
                lblGodine.BackColor = Color.Green;
            }
        }
    }
}
    