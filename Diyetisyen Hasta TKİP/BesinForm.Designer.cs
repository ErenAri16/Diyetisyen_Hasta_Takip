namespace Diyetisyen_Hasta_TKİP
{
    partial class BesinForm
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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numKalori = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numProtein = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numKarbonhidrat = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numYag = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBirim = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numKalori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProtein)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKarbonhidrat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYag)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(89, 12);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(200, 20);
            this.txtAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kalori";
            // 
            // numKalori
            // 
            this.numKalori.DecimalPlaces = 1;
            this.numKalori.Location = new System.Drawing.Point(89, 38);
            this.numKalori.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numKalori.Name = "numKalori";
            this.numKalori.Size = new System.Drawing.Size(200, 20);
            this.numKalori.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Protein";
            // 
            // numProtein
            // 
            this.numProtein.DecimalPlaces = 1;
            this.numProtein.Location = new System.Drawing.Point(89, 64);
            this.numProtein.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numProtein.Name = "numProtein";
            this.numProtein.Size = new System.Drawing.Size(200, 20);
            this.numProtein.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Karbonhidrat";
            // 
            // numKarbonhidrat
            // 
            this.numKarbonhidrat.DecimalPlaces = 1;
            this.numKarbonhidrat.Location = new System.Drawing.Point(89, 90);
            this.numKarbonhidrat.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numKarbonhidrat.Name = "numKarbonhidrat";
            this.numKarbonhidrat.Size = new System.Drawing.Size(200, 20);
            this.numKarbonhidrat.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Yağ";
            // 
            // numYag
            // 
            this.numYag.DecimalPlaces = 1;
            this.numYag.Location = new System.Drawing.Point(89, 116);
            this.numYag.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numYag.Name = "numYag";
            this.numYag.Size = new System.Drawing.Size(200, 20);
            this.numYag.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Birim";
            // 
            // txtBirim
            // 
            this.txtBirim.Location = new System.Drawing.Point(89, 142);
            this.txtBirim.Name = "txtBirim";
            this.txtBirim.Size = new System.Drawing.Size(200, 20);
            this.txtBirim.TabIndex = 11;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(133, 174);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(214, 174);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 23);
            this.btnIptal.TabIndex = 13;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // BesinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 209);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtBirim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numYag);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numKarbonhidrat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numProtein);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numKalori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BesinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Besin";
            ((System.ComponentModel.ISupportInitialize)(this.numKalori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProtein)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKarbonhidrat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numKalori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numProtein;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numKarbonhidrat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numYag;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBirim;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
    }
} 