
namespace FormDersleri
{
    partial class BurakKingChrome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BurakKingChrome));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGit = new System.Windows.Forms.Button();
            this.txtAramaYeri = new System.Windows.Forms.TextBox();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnIleri = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGit);
            this.groupBox1.Controls.Add(this.txtAramaYeri);
            this.groupBox1.Controls.Add(this.btnYenile);
            this.groupBox1.Controls.Add(this.btnIleri);
            this.groupBox1.Controls.Add(this.btnGeri);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1445, 110);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btnGit
            // 
            this.btnGit.Location = new System.Drawing.Point(1364, 17);
            this.btnGit.Name = "btnGit";
            this.btnGit.Size = new System.Drawing.Size(75, 34);
            this.btnGit.TabIndex = 9;
            this.btnGit.Text = "Git";
            this.btnGit.UseVisualStyleBackColor = true;
            this.btnGit.Click += new System.EventHandler(this.btnGit_Click);
            // 
            // txtAramaYeri
            // 
            this.txtAramaYeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAramaYeri.Location = new System.Drawing.Point(244, 21);
            this.txtAramaYeri.Name = "txtAramaYeri";
            this.txtAramaYeri.Size = new System.Drawing.Size(1114, 27);
            this.txtAramaYeri.TabIndex = 8;
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(163, 17);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(75, 34);
            this.btnYenile.TabIndex = 7;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnIleri
            // 
            this.btnIleri.Location = new System.Drawing.Point(82, 17);
            this.btnIleri.Name = "btnIleri";
            this.btnIleri.Size = new System.Drawing.Size(75, 34);
            this.btnIleri.TabIndex = 6;
            this.btnIleri.Text = "İleri";
            this.btnIleri.UseVisualStyleBackColor = true;
            this.btnIleri.Click += new System.EventHandler(this.btnIleri_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(1, 17);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 34);
            this.btnGeri.TabIndex = 5;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.webBrowser1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1445, 691);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 18);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1439, 670);
            this.webBrowser1.TabIndex = 6;
            // 
            // BurakKingChrome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 801);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BurakKingChrome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Burak King Chrome";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGit;
        private System.Windows.Forms.TextBox txtAramaYeri;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnIleri;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}