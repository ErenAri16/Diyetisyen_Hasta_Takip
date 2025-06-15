namespace Diyetisyen_Hasta_TKİP
{
    partial class IlermeGrafikForm
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
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnYenile = new System.Windows.Forms.Button();
            this.chartKilo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartVKI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartBelKalca = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvOlcumler = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartKilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVKI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBelKalca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOlcumler)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Location = new System.Drawing.Point(89, 12);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(200, 20);
            this.dtpBaslangic.TabIndex = 0;
            // 
            // dtpBitis
            // 
            this.dtpBitis.Location = new System.Drawing.Point(89, 38);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(200, 20);
            this.dtpBitis.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Başlangıç:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bitiş:";
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(295, 12);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(75, 46);
            this.btnYenile.TabIndex = 4;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // chartKilo
            // 
            this.chartKilo.Location = new System.Drawing.Point(12, 90);
            this.chartKilo.Name = "chartKilo";
            this.chartKilo.Size = new System.Drawing.Size(358, 200);
            this.chartKilo.TabIndex = 5;
            this.chartKilo.Text = "chart1";
            // 
            // chartVKI
            // 
            this.chartVKI.Location = new System.Drawing.Point(12, 320);
            this.chartVKI.Name = "chartVKI";
            this.chartVKI.Size = new System.Drawing.Size(358, 200);
            this.chartVKI.TabIndex = 6;
            this.chartVKI.Text = "chart2";
            // 
            // chartBelKalca
            // 
            this.chartBelKalca.Location = new System.Drawing.Point(12, 550);
            this.chartBelKalca.Name = "chartBelKalca";
            this.chartBelKalca.Size = new System.Drawing.Size(358, 200);
            this.chartBelKalca.TabIndex = 7;
            this.chartBelKalca.Text = "chart3";
            // 
            // dgvOlcumler
            // 
            this.dgvOlcumler.AllowUserToAddRows = false;
            this.dgvOlcumler.AllowUserToDeleteRows = false;
            this.dgvOlcumler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOlcumler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOlcumler.Location = new System.Drawing.Point(376, 90);
            this.dgvOlcumler.Name = "dgvOlcumler";
            this.dgvOlcumler.ReadOnly = true;
            this.dgvOlcumler.Size = new System.Drawing.Size(412, 660);
            this.dgvOlcumler.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kilo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "VKİ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 534);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Bel/Kalça Oranı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ölçümler";
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Location = new System.Drawing.Point(376, 12);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(75, 46);
            this.btnYeniKayit.TabIndex = 13;
            this.btnYeniKayit.Text = "Yeni Kayıt";
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // IlermeGrafikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 762);
            this.Controls.Add(this.btnYeniKayit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvOlcumler);
            this.Controls.Add(this.chartBelKalca);
            this.Controls.Add(this.chartVKI);
            this.Controls.Add(this.chartKilo);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.dtpBaslangic);
            this.Name = "IlermeGrafikForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İlerleme Grafikleri";
            this.Load += new System.EventHandler(this.IlermeGrafikForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartKilo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVKI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBelKalca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOlcumler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartKilo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVKI;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBelKalca;
        private System.Windows.Forms.DataGridView dgvOlcumler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnYeniKayit;
    }
} 