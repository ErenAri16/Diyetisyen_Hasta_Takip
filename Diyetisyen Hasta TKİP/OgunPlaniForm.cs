using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Diyetisyen_Hasta_TKİP.Models;
using Diyetisyen_Hasta_TKİP.Services;

namespace Diyetisyen_Hasta_TKİP
{
    public partial class OgunPlaniForm : Form
    {
        private OgunPlani _ogunPlani;
        private int _hastaId;
        private bool _yeniKayit;

        public OgunPlaniForm(int hastaId, DateTime tarih)
        {
            InitializeComponent();
            _hastaId = hastaId;
            _yeniKayit = true;
            _ogunPlani = new OgunPlani
            {
                HastaId = hastaId,
                Tarih = tarih,
                OlusturanKullaniciId = LoginForm.GirisYapanKullanici.Id
            };
        }

        public OgunPlaniForm(OgunPlani ogunPlani)
        {
            InitializeComponent();
            _ogunPlani = ogunPlani;
            _hastaId = ogunPlani.HastaId;
            _yeniKayit = false;
            FormuDoldur();
        }

        private void FormuDoldur()
        {
            dtpTarih.Value = _ogunPlani.Tarih;
            txtNotlar.Text = _ogunPlani.Notlar;
            chkTamamlandi.Checked = _ogunPlani.Tamamlandi;

            // Öğünleri listele
            lstOgunler.Items.Clear();
            foreach (var ogun in _ogunPlani.Ogunler)
            {
                var item = new ListViewItem(ogun.OgunAdi);
                item.SubItems.Add(ogun.Saat.ToString(@"hh\:mm"));
                item.SubItems.Add(ogun.ToplamKalori.ToString("N0"));
                item.SubItems.Add(ogun.Tamamlandi ? "Evet" : "Hayır");
                item.Tag = ogun;
                lstOgunler.Items.Add(item);
            }

            // Toplam değerleri güncelle
            ToplamDegerleriGuncelle();
        }

        private void ToplamDegerleriGuncelle()
        {
            decimal toplamKalori = 0;
            decimal toplamProtein = 0;
            decimal toplamKarbonhidrat = 0;
            decimal toplamYag = 0;

            foreach (var ogun in _ogunPlani.Ogunler)
            {
                toplamKalori += ogun.ToplamKalori;
                toplamProtein += ogun.ToplamProtein;
                toplamKarbonhidrat += ogun.ToplamKarbonhidrat;
                toplamYag += ogun.ToplamYag;
            }

            _ogunPlani.ToplamKalori = toplamKalori;
            _ogunPlani.ToplamProtein = toplamProtein;
            _ogunPlani.ToplamKarbonhidrat = toplamKarbonhidrat;
            _ogunPlani.ToplamYag = toplamYag;

            lblToplamKalori.Text = toplamKalori.ToString("N0");
            lblToplamProtein.Text = toplamProtein.ToString("N1");
            lblToplamKarbonhidrat.Text = toplamKarbonhidrat.ToString("N1");
            lblToplamYag.Text = toplamYag.ToString("N1");
        }

        private void btnOgunEkle_Click(object sender, EventArgs e)
        {
            var ogunForm = new OgunPlaniOgunForm(_ogunPlani);
            if (ogunForm.ShowDialog() == DialogResult.OK)
            {
                _ogunPlani.Ogunler.Add(ogunForm.Ogun);
                FormuDoldur();
            }
        }

        private void btnOgunDuzenle_Click(object sender, EventArgs e)
        {
            if (lstOgunler.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen düzenlenecek öğünü seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var ogun = (OgunPlaniOgun)lstOgunler.SelectedItems[0].Tag;
            var ogunForm = new OgunPlaniOgunForm(_ogunPlani, ogun);
            if (ogunForm.ShowDialog() == DialogResult.OK)
            {
                FormuDoldur();
            }
        }

        private void btnOgunSil_Click(object sender, EventArgs e)
        {
            if (lstOgunler.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek öğünü seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Seçili öğünü silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var ogun = (OgunPlaniOgun)lstOgunler.SelectedItems[0].Tag;
                _ogunPlani.Ogunler.Remove(ogun);
                FormuDoldur();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                _ogunPlani.Tarih = dtpTarih.Value;
                _ogunPlani.Notlar = txtNotlar.Text;
                _ogunPlani.Tamamlandi = chkTamamlandi.Checked;

                if (_yeniKayit)
                {
                    OgunPlaniService.OgunPlaniOlustur(_ogunPlani);
                }
                else
                {
                    OgunPlaniService.OgunPlaniGuncelle(_ogunPlani);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Öğün planı kaydedilirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
} 