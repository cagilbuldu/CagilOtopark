namespace CagilOtopark.Ekranlar.Abonelik
{
    partial class AboneTipiEkleFrm
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
            this.btnkaydet = new System.Windows.Forms.Button();
            this.txtSaatlikUcret = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAbonelikTipiAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnkaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkaydet.Location = new System.Drawing.Point(222, 101);
            this.btnkaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(79, 27);
            this.btnkaydet.TabIndex = 30;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // txtSaatlikUcret
            // 
            this.txtSaatlikUcret.Location = new System.Drawing.Point(133, 62);
            this.txtSaatlikUcret.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaatlikUcret.Name = "txtSaatlikUcret";
            this.txtSaatlikUcret.Size = new System.Drawing.Size(168, 20);
            this.txtSaatlikUcret.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.label5.Location = new System.Drawing.Point(11, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 18);
            this.label5.TabIndex = 28;
            this.label5.Text = "Saatlik Ücret :";
            // 
            // txtAbonelikTipiAdi
            // 
            this.txtAbonelikTipiAdi.Location = new System.Drawing.Point(133, 22);
            this.txtAbonelikTipiAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtAbonelikTipiAdi.Name = "txtAbonelikTipiAdi";
            this.txtAbonelikTipiAdi.Size = new System.Drawing.Size(168, 20);
            this.txtAbonelikTipiAdi.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.label6.Location = new System.Drawing.Point(11, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 18);
            this.label6.TabIndex = 26;
            this.label6.Text = "Abone Türü Adı :";
            // 
            // AboneTipiEkleFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(315, 144);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.txtSaatlikUcret);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAbonelikTipiAdi);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AboneTipiEkleFrm";
            this.Text = "Abone Türü Ekleme Formu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAbonelikTipiAdi;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtSaatlikUcret;
    }
}