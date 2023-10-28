namespace CagilOtopark.Ekranlar.Raporlar
{
    partial class Rapor_3Frm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvRapor3 = new System.Windows.Forms.DataGridView();
            this.cmbAbone = new System.Windows.Forms.ComboBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblToplamKazanc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapor3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRapor3
            // 
            this.dgvRapor3.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvRapor3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRapor3.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRapor3.Location = new System.Drawing.Point(0, 110);
            this.dgvRapor3.Name = "dgvRapor3";
            this.dgvRapor3.Size = new System.Drawing.Size(801, 342);
            this.dgvRapor3.TabIndex = 0;
            // 
            // cmbAbone
            // 
            this.cmbAbone.FormattingEnabled = true;
            this.cmbAbone.Location = new System.Drawing.Point(382, 28);
            this.cmbAbone.Name = "cmbAbone";
            this.cmbAbone.Size = new System.Drawing.Size(121, 21);
            this.cmbAbone.TabIndex = 1;
            this.cmbAbone.SelectedIndexChanged += new System.EventHandler(this.cmbAbone_SelectedIndexChanged);
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(428, 68);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(263, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Abonelik Türü :";
            // 
            // lblToplamKazanc
            // 
            this.lblToplamKazanc.AutoSize = true;
            this.lblToplamKazanc.Location = new System.Drawing.Point(611, 78);
            this.lblToplamKazanc.Name = "lblToplamKazanc";
            this.lblToplamKazanc.Size = new System.Drawing.Size(90, 13);
            this.lblToplamKazanc.TabIndex = 4;
            this.lblToplamKazanc.Text = "Toplam Kazanç : ";
            // 
            // Rapor_3Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblToplamKazanc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.cmbAbone);
            this.Controls.Add(this.dgvRapor3);
            this.Name = "Rapor_3Frm";
            this.Text = "Abonelik Türüne Göre Giriş Çıkış Kayıtları";
            this.Load += new System.EventHandler(this.Rapor_3Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapor3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRapor3;
        private System.Windows.Forms.ComboBox cmbAbone;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToplamKazanc;
    }
}