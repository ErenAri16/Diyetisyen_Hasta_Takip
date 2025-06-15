using System;
using System.Windows.Forms;

namespace Diyetisyen_Hasta_TKİP
{
    public partial class IlermeKayitForm : Form
    {
        // İlerleme grafik servis sınıfı
        private readonly IlermeGrafikService _ilermeGrafikService;
        // Seçili hasta
        private readonly Hasta _hasta;
        // Düzenlenen kayıt
        private IlermeGrafik _kayit;

        // Yeni kayıt için constructor
        public IlermeKayitForm(Hasta hasta)
        {
            InitializeComponent();
            _ilermeGrafikService = new IlermeGrafikService();
            _hasta = hasta;
            _kayit = new IlermeGrafik
            {
                HastaId = hasta.Id,
                Tarih = DateTime.Today
            };
        }

        // Mevcut kaydı düzenlemek için constructor
        public IlermeKayitForm(Hasta hasta, IlermeGrafik kayit)
        {
            InitializeComponent();
            _ilermeGrafikService = new IlermeGrafikService();
            _hasta = hasta;
            _kayit = kayit;
        }

        // Form yüklendiğinde çalışacak olay
        private void IlermeKayitForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Form başlığını ayarla
                Text = _kayit.Id == 0 ? "Yeni İlerleme Kaydı" : "İlerleme Kaydını Düzenle";
                // Formu doldur
                FormuDoldur();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Form yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        // Formu doldur
        private void FormuDoldur()
        {
            // Hasta bilgilerini göster
            lblHasta.Text = _hasta.TamAd;
            lblHedefKilo.Text = $"{_hasta.HedefKilo} kg";
            lblHedefVKI.Text = $"{_hasta.HedefVKI:F1}";

            // Kayıt bilgilerini forma doldur
            dtpTarih.Value = _kayit.Tarih;
            numKilo.Value = (decimal)_kayit.Kilo;
            numBoy.Value = _kayit.Boy;
            numBelCevresi.Value = (decimal)_kayit.BelCevresi;
            numKalcaCevresi.Value = (decimal)_kayit.KalcaCevresi;
            numVucutYagOrani.Value = (decimal)_kayit.VucutYagOrani;
            txtNotlar.Text = _kayit.Notlar;
        }

        // Kaydet butonuna tıklandığında çalışacak olay
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // Form verilerini kayıt nesnesine aktar
                _kayit.Tarih = dtpTarih.Value;
                _kayit.Kilo = (double)numKilo.Value;
                _kayit.Boy = (int)numBoy.Value;
                _kayit.BelCevresi = (double)numBelCevresi.Value;
                _kayit.KalcaCevresi = (double)numKalcaCevresi.Value;
                _kayit.VucutYagOrani = (double)numVucutYagOrani.Value;
                _kayit.Notlar = txtNotlar.Text;

                // Kaydı kaydet
                if (_kayit.Id == 0)
                {
                    // Yeni kayıt ekle
                    _ilermeGrafikService.IlermeKaydiEkle(_kayit);
                }
                else
                {
                    // Mevcut kaydı güncelle
                    _ilermeGrafikService.IlermeKaydiGuncelle(_kayit);
                }

                // Formu kapat
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt kaydedilirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // İptal butonuna tıklandığında çalışacak olay
        private void btnIptal_Click(object sender, EventArgs e)
        {
            // Formu kapat
            DialogResult = DialogResult.Cancel;
            Close();
        }

        // Form kapatıldığında çalışacak olay
        private void IlermeKayitForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Form kapatılıyor
        }
    }
} 