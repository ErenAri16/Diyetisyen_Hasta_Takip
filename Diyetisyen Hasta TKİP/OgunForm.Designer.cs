namespace Diyetisyen_Hasta_TKİP
{
    partial class OgunForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOgunAdi = new System.Windows.Forms.TextBox();
            this.dtpSaat = new System.Windows.Forms.DateTimePicker();
            this.txtKalori = new System.Windows.Forms.TextBox();
            this.txtNotlar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBesinSil = new System.Windows.Forms.Button();
            this.btnBesinDuzenle = new System.Windows.Forms.Button();
            this.btnBesinEkle = new System.Windows.Forms.Button();
            this.lstBesinler = new System.Windows.Forms.ListBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğün Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kalori:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Notlar:";
            // 
            // txtOgunAdi
            // 
            this.txtOgunAdi.Location = new System.Drawing.Point(107, 12);
            this.txtOgunAdi.Name = "txtOgunAdi";
            this.txtOgunAdi.Size = new System.Drawing.Size(200, 20);
            this.txtOgunAdi.TabIndex = 4;
            // 
            // dtpSaat
            // 
            this.dtpSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSaat.Location = new System.Drawing.Point(107, 38);
            this.dtpSaat.Name = "dtpSaat";
            this.dtpSaat.ShowUpDown = true;
            this.dtpSaat.Size = new System.Drawing.Size(200, 20);
            this.dtpSaat.TabIndex = 5;
            // 
            // txtKalori
            // 
            this.txtKalori.Location = new System.Drawing.Point(107, 64);
            this.txtKalori.Name = "txtKalori";
            this.txtKalori.Size = new System.Drawing.Size(200, 20);
            this.txtKalori.TabIndex = 6;
            // 
            // txtNotlar
            // 
            this.txtNotlar.Location = new System.Drawing.Point(107, 90);
            this.txtNotlar.Multiline = true;
            this.txtNotlar.Name = "txtNotlar";
            this.txtNotlar.Size = new System.Drawing.Size(200, 60);
            this.txtNotlar.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBesinSil);
            this.groupBox1.Controls.Add(this.btnBesinDuzenle);
            this.groupBox1.Controls.Add(this.btnBesinEkle);
            this.groupBox1.Controls.Add(this.lstBesinler);
            this.groupBox1.Location = new System.Drawing.Point(12, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 200);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Besinler";
            // 
            // btnBesinSil
            // 
            this.btnBesinSil.Enabled = false;
            this.btnBesinSil.Location = new System.Drawing.Point(214, 171);
            this.btnBesinSil.Name = "btnBesinSil";
            this.btnBesinSil.Size = new System.Drawing.Size(75, 23);
            this.btnBesinSil.TabIndex = 3;
            this.btnBesinSil.Text = "Sil";
            this.btnBesinSil.UseVisualStyleBackColor = true;
            this.btnBesinSil.Click += new System.EventHandler(this.btnBesinSil_Click);
            // 
            // btnBesinDuzenle
            // 
            this.btnBesinDuzenle.Enabled = false;
            this.btnBesinDuzenle.Location = new System.Drawing.Point(133, 171);
            this.btnBesinDuzenle.Name = "btnBesinDuzenle";
            this.btnBesinDuzenle.Size = new System.Drawing.Size(75, 23);
            this.btnBesinDuzenle.TabIndex = 2;
            this.btnBesinDuzenle.Text = "Düzenle";
            this.btnBesinDuzenle.UseVisualStyleBackColor = true;
            this.btnBesinDuzenle.Click += new System.EventHandler(this.btnBesinDuzenle_Click);
            // 
            // btnBesinEkle
            // 
            this.btnBesinEkle.Location = new System.Drawing.Point(52, 171);
            this.btnBesinEkle.Name = "btnBesinEkle";
            this.btnBesinEkle.Size = new System.Drawing.Size(75, 23);
            this.btnBesinEkle.TabIndex = 1;
            this.btnBesinEkle.Text = "Ekle";
            this.btnBesinEkle.UseVisualStyleBackColor = true;
            this.btnBesinEkle.Click += new System.EventHandler(this.btnBesinEkle_Click);
            // 
            // lstBesinler
            // 
            this.lstBesinler.FormattingEnabled = true;
            this.lstBesinler.Location = new System.Drawing.Point(6, 19);
            this.lstBesinler.Name = "lstBesinler";
            this.lstBesinler.Size = new System.Drawing.Size(283, 147);
            this.lstBesinler.TabIndex = 0;
            this.lstBesinler.SelectedIndexChanged += new System.EventHandler(this.lstBesinler_SelectedIndexChanged);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(151, 362);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(232, 362);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 23);
            this.btnIptal.TabIndex = 10;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // OgunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 397);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNotlar);
            this.Controls.Add(this.txtKalori);
            this.Controls.Add(this.dtpSaat);
            this.Controls.Add(this.txtOgunAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OgunForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Öğün Ekle/Düzenle";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOgunAdi;
        private System.Windows.Forms.DateTimePicker dtpSaat;
        private System.Windows.Forms.TextBox txtKalori;
        private System.Windows.Forms.TextBox txtNotlar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBesinSil;
        private System.Windows.Forms.Button btnBesinDuzenle;
        private System.Windows.Forms.Button btnBesinEkle;
        private System.Windows.Forms.ListBox lstBesinler;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
    }
} 