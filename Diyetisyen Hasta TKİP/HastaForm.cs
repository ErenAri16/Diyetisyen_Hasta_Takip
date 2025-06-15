using System;
using System.Windows.Forms;
using Diyetisyen_Hasta_TKİP.Models;
using Diyetisyen_Hasta_TKİP.Services;

namespace Diyetisyen_Hasta_TKİP
{
    public partial class HastaForm : Form
    {
        // Hasta servis sınıfı
        private readonly HastaService _hastaService;
        
        // Hasta nesnesi
        private Hasta _hasta;
        
        // Yeni kayıt mı?
        private readonly bool _yeniKayit;

        // Yeni hasta oluşturma
        public HastaForm()
        {
            InitializeComponent();
            _hastaService = new HastaService();
            _yeniKayit = true;
            _hasta = new Hasta();
        }

        // Mevcut hastayı düzenleme
        public HastaForm(Hasta hasta)
        {
            InitializeComponent();
            _hastaService = new HastaService();
            _yeniKayit = false;
            _hasta = hasta;
            FormuDoldur();
        }

        // Formu doldur
        private void FormuDoldur()
        {
            // Hasta bilgilerini forma doldur
            txtAd.Text = _hasta.Ad;
            txtSoyad.Text = _hasta.Soyad;
            txtTelefon.Text = _hasta.Telefon;
            txtEmail.Text = _hasta.Email;
            dtpDogumTarihi.Value = _hasta.DogumTarihi;
            numBoy.Value = _hasta.Boy;
            numKilo.Value = _hasta.Kilo;
            numHedefKilo.Value = _hasta.HedefKilo;
            txtNotlar.Text = _hasta.Notlar;
        }

        // Kaydet butonuna tıklandığında çalışacak olay
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // Form verilerini hasta nesnesine aktar
                _hasta.Ad = txtAd.Text.Trim();
                _hasta.Soyad = txtSoyad.Text.Trim();
                _hasta.Telefon = txtTelefon.Text.Trim();
                _hasta.Email = txtEmail.Text.Trim();
                _hasta.DogumTarihi = dtpDogumTarihi.Value;
                _hasta.Boy = (int)numBoy.Value;
                _hasta.Kilo = (decimal)numKilo.Value;
                _hasta.HedefKilo = (decimal)numHedefKilo.Value;
                _hasta.Notlar = txtNotlar.Text.Trim();

                // Validasyon kontrolleri
                if (string.IsNullOrEmpty(_hasta.Ad))
                {
                    MessageBox.Show("Lütfen hasta adını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAd.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(_hasta.Soyad))
                {
                    MessageBox.Show("Lütfen hasta soyadını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSoyad.Focus();
                    return;
                }

                // Yeni kayıt ise ekle, değilse güncelle
                if (_yeniKayit)
                {
                    _hastaService.HastaEkle(_hasta);
                }
                else
                {
                    _hastaService.HastaGuncelle(_hasta);
                }

                // Formu kapat
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                // Hata mesajını göster
                MessageBox.Show("Hasta kaydedilirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // İptal butonuna tıklandığında çalışacak olay
        private void btnIptal_Click(object sender, EventArgs e)
        {
            // Formu kapat
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
} 