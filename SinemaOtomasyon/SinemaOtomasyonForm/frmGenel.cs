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

        void ComboboxDataGetList(string sql, ComboBox cmb)
        {
            cmb.Items.Clear();
            baglanti.BaglantiKur();
            SqlCommand cmd = new SqlCommand(sql, baglanti.sqlConnection);
            SqlDataReader read = cmd.ExecuteReader();
            while(read.Read())
            {
                cmb.Items.Add(read[1].ToString());
            }
            baglanti.sqlConnection.Close();
        }

        private void btnYeniFilmEkle_Click(object sender, EventArgs e)
        {
            frmFilmler filmler = new frmFilmler();
            filmler.ShowDialog();
        }

        private void btnRezervasyonYap_Click(object sender, EventArgs e)
        {
            if (cbFilm.SelectedIndex != -1 && cbSalon.SelectedIndex != -1 && cbSeans.SelectedIndex != -1)
            {
                frmRezervasyon rezervasyon = new frmRezervasyon();
                rezervasyon.film_Adi = cbFilm.Text;
                rezervasyon.salon_Adi = cbSalon.Text;
                rezervasyon.seans = cbSeans.Text;
                rezervasyon.Show();
                this.Hide();
            }
        }

        private void frmGenel_Load(object sender, EventArgs e)
        {
            ComboboxDataGetList("SELECT * FROM Filmler", cbFilm);
            ComboboxDataGetList("SELECT * FROM Salonlar", cbSalon);
        }

        private void btnYeniSalonEkle_Click(object sender, EventArgs e)
        {
            frmSalonlar salonlar = new frmSalonlar();
            salonlar.ShowDialog();
        }
    }
}
