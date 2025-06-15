using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Diyetisyen_Hasta_TKİP.Models;

namespace Diyetisyen_Hasta_TKİP
{
    public partial class OgunPlaniOgunForm : Form
    {
        private OgunPlani _ogunPlani;
        private OgunPlaniOgun _ogun;
        private bool _yeniKayit;

        public OgunPlaniOgun Ogun => _ogun;

        public OgunPlaniOgunForm(OgunPlani ogunPlani)
        {
            InitializeComponent();
            _ogunPlani = ogunPlani;
            _yeniKayit = true;
            _ogun = new OgunPlaniOgun();
        }

        public OgunPlaniOgunForm(OgunPlani ogunPlani, OgunPlaniOgun ogun)
        {
            InitializeComponent();
            _ogunPlani = ogunPlani;
            _ogun = ogun;
            _yeniKayit = false;
            FormuDoldur();
        }

        private void FormuDoldur()
        {
            txtOgunAdi.Text = _ogun.OgunAdi;
            dtpSaat.Value = DateTime.Today.Add(_ogun.Saat);
            txtNotlar.Text = _ogun.Notlar;
            chkTamamlandi.Checked = _ogun.Tamamlandi;

            // Besinleri listele
            lstBesinler.Items.Clear();
            foreach (var besin in _ogun.Besinler)
            {
                var item = new ListViewItem(besin.Besin.Ad);
                item.SubItems.Add(besin.Miktar.ToString("N1"));
                item.SubItems.Add(besin.Birim);
                item.SubItems.Add(besin.Kalori.ToString("N0"));
                item.SubItems.Add(besin.Tamamlandi ? "Evet" : "Hayır");
                item.Tag = besin;
                lstBesinler.Items.Add(item);
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

            foreach (var besin in _ogun.Besinler)
            {
                toplamKalori += besin.Kalori;
                toplamProtein += besin.Protein;
                toplamKarbonhidrat += besin.Karbonhidrat;
                toplamYag += besin.Yag;
            }

            _ogun.ToplamKalori = toplamKalori;
            _ogun.ToplamProtein = toplamProtein;
            _ogun.ToplamKarbonhidrat = toplamKarbonhidrat;
            _ogun.ToplamYag = toplamYag;

            lblToplamKalori.Text = toplamKalori.ToString("N0");
            lblToplamProtein.Text = toplamProtein.ToString("N1");
            lblToplamKarbonhidrat.Text = toplamKarbonhidrat.ToString("N1");
            lblToplamYag.Text = toplamYag.ToString("N1");
        }

        private void btnBesinEkle_Click(object sender, EventArgs e)
        {
            var besinForm = new OgunPlaniBesinForm(_ogun);
            if (besinForm.ShowDialog() == DialogResult.OK)
            {
                _ogun.Besinler.Add(besinForm.Besin);
                FormuDoldur();
            }
        }

        private void btnBesinDuzenle_Click(object sender, EventArgs e)
        {
            if (lstBesinler.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen düzenlenecek besini seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var besin = (OgunPlaniBesin)lstBesinler.SelectedItems[0].Tag;
            var besinForm = new OgunPlaniBesinForm(_ogun, besin);
            if (besinForm.ShowDialog() == DialogResult.OK)
            {
                FormuDoldur();
            }
        }

        private void btnBesinSil_Click(object sender, EventArgs e)
        {
            if (lstBesinler.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek besini seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Seçili besini silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var besin = (OgunPlaniBesin)lstBesinler.SelectedItems[0].Tag;
                _ogun.Besinler.Remove(besin);
                FormuDoldur();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtOgunAdi.Text))
                {
                    MessageBox.Show("Lütfen öğün adını girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _ogun.OgunAdi = txtOgunAdi.Text;
                _ogun.Saat = dtpSaat.Value.TimeOfDay;
                _ogun.Notlar = txtNotlar.Text;
                _ogun.Tamamlandi = chkTamamlandi.Checked;

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Öğün kaydedilirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
} 