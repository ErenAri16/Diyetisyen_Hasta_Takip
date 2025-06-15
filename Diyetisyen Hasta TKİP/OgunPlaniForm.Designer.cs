namespace Diyetisyen_Hasta_TKİP
{
    partial class OgunPlaniForm
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
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNotlar = new System.Windows.Forms.TextBox();
            this.chkTamamlandi = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblToplamYag = new System.Windows.Forms.Label();
            this.lblToplamKarbonhidrat = new System.Windows.Forms.Label();
            this.lblToplamProtein = new System.Windows.Forms.Label();
            this.lblToplamKalori = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOgunSil = new System.Windows.Forms.Button();
            this.btnOgunDuzenle = new System.Windows.Forms.Button();
            this.btnOgunEkle = new System.Windows.Forms.Button();
            this.lstOgunler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpTarih
            // 
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(89, 12);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 20);
            this.dtpTarih.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tarih";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Notlar";
            // 
            // txtNotlar
            // 
            this.txtNotlar.Location = new System.Drawing.Point(89, 38);
            this.txtNotlar.Multiline = true;
            this.txtNotlar.Name = "txtNotlar";
            this.txtNotlar.Size = new System.Drawing.Size(200, 60);
            this.txtNotlar.TabIndex = 3;
            // 
            // chkTamamlandi
            // 
            this.chkTamamlandi.AutoSize = true;
            this.chkTamamlandi.Location = new System.Drawing.Point(89, 104);
            this.chkTamamlandi.Name = "chkTamamlandi";
            this.chkTamamlandi.Size = new System.Drawing.Size(85, 17);
            this.chkTamamlandi.TabIndex = 4;
            this.chkTamamlandi.Text = "Tamamlandı";
            this.chkTamamlandi.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblToplamYag);
            this.groupBox1.Controls.Add(this.lblToplamKarbonhidrat);
            this.groupBox1.Controls.Add(this.lblToplamProtein);
            this.groupBox1.Controls.Add(this.lblToplamKalori);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 100);
            this.groupBox1.TabIndex = 5;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Toplam Yağ (g)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Toplam Yağ (g)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Toplam Yağ (g)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Toplam Yağ (g)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOgunSil);
            this.groupBox2.Controls.Add(this.btnOgunDuzenle);
            this.groupBox2.Controls.Add(this.btnOgunEkle);
            this.groupBox2.Controls.Add(this.lstOgunler);
            this.groupBox2.Location = new System.Drawing.Point(12, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 200);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğünler";
            // 
            // btnOgunSil
            // 
            this.btnOgunSil.Location = new System.Drawing.Point(196, 171);
            this.btnOgunSil.Name = "btnOgunSil";
            this.btnOgunSil.Size = new System.Drawing.Size(75, 23);
            this.btnOgunSil.TabIndex = 3;
            this.btnOgunSil.Text = "Sil";
            this.btnOgunSil.UseVisualStyleBackColor = true;
            this.btnOgunSil.Click += new System.EventHandler(this.btnOgunSil_Click);
            // 
            // btnOgunDuzenle
            // 
            this.btnOgunDuzenle.Location = new System.Drawing.Point(115, 171);
            this.btnOgunDuzenle.Name = "btnOgunDuzenle";
            this.btnOgunDuzenle.Size = new System.Drawing.Size(75, 23);
            this.btnOgunDuzenle.TabIndex = 2;
            this.btnOgunDuzenle.Text = "Düzenle";
            this.btnOgunDuzenle.UseVisualStyleBackColor = true;
            this.btnOgunDuzenle.Click += new System.EventHandler(this.btnOgunDuzenle_Click);
            // 
            // btnOgunEkle
            // 
            this.btnOgunEkle.Location = new System.Drawing.Point(34, 171);
            this.btnOgunEkle.Name = "btnOgunEkle";
            this.btnOgunEkle.Size = new System.Drawing.Size(75, 23);
            this.btnOgunEkle.TabIndex = 1;
            this.btnOgunEkle.Text = "Ekle";
            this.btnOgunEkle.UseVisualStyleBackColor = true;
            this.btnOgunEkle.Click += new System.EventHandler(this.btnOgunEkle_Click);
            // 
            // lstOgunler
            // 
            this.lstOgunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstOgunler.FullRowSelect = true;
            this.lstOgunler.GridLines = true;
            this.lstOgunler.Location = new System.Drawing.Point(6, 19);
            this.lstOgunler.Name = "lstOgunler";
            this.lstOgunler.Size = new System.Drawing.Size(265, 146);
            this.lstOgunler.TabIndex = 0;
            this.lstOgunler.UseCompatibleStateImageBehavior = false;
            this.lstOgunler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Öğün Adı";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Saat";
            this.columnHeader2.Width = 60;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kalori";
            this.columnHeader3.Width = 60;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tamamlandı";
            this.columnHeader4.Width = 65;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(133, 439);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(214, 439);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 23);
            this.btnIptal.TabIndex = 8;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // OgunPlaniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 474);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkTamamlandi);
            this.Controls.Add(this.txtNotlar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpTarih);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OgunPlaniForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Öğün Planı";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNotlar;
        private System.Windows.Forms.CheckBox chkTamamlandi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblToplamYag;
        private System.Windows.Forms.Label lblToplamKarbonhidrat;
        private System.Windows.Forms.Label lblToplamProtein;
        private System.Windows.Forms.Label lblToplamKalori;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOgunSil;
        private System.Windows.Forms.Button btnOgunDuzenle;
        private System.Windows.Forms.Button btnOgunEkle;
        private System.Windows.Forms.ListView lstOgunler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
    }
} 