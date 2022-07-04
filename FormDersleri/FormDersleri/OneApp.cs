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
    public partial class OneApp : Form
    {
        public OneApp()
        {
            InitializeComponent();
        }
        int i = 0;
        string[] dizi = new string[10];
        private void OneApp_Load(object sender, EventArgs e)
        {

        }

        private void btnVeriEkle_Click(object sender, EventArgs e)
        {
            if (i < 10)
            {
                dizi[i] = txtVeri.Text;
                LsBVeriler.Items.Add(dizi[i]);
                i++;
                txtVeri.Clear();
                txtVeri.Focus();
            }
        }
    }
}
