using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Diyetisyen_Hasta_TKİP.Models;

namespace Diyetisyen_Hasta_TKİP
{
    public partial class OgunForm : Form
    {
        private Ogun _ogun;

        public Ogun Ogun => _ogun;

        public OgunForm()
        {
            InitializeComponent();
            _ogun = new Ogun
            {
                Besinler = new List<OgunBesin>()
            };
        }

        public OgunForm(Ogun ogun)
        {
            InitializeComponent();
            _ogun = ogun;

            // Form alanlarını doldur
            txtOgunAdi.Text = ogun.OgunAdi;
            dtpSaat.Value = DateTime.Today.Add(ogun.Saat);
            txtKalori.Text = ogun.Kalori.ToString();
            txtNotlar.Text = ogun.Notlar;

            // Besinleri listele
            BesinleriListele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // Form verilerini öğüne aktar
                _ogun.OgunAdi = txtOgunAdi.Text;
                _ogun.Saat = dtpSaat.Value.TimeOfDay;
                _ogun.Kalori = decimal.Parse(txtKalori.Text);
                _ogun.Notlar = txtNotlar.Text;

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnBesinEkle_Click(object sender, EventArgs e)
        {
            using (var besinForm = new BesinForm())
            {
                if (besinForm.ShowDialog() == DialogResult.OK)
                {
                    _ogun.Besinler.Add(besinForm.OgunBesin);
                    BesinleriListele();
                }
            }
        }

        private void btnBesinDuzenle_Click(object sender, EventArgs e)
        {
            if (lstBesinler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen düzenlenecek besini seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var seciliBesin = (OgunBesin)lstBesinler.SelectedItem;
            using (var besinForm = new BesinForm(seciliBesin))
            {
                if (besinForm.ShowDialog() == DialogResult.OK)
                {
                    var index = _ogun.Besinler.IndexOf(seciliBesin);
                    _ogun.Besinler[index] = besinForm.OgunBesin;
                    BesinleriListele();
                }
            }
        }

        private void btnBesinSil_Click(object sender, EventArgs e)
        {
            if (lstBesinler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen silinecek besini seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Seçili besini silmek istediğinizden emin misiniz?", "Onay", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var seciliBesin = (OgunBesin)lstBesinler.SelectedItem;
                _ogun.Besinler.Remove(seciliBesin);
                BesinleriListele();
            }
        }

        private void BesinleriListele()
        {
            lstBesinler.Items.Clear();
            foreach (var besin in _ogun.Besinler)
            {
                lstBesinler.Items.Add(besin);
            }
        }

        private void lstBesinler_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnBesinDuzenle.Enabled = lstBesinler.SelectedItem != null;
            btnBesinSil.Enabled = lstBesinler.SelectedItem != null;
        }
    }
} 