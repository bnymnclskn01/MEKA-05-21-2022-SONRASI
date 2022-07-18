using System;
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
    public partial class frmGenel : Form
    {
        Baglanti baglanti = new Baglanti();
        public frmGenel()
        {
            InitializeComponent();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            DialogResult Mesaj = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Bilgilendirme Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Mesaj == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnYeniFilmEkle_Click(object sender, EventArgs e)
        {
            frmFilmler filmler = new frmFilmler();
            filmler.ShowDialog();
        }

        private void btnRezervasyonYap_Click(object sender, EventArgs e)
        {
            baglanti.BaglantiKur();
        }
    }
}
