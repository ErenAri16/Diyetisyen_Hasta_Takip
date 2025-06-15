using System;
using System.Windows.Forms;
using Diyetisyen_Hasta_TKİP.Models;
using Diyetisyen_Hasta_TKİP.Services;

namespace Diyetisyen_Hasta_TKİP
{
    public partial class BesinForm : Form
    {
        private Besin _besin;
        private bool _yeniKayit;

        public BesinForm()
        {
            InitializeComponent();
            _yeniKayit = true;
            _besin = new Besin();
        }

        public BesinForm(Besin besin)
        {
            InitializeComponent();
            _besin = besin;
            _yeniKayit = false;
            FormuDoldur();
        }

        private void FormuDoldur()
        {
            txtAd.Text = _besin.Ad;
            numKalori.Value = (decimal)_besin.Kalori;
            numProtein.Value = (decimal)_besin.Protein;
            numKarbonhidrat.Value = (decimal)_besin.Karbonhidrat;
            numYag.Value = (decimal)_besin.Yag;
            txtBirim.Text = _besin.Birim;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtAd.Text))
                {
                    MessageBox.Show("Lütfen besin adını girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtBirim.Text))
                {
                    MessageBox.Show("Lütfen birim girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _besin.Ad = txtAd.Text;
                _besin.Kalori = (decimal)numKalori.Value;
                _besin.Protein = (decimal)numProtein.Value;
                _besin.Karbonhidrat = (decimal)numKarbonhidrat.Value;
                _besin.Yag = (decimal)numYag.Value;
                _besin.Birim = txtBirim.Text;

                if (_yeniKayit)
                {
                    BesinService.BesinEkle(_besin);
                }
                else
                {
                    BesinService.BesinGuncelle(_besin);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Besin kaydedilirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
} 