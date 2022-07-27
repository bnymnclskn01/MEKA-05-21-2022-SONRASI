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
    public partial class frmFilmler : Form
    {
        Baglanti baglanti = new Baglanti();
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
        bool durum;
        void tekrar()
        {
            baglanti.BaglantiKur();
            SqlCommand cmd = new SqlCommand("Select * from Filmler where Film_Adi= @p1", baglanti.sqlConnection);
            cmd.Parameters.AddWithValue("@p1", txtFilmAdi.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            baglanti.sqlConnection.Close();
        }

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            DialogResult Mesaj = MessageBox.Show("Yeni Kayıt Oluşturmak İstiyor Musunuz ?", "Bilgi Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (txtFilmAdi.Text == "" || txtYonetmen.Text == "" || txtFilmTuru.Text == "" || txtAciklama.Text == "") { MessageBox.Show("Boş bırakılamaz !"); }
            else
            {
                tekrar();
                if (durum == true)
                {
                    if (Mesaj == DialogResult.Yes)
                    {
                        baglanti.BaglantiKur();
                        SqlCommand cmd = new SqlCommand();

                        cmd.CommandText = "INSERT INTO Filmler(Film_Adi,Yonetmen,Film_Tur,Film_Aciklama) VALUES('" + txtFilmAdi.Text + "','" + txtYonetmen.Text + "','" + txtFilmTuru.Text + "','" + txtAciklama.Text + "')";
                        cmd.Connection = baglanti.sqlConnection;

                        cmd.ExecuteNonQuery();

                        baglanti.sqlConnection.Close();

                        MessageBox.Show("İstediğiniz film kayıdı = " + txtFilmAdi.Text + " " + " kayıt başarıyla eklenmiştir.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtAciklama.Clear();
                        txtFilmAdi.Clear();
                        txtFilmTuru.Clear();
                        txtYonetmen.Clear();
                    }
                    else
                    {
                    }
                    
                }
                else { MessageBox.Show("Eklemek istediğiniz film zaten mevcut !"); }
            }
        }
    }
}
