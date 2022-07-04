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
    public partial class BurakKingChrome : Form
    {
        public BurakKingChrome()
        {
            InitializeComponent();
        }

        private void btnGit_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtAramaYeri.Text);
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
    }
}
