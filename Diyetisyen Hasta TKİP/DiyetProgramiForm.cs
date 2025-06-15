using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Diyetisyen_Hasta_TKİP.Models;
using Diyetisyen_Hasta_TKİP.Services;

namespace Diyetisyen_Hasta_TKİP
{
    public partial class DiyetProgramiForm : Form
    {
        private int _hastaId;
        private DiyetProgrami _program;

        public DiyetProgramiForm(int hastaId)
        {
            InitializeComponent();
            _hastaId = hastaId;
            _program = new DiyetProgrami
            {
                HastaId = hastaId,
                BaslangicTarihi = DateTime.Today,
                BitisTarihi = DateTime.Today.AddMonths(1),
                Aktif = true,
                Ogunler = new List<Ogun>()
            };
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // Form verilerini programa aktar
                _program.BaslangicTarihi = dtpBaslangic.Value;
                _program.BitisTarihi = dtpBitis.Value;
                _program.HedefKilo = decimal.Parse(txtHedefKilo.Text);
                _program.Notlar = txtNotlar.Text;
                _program.OlusturanKullaniciId = LoginForm.GirisYapanKullanici.Id;

                // Programı kaydet
                _program = DiyetProgramiService.DiyetProgramiOlustur(_program);

                MessageBox.Show("Diyet programı başarıyla oluşturuldu.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnOgunEkle_Click(object sender, EventArgs e)
        {
            using (var ogunForm = new OgunForm())
            {
                if (ogunForm.ShowDialog() == DialogResult.OK)
                {
                    _program.Ogunler.Add(ogunForm.Ogun);
                    OgunleriListele();
                }
            }
        }

        private void btnOgunDuzenle_Click(object sender, EventArgs e)
        {
            if (lstOgunler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen düzenlenecek öğünü seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var seciliOgun = (Ogun)lstOgunler.SelectedItem;
            using (var ogunForm = new OgunForm(seciliOgun))
            {
                if (ogunForm.ShowDialog() == DialogResult.OK)
                {
                    var index = _program.Ogunler.IndexOf(seciliOgun);
                    _program.Ogunler[index] = ogunForm.Ogun;
                    OgunleriListele();
                }
            }
        }

        private void btnOgunSil_Click(object sender, EventArgs e)
        {
            if (lstOgunler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen silinecek öğünü seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Seçili öğünü silmek istediğinizden emin misiniz?", "Onay", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var seciliOgun = (Ogun)lstOgunler.SelectedItem;
                _program.Ogunler.Remove(seciliOgun);
                OgunleriListele();
            }
        }

        private void OgunleriListele()
        {
            lstOgunler.Items.Clear();
            foreach (var ogun in _program.Ogunler)
            {
                lstOgunler.Items.Add(ogun);
            }
        }

        private void lstOgunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnOgunDuzenle.Enabled = lstOgunler.SelectedItem != null;
            btnOgunSil.Enabled = lstOgunler.SelectedItem != null;
        }
    }
} 