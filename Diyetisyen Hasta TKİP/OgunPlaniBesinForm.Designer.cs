namespace Diyetisyen_Hasta_TKİP
{
    partial class OgunPlaniBesinForm
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
            this.cmbBesin = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numMiktar = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBirim = new System.Windows.Forms.TextBox();
            this.chkTamamlandi = new System.Windows.Forms.CheckBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numMiktar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Besin";
            // 
            // cmbBesin
            // 
            this.cmbBesin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBesin.FormattingEnabled = true;
            this.cmbBesin.Location = new System.Drawing.Point(89, 12);
            this.cmbBesin.Name = "cmbBesin";
            this.cmbBesin.Size = new System.Drawing.Size(200, 21);
            this.cmbBesin.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Miktar";
            // 
            // numMiktar
            // 
            this.numMiktar.DecimalPlaces = 1;
            this.numMiktar.Location = new System.Drawing.Point(89, 39);
            this.numMiktar.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMiktar.Name = "numMiktar";
            this.numMiktar.Size = new System.Drawing.Size(200, 20);
            this.numMiktar.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Birim";
            // 
            // txtBirim
            // 
            this.txtBirim.Location = new System.Drawing.Point(89, 65);
            this.txtBirim.Name = "txtBirim";
            this.txtBirim.Size = new System.Drawing.Size(200, 20);
            this.txtBirim.TabIndex = 5;
            // 
            // chkTamamlandi
            // 
            this.chkTamamlandi.AutoSize = true;
            this.chkTamamlandi.Location = new System.Drawing.Point(89, 91);
            this.chkTamamlandi.Name = "chkTamamlandi";
            this.chkTamamlandi.Size = new System.Drawing.Size(85, 17);
            this.chkTamamlandi.TabIndex = 6;
            this.chkTamamlandi.Text = "Tamamlandı";
            this.chkTamamlandi.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(133, 120);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(214, 120);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 23);
            this.btnIptal.TabIndex = 8;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // OgunPlaniBesinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 155);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.chkTamamlandi);
            this.Controls.Add(this.txtBirim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numMiktar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBesin);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OgunPlaniBesinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Besin";
            ((System.ComponentModel.ISupportInitialize)(this.numMiktar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBesin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numMiktar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBirim;
        private System.Windows.Forms.CheckBox chkTamamlandi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
    }
} 