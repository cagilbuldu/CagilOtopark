namespace CagilOtopark
{
    partial class AnaSayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCikisKaydi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGirisKaydi = new System.Windows.Forms.Button();
            this.btnAboneEkle = new System.Windows.Forms.Button();
            this.btnAboneleriListele = new System.Windows.Forms.Button();
            this.btnAboneTipiEkle = new System.Windows.Forms.Button();
            this.btnAboneTipleriniListele = new System.Windows.Forms.Button();
            this.btnKapasiteFiyat = new System.Windows.Forms.Button();
            this.btnRapor1 = new System.Windows.Forms.Button();
            this.btnRapor2 = new System.Windows.Forms.Button();
            this.btnRapor3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.btnCikisKaydi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnGirisKaydi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 450);
            this.panel1.TabIndex = 1;
            // 
            // btnCikisKaydi
            // 
            this.btnCikisKaydi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCikisKaydi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikisKaydi.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikisKaydi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCikisKaydi.Location = new System.Drawing.Point(100, 255);
            this.btnCikisKaydi.Name = "btnCikisKaydi";
            this.btnCikisKaydi.Size = new System.Drawing.Size(190, 76);
            this.btnCikisKaydi.TabIndex = 3;
            this.btnCikisKaydi.Text = "Otopark Çıkış Kaydı";
            this.btnCikisKaydi.UseVisualStyleBackColor = false;
            this.btnCikisKaydi.Click += new System.EventHandler(this.btnCikisKaydi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Location = new System.Drawing.Point(279, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "OTOPARK";
            // 
            // btnGirisKaydi
            // 
            this.btnGirisKaydi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGirisKaydi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGirisKaydi.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisKaydi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGirisKaydi.Location = new System.Drawing.Point(100, 117);
            this.btnGirisKaydi.Name = "btnGirisKaydi";
            this.btnGirisKaydi.Size = new System.Drawing.Size(190, 76);
            this.btnGirisKaydi.TabIndex = 2;
            this.btnGirisKaydi.Text = "Otopark Giriş Kaydı";
            this.btnGirisKaydi.UseVisualStyleBackColor = false;
            this.btnGirisKaydi.Click += new System.EventHandler(this.btnGirisKaydi_Click);
            // 
            // btnAboneEkle
            // 
            this.btnAboneEkle.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAboneEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboneEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAboneEkle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAboneEkle.Location = new System.Drawing.Point(458, 75);
            this.btnAboneEkle.Name = "btnAboneEkle";
            this.btnAboneEkle.Size = new System.Drawing.Size(290, 27);
            this.btnAboneEkle.TabIndex = 4;
            this.btnAboneEkle.Text = "Abone Ekle";
            this.btnAboneEkle.UseVisualStyleBackColor = false;
            this.btnAboneEkle.Click += new System.EventHandler(this.btnAboneEkle_Click);
            // 
            // btnAboneleriListele
            // 
            this.btnAboneleriListele.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAboneleriListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboneleriListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAboneleriListele.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAboneleriListele.Location = new System.Drawing.Point(458, 117);
            this.btnAboneleriListele.Name = "btnAboneleriListele";
            this.btnAboneleriListele.Size = new System.Drawing.Size(290, 27);
            this.btnAboneleriListele.TabIndex = 5;
            this.btnAboneleriListele.Text = "Aboneleri Listele";
            this.btnAboneleriListele.UseVisualStyleBackColor = false;
            this.btnAboneleriListele.Click += new System.EventHandler(this.btnAboneleriListele_Click);
            // 
            // btnAboneTipiEkle
            // 
            this.btnAboneTipiEkle.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAboneTipiEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboneTipiEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAboneTipiEkle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAboneTipiEkle.Location = new System.Drawing.Point(458, 158);
            this.btnAboneTipiEkle.Name = "btnAboneTipiEkle";
            this.btnAboneTipiEkle.Size = new System.Drawing.Size(290, 27);
            this.btnAboneTipiEkle.TabIndex = 6;
            this.btnAboneTipiEkle.Text = "Abone Türü Ekle";
            this.btnAboneTipiEkle.UseVisualStyleBackColor = false;
            this.btnAboneTipiEkle.Click += new System.EventHandler(this.btnAboneTipiEkle_Click);
            // 
            // btnAboneTipleriniListele
            // 
            this.btnAboneTipleriniListele.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAboneTipleriniListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboneTipleriniListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAboneTipleriniListele.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAboneTipleriniListele.Location = new System.Drawing.Point(458, 200);
            this.btnAboneTipleriniListele.Name = "btnAboneTipleriniListele";
            this.btnAboneTipleriniListele.Size = new System.Drawing.Size(290, 27);
            this.btnAboneTipleriniListele.TabIndex = 7;
            this.btnAboneTipleriniListele.Text = "Abone Türlerini Listele";
            this.btnAboneTipleriniListele.UseVisualStyleBackColor = false;
            this.btnAboneTipleriniListele.Click += new System.EventHandler(this.btnAboneTipleriniListele_Click);
            // 
            // btnKapasiteFiyat
            // 
            this.btnKapasiteFiyat.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnKapasiteFiyat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapasiteFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapasiteFiyat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKapasiteFiyat.Location = new System.Drawing.Point(458, 242);
            this.btnKapasiteFiyat.Name = "btnKapasiteFiyat";
            this.btnKapasiteFiyat.Size = new System.Drawing.Size(290, 27);
            this.btnKapasiteFiyat.TabIndex = 8;
            this.btnKapasiteFiyat.Text = "Kapasite / Fiyat Güncelleme";
            this.btnKapasiteFiyat.UseVisualStyleBackColor = false;
            this.btnKapasiteFiyat.Click += new System.EventHandler(this.btnKapasiteFiyat_Click);
            // 
            // btnRapor1
            // 
            this.btnRapor1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRapor1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRapor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRapor1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRapor1.Location = new System.Drawing.Point(458, 284);
            this.btnRapor1.Name = "btnRapor1";
            this.btnRapor1.Size = new System.Drawing.Size(290, 27);
            this.btnRapor1.TabIndex = 9;
            this.btnRapor1.Text = "Rapor 1";
            this.btnRapor1.UseVisualStyleBackColor = false;
            this.btnRapor1.Click += new System.EventHandler(this.btnRapor1_Click);
            // 
            // btnRapor2
            // 
            this.btnRapor2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRapor2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRapor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRapor2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRapor2.Location = new System.Drawing.Point(458, 327);
            this.btnRapor2.Name = "btnRapor2";
            this.btnRapor2.Size = new System.Drawing.Size(290, 27);
            this.btnRapor2.TabIndex = 10;
            this.btnRapor2.Text = "Rapor 2";
            this.btnRapor2.UseVisualStyleBackColor = false;
            this.btnRapor2.Click += new System.EventHandler(this.btnRapor2_Click);
            // 
            // btnRapor3
            // 
            this.btnRapor3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRapor3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRapor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRapor3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRapor3.Location = new System.Drawing.Point(458, 370);
            this.btnRapor3.Name = "btnRapor3";
            this.btnRapor3.Size = new System.Drawing.Size(290, 27);
            this.btnRapor3.TabIndex = 11;
            this.btnRapor3.Text = "Rapor 3";
            this.btnRapor3.UseVisualStyleBackColor = false;
            this.btnRapor3.Click += new System.EventHandler(this.btnRapor3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(761, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(403, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "OTOMASYONU";
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRapor3);
            this.Controls.Add(this.btnRapor2);
            this.Controls.Add(this.btnRapor1);
            this.Controls.Add(this.btnKapasiteFiyat);
            this.Controls.Add(this.btnAboneTipleriniListele);
            this.Controls.Add(this.btnAboneTipiEkle);
            this.Controls.Add(this.btnAboneleriListele);
            this.Controls.Add(this.btnAboneEkle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnaSayfa";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCikisKaydi;
        private System.Windows.Forms.Button btnGirisKaydi;
        private System.Windows.Forms.Button btnAboneEkle;
        private System.Windows.Forms.Button btnAboneleriListele;
        private System.Windows.Forms.Button btnAboneTipiEkle;
        private System.Windows.Forms.Button btnAboneTipleriniListele;
        private System.Windows.Forms.Button btnKapasiteFiyat;
        private System.Windows.Forms.Button btnRapor1;
        private System.Windows.Forms.Button btnRapor2;
        private System.Windows.Forms.Button btnRapor3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

