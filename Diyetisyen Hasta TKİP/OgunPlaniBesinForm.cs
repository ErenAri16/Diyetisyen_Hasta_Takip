using System;
using System.Windows.Forms;
using Diyetisyen_Hasta_TKİP.Models;

namespace Diyetisyen_Hasta_TKİP
{
    public partial class OgunPlaniBesinForm : Form
    {
        private OgunPlaniOgun _ogun;
        private OgunPlaniBesin _besin;
        private bool _yeniKayit;

        public OgunPlaniBesin Besin => _besin;

        public OgunPlaniBesinForm(OgunPlaniOgun ogun)
        {
            InitializeComponent();
            _ogun = ogun;
            _yeniKayit = true;
            _besin = new OgunPlaniBesin();
            BesinleriYukle();
        }

        public OgunPlaniBesinForm(OgunPlaniOgun ogun, OgunPlaniBesin besin)
        {
            InitializeComponent();
            _ogun = ogun;
            _besin = besin;
            _yeniKayit = false;
            BesinleriYukle();
            FormuDoldur();
        }

        private void BesinleriYukle()
        {
            // TODO: Besinleri veritabanından yükle
            cmbBesin.Items.Clear();
            cmbBesin.DisplayMember = "Ad";
            cmbBesin.ValueMember = "Id";
            // cmbBesin.DataSource = BesinService.BesinleriGetir();
        }

        private void FormuDoldur()
        {
            cmbBesin.SelectedValue = _besin.BesinId;
            numMiktar.Value = (decimal)_besin.Miktar;
            txtBirim.Text = _besin.Birim;
            chkTamamlandi.Checked = _besin.Tamamlandi;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbBesin.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir besin seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (numMiktar.Value <= 0)
                {
                    MessageBox.Show("Lütfen geçerli bir miktar girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtBirim.Text))
                {
                    MessageBox.Show("Lütfen birim girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var besin = (Besin)cmbBesin.SelectedItem;
                _besin.BesinId = besin.Id;
                _besin.Besin = besin;
                _besin.Miktar = (decimal)numMiktar.Value;
                _besin.Birim = txtBirim.Text;
                _besin.Kalori = besin.Kalori * (decimal)numMiktar.Value;
                _besin.Protein = besin.Protein * (decimal)numMiktar.Value;
                _besin.Karbonhidrat = besin.Karbonhidrat * (decimal)numMiktar.Value;
                _besin.Yag = besin.Yag * (decimal)numMiktar.Value;
                _besin.Tamamlandi = chkTamamlandi.Checked;

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