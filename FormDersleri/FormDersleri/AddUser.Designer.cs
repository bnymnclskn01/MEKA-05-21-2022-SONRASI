
namespace FormDersleri
{
    partial class AddUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.txtAdiSoyadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKayitEt = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSifreTekrar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefonNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKulAdi = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtAdiSoyadi
            // 
            this.txtAdiSoyadi.Location = new System.Drawing.Point(15, 57);
            this.txtAdiSoyadi.MaxLength = 70;
            this.txtAdiSoyadi.Name = "txtAdiSoyadi";
            this.txtAdiSoyadi.Size = new System.Drawing.Size(225, 22);
            this.txtAdiSoyadi.TabIndex = 0;
            this.txtAdiSoyadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdiSoyadi_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı Soyadı";
            // 
            // btnKayitEt
            // 
            this.btnKayitEt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnKayitEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKayitEt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKayitEt.Location = new System.Drawing.Point(2, 237);
            this.btnKayitEt.Name = "btnKayitEt";
            this.btnKayitEt.Size = new System.Drawing.Size(272, 57);
            this.btnKayitEt.TabIndex = 2;
            this.btnKayitEt.Text = "Kullanıcıyı Kayıt Et";
            this.btnKayitEt.UseVisualStyleBackColor = false;
            this.btnKayitEt.Click += new System.EventHandler(this.btnKayitEt_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Red;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTemizle.Location = new System.Drawing.Point(280, 234);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(272, 57);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Verileri Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "E-Posta Adresi";
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(327, 57);
            this.txtEposta.MaxLength = 50;
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(225, 22);
            this.txtEposta.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Şifre";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(15, 132);
            this.txtSifre.MaxLength = 16;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(225, 22);
            this.txtSifre.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Şifre Tekrar";
            // 
            // txtSifreTekrar
            // 
            this.txtSifreTekrar.Location = new System.Drawing.Point(327, 132);
            this.txtSifreTekrar.MaxLength = 16;
            this.txtSifreTekrar.Name = "txtSifreTekrar";
            this.txtSifreTekrar.PasswordChar = '*';
            this.txtSifreTekrar.Size = new System.Drawing.Size(225, 22);
            this.txtSifreTekrar.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Telefon Numarası";
            // 
            // txtTelefonNo
            // 
            this.txtTelefonNo.Location = new System.Drawing.Point(15, 198);
            this.txtTelefonNo.MaxLength = 11;
            this.txtTelefonNo.Name = "txtTelefonNo";
            this.txtTelefonNo.Size = new System.Drawing.Size(225, 22);
            this.txtTelefonNo.TabIndex = 10;
            this.txtTelefonNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonNo_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Kullanıcı Adı";
            // 
            // txtKulAdi
            // 
            this.txtKulAdi.Location = new System.Drawing.Point(327, 198);
            this.txtKulAdi.MaxLength = 20;
            this.txtKulAdi.Name = "txtKulAdi";
            this.txtKulAdi.Size = new System.Drawing.Size(225, 22);
            this.txtKulAdi.TabIndex = 12;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(248, 134);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(73, 21);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 303);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtKulAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelefonNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSifreTekrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKayitEt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdiSoyadi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Kullanıcı Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdiSoyadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKayitEt;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSifreTekrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefonNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKulAdi;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}