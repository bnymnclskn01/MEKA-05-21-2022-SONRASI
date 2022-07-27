using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonForm
{
    public partial class frmRezervasyon : Form
    {
        public frmRezervasyon()
        {
            InitializeComponent();
        }
        public string film_Adi = "";
        public string salon_Adi = "";
        public string seans = "";
        ArrayList koltuklar = new ArrayList();
        ArrayList iptalKoltuk = new ArrayList();
        int filmID = 0;
        int salonID = 0;

        private void frmRezervasyon_Load(object sender, EventArgs e)
        {
            lblFilmAdi.Text = film_Adi;
            lblSalonSeans.Text = salon_Adi + " / " + seans;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToLongTimeString();
            lblTarih.Text = DateTime.Now.Date.ToShortDateString();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmGenel frmG = new frmGenel();
            frmG.Show();
            this.Hide();
        }
    }
}
