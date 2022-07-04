
namespace FormDersleri
{
    partial class OneApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OneApp));
            this.label1 = new System.Windows.Forms.Label();
            this.txtVeri = new System.Windows.Forms.TextBox();
            this.btnVeriEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LsBVeriler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eklenecek Veriler";
            // 
            // txtVeri
            // 
            this.txtVeri.Location = new System.Drawing.Point(15, 48);
            this.txtVeri.Name = "txtVeri";
            this.txtVeri.Size = new System.Drawing.Size(219, 22);
            this.txtVeri.TabIndex = 1;
            // 
            // btnVeriEkle
            // 
            this.btnVeriEkle.Location = new System.Drawing.Point(12, 85);
            this.btnVeriEkle.Name = "btnVeriEkle";
            this.btnVeriEkle.Size = new System.Drawing.Size(222, 23);
            this.btnVeriEkle.TabIndex = 2;
            this.btnVeriEkle.Text = "Eklenecek Veriler";
            this.btnVeriEkle.UseVisualStyleBackColor = true;
            this.btnVeriEkle.Click += new System.EventHandler(this.btnVeriEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Eklenen Veriler";
            // 
            // LsBVeriler
            // 
            this.LsBVeriler.FormattingEnabled = true;
            this.LsBVeriler.ItemHeight = 16;
            this.LsBVeriler.Location = new System.Drawing.Point(15, 167);
            this.LsBVeriler.Name = "LsBVeriler";
            this.LsBVeriler.Size = new System.Drawing.Size(215, 260);
            this.LsBVeriler.TabIndex = 4;
            // 
            // OneApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 450);
            this.Controls.Add(this.LsBVeriler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVeriEkle);
            this.Controls.Add(this.txtVeri);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OneApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İlk Uygulamam";
            this.Load += new System.EventHandler(this.OneApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVeri;
        private System.Windows.Forms.Button btnVeriEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LsBVeriler;
    }
}

