using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDersleri
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Uyarı İşlemi", "Bilgilendirme Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog ==DialogResult.Yes)
            {
                txtAdiSoyadi.Clear();
                txtEposta.Clear();
                txtKulAdi.Clear();
                txtSifre.Clear();
                txtTelefonNo.Clear();
                txtSifreTekrar.Clear();
            }
            else
            {

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (txtSifre.PasswordChar.ToString() == "*")
            {
                txtSifre.PasswordChar = char.Parse("\0");
                txtSifreTekrar.PasswordChar = char.Parse("\0");
                checkBox1.Text = "Gizle";
            }
            else
            {
                txtSifre.PasswordChar = char.Parse("*");
                txtSifreTekrar.PasswordChar = char.Parse("*");
                checkBox1.Text = "Göster";
            }
        }

        private void btnKayitEt_Click(object sender, EventArgs e)
        {

        }

        private void txtAdiSoyadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txtTelefonNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
