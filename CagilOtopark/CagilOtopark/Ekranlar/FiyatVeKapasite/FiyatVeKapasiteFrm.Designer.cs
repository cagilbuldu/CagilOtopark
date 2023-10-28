namespace CagilOtopark.Ekranlar.FiyatVeKapasite
{
    partial class FiyatVeKapasiteFrm
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
            this.nmrVarsayilanFiyat = new System.Windows.Forms.NumericUpDown();
            this.nmrKapasite = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnkaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrVarsayilanFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrKapasite)).BeginInit();
            this.SuspendLayout();
            // 
            // nmrVarsayilanFiyat
            // 
            this.nmrVarsayilanFiyat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nmrVarsayilanFiyat.Location = new System.Drawing.Point(36, 48);
            this.nmrVarsayilanFiyat.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrVarsayilanFiyat.Name = "nmrVarsayilanFiyat";
            this.nmrVarsayilanFiyat.Size = new System.Drawing.Size(100, 16);
            this.nmrVarsayilanFiyat.TabIndex = 0;
            // 
            // nmrKapasite
            // 
            this.nmrKapasite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nmrKapasite.Location = new System.Drawing.Point(183, 48);
            this.nmrKapasite.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrKapasite.Name = "nmrKapasite";
            this.nmrKapasite.Size = new System.Drawing.Size(100, 16);
            this.nmrKapasite.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(37, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Varsayılan Fiyat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(204, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kapasite";
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnkaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkaydet.Location = new System.Drawing.Point(119, 88);
            this.btnkaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(74, 22);
            this.btnkaydet.TabIndex = 31;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // FiyatVeKapasiteFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(323, 130);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmrKapasite);
            this.Controls.Add(this.nmrVarsayilanFiyat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FiyatVeKapasiteFrm";
            this.Text = "Varsayılan Fiyat ve Kapasite Ayarı";
            this.Load += new System.EventHandler(this.FiyatVeKapasiteFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrVarsayilanFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrKapasite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmrVarsayilanFiyat;
        private System.Windows.Forms.NumericUpDown nmrKapasite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnkaydet;
    }
}