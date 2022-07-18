
namespace SinemaOtomasyonForm
{
    partial class frmGenel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenel));
            this.cbFilm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSalon = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSeans = new System.Windows.Forms.ComboBox();
            this.btnRezervasyonYap = new System.Windows.Forms.Button();
            this.btnYeniFilmEkle = new System.Windows.Forms.Button();
            this.btnCikisYap = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbFilm
            // 
            this.cbFilm.BackColor = System.Drawing.SystemColors.Window;
            this.cbFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilm.FormattingEnabled = true;
            this.cbFilm.Location = new System.Drawing.Point(644, 91);
            this.cbFilm.Name = "cbFilm";
            this.cbFilm.Size = new System.Drawing.Size(277, 37);
            this.cbFilm.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(401, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Film Seçiniz.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(401, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Salon Seçiniz.";
            // 
            // cbSalon
            // 
            this.cbSalon.BackColor = System.Drawing.SystemColors.Window;
            this.cbSalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSalon.FormattingEnabled = true;
            this.cbSalon.Location = new System.Drawing.Point(644, 162);
            this.cbSalon.Name = "cbSalon";
            this.cbSalon.Size = new System.Drawing.Size(277, 37);
            this.cbSalon.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(401, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seans Seçiniz.";
            // 
            // cbSeans
            // 
            this.cbSeans.BackColor = System.Drawing.SystemColors.Window;
            this.cbSeans.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSeans.FormattingEnabled = true;
            this.cbSeans.Items.AddRange(new object[] {
            "11:00",
            "12:30",
            "14:00",
            "15:30",
            "17:00",
            "18:30",
            "20:00",
            "21:30",
            "23:00",
            "00:30"});
            this.cbSeans.Location = new System.Drawing.Point(644, 232);
            this.cbSeans.Name = "cbSeans";
            this.cbSeans.Size = new System.Drawing.Size(277, 37);
            this.cbSeans.TabIndex = 4;
            // 
            // btnRezervasyonYap
            // 
            this.btnRezervasyonYap.BackColor = System.Drawing.Color.DarkRed;
            this.btnRezervasyonYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezervasyonYap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRezervasyonYap.Location = new System.Drawing.Point(406, 308);
            this.btnRezervasyonYap.Name = "btnRezervasyonYap";
            this.btnRezervasyonYap.Size = new System.Drawing.Size(243, 40);
            this.btnRezervasyonYap.TabIndex = 6;
            this.btnRezervasyonYap.Text = "Bilet Rezervasyonu Yap";
            this.btnRezervasyonYap.UseVisualStyleBackColor = false;
            this.btnRezervasyonYap.Click += new System.EventHandler(this.btnRezervasyonYap_Click);
            // 
            // btnYeniFilmEkle
            // 
            this.btnYeniFilmEkle.BackColor = System.Drawing.Color.ForestGreen;
            this.btnYeniFilmEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYeniFilmEkle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnYeniFilmEkle.Location = new System.Drawing.Point(678, 308);
            this.btnYeniFilmEkle.Name = "btnYeniFilmEkle";
            this.btnYeniFilmEkle.Size = new System.Drawing.Size(243, 40);
            this.btnYeniFilmEkle.TabIndex = 7;
            this.btnYeniFilmEkle.Text = "Yeni Film Ekle";
            this.btnYeniFilmEkle.UseVisualStyleBackColor = false;
            this.btnYeniFilmEkle.Click += new System.EventHandler(this.btnYeniFilmEkle_Click);
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCikisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCikisYap.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCikisYap.Location = new System.Drawing.Point(678, 371);
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Size = new System.Drawing.Size(243, 87);
            this.btnCikisYap.TabIndex = 8;
            this.btnCikisYap.Text = "ÇIKIŞ YAP";
            this.btnCikisYap.UseVisualStyleBackColor = false;
            this.btnCikisYap.Click += new System.EventHandler(this.btnCikisYap_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(406, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "Yeni Salon Ekle";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmGenel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1488, 723);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCikisYap);
            this.Controls.Add(this.btnYeniFilmEkle);
            this.Controls.Add(this.btnRezervasyonYap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSeans);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSalon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFilm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGenel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "360MEKA | Sinema Otomasyonu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFilm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSalon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSeans;
        private System.Windows.Forms.Button btnRezervasyonYap;
        private System.Windows.Forms.Button btnYeniFilmEkle;
        private System.Windows.Forms.Button btnCikisYap;
        private System.Windows.Forms.Button button1;
    }
}

