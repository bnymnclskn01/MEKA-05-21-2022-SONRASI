using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonForm
{
    public partial class frmSalonlar : Form
    {
        Baglanti baglanti = new Baglanti();
        public frmSalonlar()
        {
            InitializeComponent();
        }

        private void btnSayfaKapat_Click(object sender, EventArgs e)
        {
            if (txtKoltukSayisi.Text != "" || txtSalonAdi.Text != "")
            {
                DialogResult Mesaj = MessageBox.Show("Sayfadan çıkış yapmak istediğinize emin misiniz?", "Bilgilendirme Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (Mesaj == DialogResult.Yes)
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
                txtKoltukSayisi.Clear();
                txtSalonAdi.Clear();
            }
        }

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            DialogResult Mesaj = MessageBox.Show("Yeni Kayıt Oluşturmak İstiyor Musunuz ?", "Bilgi Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Mesaj == DialogResult.Yes)
            {
                baglanti.BaglantiKur();
                SqlCommand cmd = new SqlCommand("INSERT INTO Salonlar (Salon_Adi,Koltuk_Sayisi) values('" + txtSalonAdi.Text + "'," + txtKoltukSayisi.Text + ")", baglanti.sqlConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("İstediğiniz salon kayıdı = " + txtSalonAdi.Text + " " + " kayıt başarıyla eklenmiştir.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKoltukSayisi.Clear();
                txtSalonAdi.Clear();
            }
            else
            {

            }
        }
    }
}
