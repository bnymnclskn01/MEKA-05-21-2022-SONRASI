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
    public partial class frmFilmler : Form
    {
        public frmFilmler()
        {
            InitializeComponent();
        }

        private void btnSayfaKapat_Click(object sender, EventArgs e)
        {
            if (txtFilmAdi.Text != "" || txtFilmTuru.Text != "" ||   txtYonetmen.Text != "" ||  txtAciklama.Text != "")
            {
                DialogResult Mesaj = MessageBox.Show("Sayfadan çıkış yapmak istediğinize emin misiniz?", "Bilgilendirme Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (Mesaj==DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btnAlanTemizle_Click(object sender, EventArgs e)
        {
            DialogResult Mesaj = MessageBox.Show("Sayfada girdiğiniz verileri temizlemek istediğinize emin misiniz?", "Bilgilendirme Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Mesaj == DialogResult.Yes)
            {
                txtAciklama.Clear();
                txtFilmAdi.Clear();
                txtFilmTuru.Clear();
                txtYonetmen.Clear();
            }

        }
    }
}
