namespace Diyetisyen_Hasta_TKİP
{
    partial class OgunPlaniOgunForm
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
            this.txtOgunAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpSaat = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNotlar = new System.Windows.Forms.TextBox();
            this.chkTamamlandi = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblToplamYag = new System.Windows.Forms.Label();
            this.lblToplamKarbonhidrat = new System.Windows.Forms.Label();
            this.lblToplamProtein = new System.Windows.Forms.Label();
            this.lblToplamKalori = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBesinSil = new System.Windows.Forms.Button();
            this.btnBesinDuzenle = new System.Windows.Forms.Button();
            this.btnBesinEkle = new System.Windows.Forms.Button();
            this.lstBesinler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğün Adı";
            // 
            // txtOgunAdi
            // 
            this.txtOgunAdi.Location = new System.Drawing.Point(89, 12);
            this.txtOgunAdi.Name = "txtOgunAdi";
            this.txtOgunAdi.Size = new System.Drawing.Size(200, 20);
            this.txtOgunAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Saat";
            // 
            // dtpSaat
            // 
            this.dtpSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSaat.Location = new System.Drawing.Point(89, 38);
            this.dtpSaat.Name = "dtpSaat";
            this.dtpSaat.ShowUpDown = true;
            this.dtpSaat.Size = new System.Drawing.Size(200, 20);
            this.dtpSaat.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Notlar";
            // 
            // txtNotlar
            // 
            this.txtNotlar.Location = new System.Drawing.Point(89, 64);
            this.txtNotlar.Multiline = true;
            this.txtNotlar.Name = "txtNotlar";
            this.txtNotlar.Size = new System.Drawing.Size(200, 60);
            this.txtNotlar.TabIndex = 5;
            // 
            // chkTamamlandi
            // 
            this.chkTamamlandi.AutoSize = true;
            this.chkTamamlandi.Location = new System.Drawing.Point(89, 130);
            this.chkTamamlandi.Name = "chkTamamlandi";
            this.chkTamamlandi.Size = new System.Drawing.Size(85, 17);
            this.chkTamamlandi.TabIndex = 6;
            this.chkTamamlandi.Text = "Tamamlandı";
            this.chkTamamlandi.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblToplamYag);
            this.groupBox1.Controls.Add(this.lblToplamKarbonhidrat);
            this.groupBox1.Controls.Add(this.lblToplamProtein);
            this.groupBox1.Controls.Add(this.lblToplamKalori);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toplam Değerler";
            // 
            // lblToplamYag
            // 
            this.lblToplamYag.AutoSize = true;
            this.lblToplamYag.Location = new System.Drawing.Point(89, 72);
            this.lblToplamYag.Name = "lblToplamYag";
            this.lblToplamYag.Size = new System.Drawing.Size(13, 13);
            this.lblToplamYag.TabIndex = 7;
            this.lblToplamYag.Text = "0";
            // 
            // lblToplamKarbonhidrat
            // 
            this.lblToplamKarbonhidrat.AutoSize = true;
            this.lblToplamKarbonhidrat.Location = new System.Drawing.Point(89, 53);
            this.lblToplamKarbonhidrat.Name = "lblToplamKarbonhidrat";
            this.lblToplamKarbonhidrat.Size = new System.Drawing.Size(13, 13);
            this.lblToplamKarbonhidrat.TabIndex = 6;
            this.lblToplamKarbonhidrat.Text = "0";
            // 
            // lblToplamProtein
            // 
            this.lblToplamProtein.AutoSize = true;
            this.lblToplamProtein.Location = new System.Drawing.Point(89, 34);
            this.lblToplamProtein.Name = "lblToplamProtein";
            this.lblToplamProtein.Size = new System.Drawing.Size(13, 13);
            this.lblToplamProtein.TabIndex = 5;
            this.lblToplamProtein.Text = "0";
            // 
            // lblToplamKalori
            // 
            this.lblToplamKalori.AutoSize = true;
            this.lblToplamKalori.Location = new System.Drawing.Point(89, 15);
            this.lblToplamKalori.Name = "lblToplamKalori";
            this.lblToplamKalori.Size = new System.Drawing.Size(13, 13);
            this.lblToplamKalori.TabIndex = 4;
            this.lblToplamKalori.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Toplam Yağ (g)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Toplam Yağ (g)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Toplam Yağ (g)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Toplam Yağ (g)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBesinSil);
            this.groupBox2.Controls.Add(this.btnBesinDuzenle);
            this.groupBox2.Controls.Add(this.btnBesinEkle);
            this.groupBox2.Controls.Add(this.lstBesinler);
            this.groupBox2.Location = new System.Drawing.Point(12, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 200);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Besinler";
            // 
            // btnBesinSil
            // 
            this.btnBesinSil.Location = new System.Drawing.Point(196, 171);
            this.btnBesinSil.Name = "btnBesinSil";
            this.btnBesinSil.Size = new System.Drawing.Size(75, 23);
            this.btnBesinSil.TabIndex = 3;
            this.btnBesinSil.Text = "Sil";
            this.btnBesinSil.UseVisualStyleBackColor = true;
            this.btnBesinSil.Click += new System.EventHandler(this.btnBesinSil_Click);
            // 
            // btnBesinDuzenle
            // 
            this.btnBesinDuzenle.Location = new System.Drawing.Point(115, 171);
            this.btnBesinDuzenle.Name = "btnBesinDuzenle";
            this.btnBesinDuzenle.Size = new System.Drawing.Size(75, 23);
            this.btnBesinDuzenle.TabIndex = 2;
            this.btnBesinDuzenle.Text = "Düzenle";
            this.btnBesinDuzenle.UseVisualStyleBackColor = true;
            this.btnBesinDuzenle.Click += new System.EventHandler(this.btnBesinDuzenle_Click);
            // 
            // btnBesinEkle
            // 
            this.btnBesinEkle.Location = new System.Drawing.Point(34, 171);
            this.btnBesinEkle.Name = "btnBesinEkle";
            this.btnBesinEkle.Size = new System.Drawing.Size(75, 23);
            this.btnBesinEkle.TabIndex = 1;
            this.btnBesinEkle.Text = "Ekle";
            this.btnBesinEkle.UseVisualStyleBackColor = true;
            this.btnBesinEkle.Click += new System.EventHandler(this.btnBesinEkle_Click);
            // 
            // lstBesinler
            // 
            this.lstBesinler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstBesinler.FullRowSelect = true;
            this.lstBesinler.GridLines = true;
            this.lstBesinler.Location = new System.Drawing.Point(6, 19);
            this.lstBesinler.Name = "lstBesinler";
            this.lstBesinler.Size = new System.Drawing.Size(265, 146);
            this.lstBesinler.TabIndex = 0;
            this.lstBesinler.UseCompatibleStateImageBehavior = false;
            this.lstBesinler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Besin Adı";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Miktar";
            this.columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Birim";
            this.columnHeader3.Width = 40;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kalori";
            this.columnHeader4.Width = 50;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tamamlandı";
            this.columnHeader5.Width = 45;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(133, 465);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(214, 465);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 23);
            this.btnIptal.TabIndex = 10;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // OgunPlaniOgunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 500);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkTamamlandi);
            this.Controls.Add(this.txtNotlar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpSaat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOgunAdi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OgunPlaniOgunForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Öğün";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOgunAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpSaat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNotlar;
        private System.Windows.Forms.CheckBox chkTamamlandi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblToplamYag;
        private System.Windows.Forms.Label lblToplamKarbonhidrat;
        private System.Windows.Forms.Label lblToplamProtein;
        private System.Windows.Forms.Label lblToplamKalori;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBesinSil;
        private System.Windows.Forms.Button btnBesinDuzenle;
        private System.Windows.Forms.Button btnBesinEkle;
        private System.Windows.Forms.ListView lstBesinler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
    }
} 