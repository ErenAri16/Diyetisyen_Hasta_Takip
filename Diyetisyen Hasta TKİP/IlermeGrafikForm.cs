using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Diyetisyen_Hasta_TKİP
{
    public partial class IlermeGrafikForm : Form
    {
        // Hasta servis sınıfı
        private readonly HastaService _hastaService;
        // İlerleme grafik servis sınıfı
        private readonly IlermeGrafikService _ilermeGrafikService;
        // Seçili hasta
        private Hasta _secilenHasta;

        public IlermeGrafikForm()
        {
            InitializeComponent();
            _hastaService = new HastaService();
            _ilermeGrafikService = new IlermeGrafikService();
        }

        // Form yüklendiğinde çalışacak olay
        private void IlermeGrafikForm_Load(object sender, EventArgs e)
        {
            // Hastaları listele
            HastalariListele();
            // Tarih aralığını ayarla
            dtpBaslangic.Value = DateTime.Today.AddMonths(-1);
            dtpBitis.Value = DateTime.Today;
        }

        // Hastaları listele
        private void HastalariListele()
        {
            try
            {
                // Hastaları getir
                var hastalar = _hastaService.HastalariGetir();
                // ComboBox'ı temizle
                cmbHasta.Items.Clear();
                // Hastaları ComboBox'a ekle
                cmbHasta.Items.AddRange(hastalar.ToArray());
                // DisplayMember ve ValueMember'ı ayarla
                cmbHasta.DisplayMember = "TamAd";
                cmbHasta.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hastalar listelenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hasta seçildiğinde çalışacak olay
        private void cmbHasta_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçili hastayı al
            _secilenHasta = cmbHasta.SelectedItem as Hasta;
            // Grafikleri güncelle
            GrafikleriGuncelle();
        }

        // Tarih aralığı değiştiğinde çalışacak olay
        private void dtpBaslangic_ValueChanged(object sender, EventArgs e)
        {
            // Grafikleri güncelle
            GrafikleriGuncelle();
        }

        private void dtpBitis_ValueChanged(object sender, EventArgs e)
        {
            // Grafikleri güncelle
            GrafikleriGuncelle();
        }

        // Grafikleri güncelle
        private void GrafikleriGuncelle()
        {
            try
            {
                // Hasta seçili değilse çık
                if (_secilenHasta == null) return;

                // İlerleme kayıtlarını getir
                var kayitlar = _ilermeGrafikService.IlermeKayitlariniGetir(_secilenHasta.Id)
                    .Where(k => k.Tarih >= dtpBaslangic.Value && k.Tarih <= dtpBitis.Value)
                    .OrderBy(k => k.Tarih)
                    .ToList();

                // Kilo grafiğini güncelle
                KiloGrafiginiGuncelle(kayitlar);
                // VKI grafiğini güncelle
                VKIGrafiginiGuncelle(kayitlar);
                // Bel/Kalça oranı grafiğini güncelle
                BelKalcaOraniGrafiginiGuncelle(kayitlar);
                // Vücut yağ oranı grafiğini güncelle
                VucutYagOraniGrafiginiGuncelle(kayitlar);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Grafikler güncellenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Kilo grafiğini güncelle
        private void KiloGrafiginiGuncelle(List<IlermeGrafik> kayitlar)
        {
            // Grafiği temizle
            chartKilo.Series[0].Points.Clear();

            // Her kayıt için
            foreach (var kayit in kayitlar)
            {
                // Grafiğe nokta ekle
                chartKilo.Series[0].Points.AddXY(kayit.Tarih, kayit.Kilo);
            }

            // Grafik başlığını güncelle
            chartKilo.Titles[0].Text = $"{_secilenHasta.TamAd} - Kilo Değişimi";
        }

        // VKI grafiğini güncelle
        private void VKIGrafiginiGuncelle(List<IlermeGrafik> kayitlar)
        {
            // Grafiği temizle
            chartVKI.Series[0].Points.Clear();

            // Her kayıt için
            foreach (var kayit in kayitlar)
            {
                // Grafiğe nokta ekle
                chartVKI.Series[0].Points.AddXY(kayit.Tarih, kayit.VKI);
            }

            // Grafik başlığını güncelle
            chartVKI.Titles[0].Text = $"{_secilenHasta.TamAd} - Vücut Kitle İndeksi Değişimi";
        }

        // Bel/Kalça oranı grafiğini güncelle
        private void BelKalcaOraniGrafiginiGuncelle(List<IlermeGrafik> kayitlar)
        {
            // Grafiği temizle
            chartBelKalca.Series[0].Points.Clear();

            // Her kayıt için
            foreach (var kayit in kayitlar)
            {
                // Grafiğe nokta ekle
                chartBelKalca.Series[0].Points.AddXY(kayit.Tarih, kayit.BelKalcaOrani);
            }

            // Grafik başlığını güncelle
            chartBelKalca.Titles[0].Text = $"{_secilenHasta.TamAd} - Bel/Kalça Oranı Değişimi";
        }

        // Vücut yağ oranı grafiğini güncelle
        private void VucutYagOraniGrafiginiGuncelle(List<IlermeGrafik> kayitlar)
        {
            // Grafiği temizle
            chartVucutYag.Series[0].Points.Clear();

            // Her kayıt için
            foreach (var kayit in kayitlar)
            {
                // Grafiğe nokta ekle
                chartVucutYag.Series[0].Points.AddXY(kayit.Tarih, kayit.VucutYagOrani);
            }

            // Grafik başlığını güncelle
            chartVucutYag.Titles[0].Text = $"{_secilenHasta.TamAd} - Vücut Yağ Oranı Değişimi";
        }

        // Yeni ilerleme kaydı ekle
        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            try
            {
                // Hasta seçili değilse uyar
                if (_secilenHasta == null)
                {
                    MessageBox.Show("Lütfen bir hasta seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Yeni ilerleme kaydı formunu aç
                using (var form = new IlermeKayitForm(_secilenHasta))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        // Grafikleri güncelle
                        GrafikleriGuncelle();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yeni kayıt eklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Form kapatıldığında çalışacak olay
        private void IlermeGrafikForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Form kapatılıyor
        }
    }
} 