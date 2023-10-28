namespace CagilOtopark.Ekranlar.Raporlar
{
    partial class Rapor_2Frm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvRapor2 = new System.Windows.Forms.DataGridView();
            this.tctPlaka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.lblToplamKazanc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapor2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRapor2
            // 
            this.dgvRapor2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRapor2.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvRapor2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRapor2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRapor2.Location = new System.Drawing.Point(-1, 109);
            this.dgvRapor2.Name = "dgvRapor2";
            this.dgvRapor2.Size = new System.Drawing.Size(803, 344);
            this.dgvRapor2.TabIndex = 0;
            // 
            // tctPlaka
            // 
            this.tctPlaka.Location = new System.Drawing.Point(351, 25);
            this.tctPlaka.Name = "tctPlaka";
            this.tctPlaka.Size = new System.Drawing.Size(128, 20);
            this.tctPlaka.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(243, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Plaka Giriniz :";
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(404, 65);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 3;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // lblToplamKazanc
            // 
            this.lblToplamKazanc.AutoSize = true;
            this.lblToplamKazanc.Location = new System.Drawing.Point(614, 75);
            this.lblToplamKazanc.Name = "lblToplamKazanc";
            this.lblToplamKazanc.Size = new System.Drawing.Size(87, 13);
            this.lblToplamKazanc.TabIndex = 4;
            this.lblToplamKazanc.Text = "Toplam Kazanç :";
            // 
            // Rapor_2Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblToplamKazanc);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tctPlaka);
            this.Controls.Add(this.dgvRapor2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Rapor_2Frm";
            this.Text = "Plakaya Göre Giriş Çıkış Bilgileri";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapor2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRapor2;
        private System.Windows.Forms.TextBox tctPlaka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label lblToplamKazanc;
    }
}