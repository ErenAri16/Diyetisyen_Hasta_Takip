namespace Diyetisyen_Hasta_TKİP
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnYeniHasta = new System.Windows.Forms.Button();
            this.btnHastaDuzenle = new System.Windows.Forms.Button();
            this.btnHastaSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(46, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kilonuzu Giriniz :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(46, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Boyunuzu Giriniz :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(577, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 101);
            this.button1.TabIndex = 2;
            this.button1.Text = "HESAPLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(316, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 38);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(316, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 38);
            this.textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(459, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(459, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "m";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(46, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sonuç :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(46, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 32);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tavsiyemiz :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(261, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 32);
            this.label7.TabIndex = 9;
            this.label7.Text = "?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(261, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 32);
            this.label8.TabIndex = 10;
            this.label8.Text = "?";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 400);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1073, 250);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnYeniHasta
            // 
            this.btnYeniHasta.Location = new System.Drawing.Point(12, 371);
            this.btnYeniHasta.Name = "btnYeniHasta";
            this.btnYeniHasta.Size = new System.Drawing.Size(120, 23);
            this.btnYeniHasta.TabIndex = 12;
            this.btnYeniHasta.Text = "Yeni Hasta";
            this.btnYeniHasta.UseVisualStyleBackColor = true;
            this.btnYeniHasta.Click += new System.EventHandler(this.btnYeniHasta_Click);
            // 
            // btnHastaDuzenle
            // 
            this.btnHastaDuzenle.Location = new System.Drawing.Point(138, 371);
            this.btnHastaDuzenle.Name = "btnHastaDuzenle";
            this.btnHastaDuzenle.Size = new System.Drawing.Size(120, 23);
            this.btnHastaDuzenle.TabIndex = 13;
            this.btnHastaDuzenle.Text = "Hasta Düzenle";
            this.btnHastaDuzenle.UseVisualStyleBackColor = true;
            this.btnHastaDuzenle.Click += new System.EventHandler(this.btnHastaDuzenle_Click);
            // 
            // btnHastaSil
            // 
            this.btnHastaSil.Location = new System.Drawing.Point(264, 371);
            this.btnHastaSil.Name = "btnHastaSil";
            this.btnHastaSil.Size = new System.Drawing.Size(120, 23);
            this.btnHastaSil.TabIndex = 14;
            this.btnHastaSil.Text = "Hasta Sil";
            this.btnHastaSil.UseVisualStyleBackColor = true;
            this.btnHastaSil.Click += new System.EventHandler(this.btnHastaSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1097, 662);
            this.Controls.Add(this.btnHastaSil);
            this.Controls.Add(this.btnHastaDuzenle);
            this.Controls.Add(this.btnYeniHasta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Diyetisyen Hasta Takip";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnYeniHasta;
        private System.Windows.Forms.Button btnHastaDuzenle;
        private System.Windows.Forms.Button btnHastaSil;
    }
}

