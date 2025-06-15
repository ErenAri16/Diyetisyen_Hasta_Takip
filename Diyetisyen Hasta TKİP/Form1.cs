using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diyetisyen_Hasta_TKİP.Models;
using Diyetisyen_Hasta_TKİP.Services;

namespace Diyetisyen_Hasta_TKİP
{
    public partial class Form1 : Form
    {
        private List<Hasta> hastalar;
        private Hasta seciliHasta;

        public Form1()
        {
            InitializeComponent();
            HastalariYukle();
        }

        private void HastalariYukle()
        {
            try
            {
                hastalar = HastaService.TumHastalariGetir();
                dataGridView1.DataSource = hastalar;
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Columns["VucutKitleIndeksi"].Visible = false;
                dataGridView1.Columns["VucutKitleIndeksiDurumu"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hastalar yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("Lütfen kilo ve boy bilgilerini giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double kilo = Convert.ToDouble(textBox1.Text);
                double boy = Convert.ToDouble(textBox2.Text);

                if (kilo <= 0 || boy <= 0)
                {
                    MessageBox.Show("Kilo ve boy değerleri 0'dan büyük olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double boykare = Math.Pow(boy, 2);
                double sonuc = kilo / boykare;
                label8.Text = sonuc.ToString("F2");

                if (sonuc < 18)
                {
                    label7.Text = "İdeal kilonuzun altındasınız, kilo almanız sağlığınız için iyi olur";
                    label7.ForeColor = Color.Green;
                }
                else if (sonuc < 25)
                {
                    label7.Text = "İdeal kilodasınız";
                    label7.ForeColor = Color.Green;
                }
                else if (sonuc < 30)
                {
                    label7.Text = "İdeal kilonuzun biraz üstündesiniz, beslenmenize dikkat edin";
                    label7.ForeColor = Color.Yellow;
                }
                else if (sonuc < 35)
                {
                    label7.Text = "Obezsiniz sağlık kurumuna başvurmanız gerekiyor";
                    label7.ForeColor = Color.Orange;
                }
                else
                {
                    label7.Text = "Morbid obezsiniz, Acilen bir sağlık kurumuna başvurun";
                    label7.ForeColor = Color.Red;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli sayısal değerler giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnYeniHasta_Click(object sender, EventArgs e)
        {
            HastaForm hastaForm = new HastaForm();
            if (hastaForm.ShowDialog() == DialogResult.OK)
            {
                HastalariYukle();
            }
        }

        private void btnHastaDuzenle_Click(object sender, EventArgs e)
        {
            if (seciliHasta != null)
            {
                HastaForm hastaForm = new HastaForm(seciliHasta);
                if (hastaForm.ShowDialog() == DialogResult.OK)
                {
                    HastalariYukle();
                }
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek için bir hasta seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHastaSil_Click(object sender, EventArgs e)
        {
            if (seciliHasta != null)
            {
                if (MessageBox.Show("Seçili hastayı silmek istediğinizden emin misiniz?", "Onay", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (HastaService.HastaSil(seciliHasta.Id))
                    {
                        MessageBox.Show("Hasta başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HastalariYukle();
                    }
                    else
                    {
                        MessageBox.Show("Hasta silinirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir hasta seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                seciliHasta = (Hasta)dataGridView1.SelectedRows[0].DataBoundItem;
                textBox1.Text = seciliHasta.Kilo.ToString();
                textBox2.Text = seciliHasta.Boy.ToString();
                button1_Click(sender, e);
            }
        }
    }
}
