namespace Diyetisyen_Hasta_TKİP
{
    partial class DiyetProgramiForm
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
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.txtHedefKilo = new System.Windows.Forms.TextBox();
            this.txtNotlar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOgunSil = new System.Windows.Forms.Button();
            this.btnOgunDuzenle = new System.Windows.Forms.Button();
            this.btnOgunEkle = new System.Windows.Forms.Button();
            this.lstOgunler = new System.Windows.Forms.ListBox();
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
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlangıç Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bitiş Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hedef Kilo:";
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
            // dtpBaslangic
            // 
            this.dtpBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBaslangic.Location = new System.Drawing.Point(107, 12);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(200, 20);
            this.dtpBaslangic.TabIndex = 4;
            // 
            // dtpBitis
            // 
            this.dtpBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBitis.Location = new System.Drawing.Point(107, 38);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(200, 20);
            this.dtpBitis.TabIndex = 5;
            // 
            // txtHedefKilo
            // 
            this.txtHedefKilo.Location = new System.Drawing.Point(107, 64);
            this.txtHedefKilo.Name = "txtHedefKilo";
            this.txtHedefKilo.Size = new System.Drawing.Size(200, 20);
            this.txtHedefKilo.TabIndex = 6;
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
            this.groupBox1.Controls.Add(this.btnOgunSil);
            this.groupBox1.Controls.Add(this.btnOgunDuzenle);
            this.groupBox1.Controls.Add(this.btnOgunEkle);
            this.groupBox1.Controls.Add(this.lstOgunler);
            this.groupBox1.Location = new System.Drawing.Point(12, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 200);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğünler";
            // 
            // btnOgunSil
            // 
            this.btnOgunSil.Enabled = false;
            this.btnOgunSil.Location = new System.Drawing.Point(214, 171);
            this.btnOgunSil.Name = "btnOgunSil";
            this.btnOgunSil.Size = new System.Drawing.Size(75, 23);
            this.btnOgunSil.TabIndex = 3;
            this.btnOgunSil.Text = "Sil";
            this.btnOgunSil.UseVisualStyleBackColor = true;
            this.btnOgunSil.Click += new System.EventHandler(this.btnOgunSil_Click);
            // 
            // btnOgunDuzenle
            // 
            this.btnOgunDuzenle.Enabled = false;
            this.btnOgunDuzenle.Location = new System.Drawing.Point(133, 171);
            this.btnOgunDuzenle.Name = "btnOgunDuzenle";
            this.btnOgunDuzenle.Size = new System.Drawing.Size(75, 23);
            this.btnOgunDuzenle.TabIndex = 2;
            this.btnOgunDuzenle.Text = "Düzenle";
            this.btnOgunDuzenle.UseVisualStyleBackColor = true;
            this.btnOgunDuzenle.Click += new System.EventHandler(this.btnOgunDuzenle_Click);
            // 
            // btnOgunEkle
            // 
            this.btnOgunEkle.Location = new System.Drawing.Point(52, 171);
            this.btnOgunEkle.Name = "btnOgunEkle";
            this.btnOgunEkle.Size = new System.Drawing.Size(75, 23);
            this.btnOgunEkle.TabIndex = 1;
            this.btnOgunEkle.Text = "Ekle";
            this.btnOgunEkle.UseVisualStyleBackColor = true;
            this.btnOgunEkle.Click += new System.EventHandler(this.btnOgunEkle_Click);
            // 
            // lstOgunler
            // 
            this.lstOgunler.FormattingEnabled = true;
            this.lstOgunler.Location = new System.Drawing.Point(6, 19);
            this.lstOgunler.Name = "lstOgunler";
            this.lstOgunler.Size = new System.Drawing.Size(283, 147);
            this.lstOgunler.TabIndex = 0;
            this.lstOgunler.SelectedIndexChanged += new System.EventHandler(this.lstOgunler_SelectedIndexChanged);
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
            // DiyetProgramiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 397);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNotlar);
            this.Controls.Add(this.txtHedefKilo);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.dtpBaslangic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DiyetProgramiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Diyet Programı Oluştur";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.TextBox txtHedefKilo;
        private System.Windows.Forms.TextBox txtNotlar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOgunSil;
        private System.Windows.Forms.Button btnOgunDuzenle;
        private System.Windows.Forms.Button btnOgunEkle;
        private System.Windows.Forms.ListBox lstOgunler;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
    }
} 