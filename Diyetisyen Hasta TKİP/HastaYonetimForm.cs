using System;
using System.Data;
using System.Windows.Forms;

namespace Diyetisyen_Hasta_TKİP
{
    public partial class HastaYonetimForm : Form
    {
        // Hasta servis sınıfı
        private readonly HastaService _hastaService;

        // Form yüklendiğinde çalışacak olay
        private void HastaYonetimForm_Load(object sender, EventArgs e)
        {
            // Hastaları listele
            HastalariListele();
        }

        // Hastaları listele
        private void HastalariListele()
        {
            try
            {
                // Hastaları veritabanından al
                var hastalar = _hastaService.HastalariGetir();
                
                // ListView'i temizle
                lstHastalar.Items.Clear();
                
                // Her hasta için
                foreach (var hasta in hastalar)
                {
                    // ListView'e ekle
                    var item = new ListViewItem(hasta.Ad);
                    item.SubItems.Add(hasta.Soyad);
                    item.SubItems.Add(hasta.Telefon);
                    item.SubItems.Add(hasta.Email);
                    item.Tag = hasta;
                    lstHastalar.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                // Hata mesajını göster
                MessageBox.Show("Hastalar listelenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Yeni hasta butonuna tıklandığında çalışacak olay
        private void btnYeniHasta_Click(object sender, EventArgs e)
        {
            // Hasta formunu aç
            using (var form = new HastaForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Hastaları yeniden listele
                    HastalariListele();
                }
            }
        }

        // Düzenle butonuna tıklandığında çalışacak olay
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            // Seçili hasta var mı kontrol et
            if (lstHastalar.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz hastayı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Seçili hastayı al
            var hasta = (Hasta)lstHastalar.SelectedItems[0].Tag;
            
            // Hasta formunu aç
            using (var form = new HastaForm(hasta))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Hastaları yeniden listele
                    HastalariListele();
                }
            }
        }

        // Sil butonuna tıklandığında çalışacak olay
        private void btnSil_Click(object sender, EventArgs e)
        {
            // Seçili hasta var mı kontrol et
            if (lstHastalar.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz hastayı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Onay mesajı göster
            if (MessageBox.Show("Seçili hastayı silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    // Seçili hastayı al
                    var hasta = (Hasta)lstHastalar.SelectedItems[0].Tag;
                    
                    // Hastayı sil
                    _hastaService.HastaSil(hasta.Id);
                    
                    // Hastaları yeniden listele
                    HastalariListele();
                }
                catch (Exception ex)
                {
                    // Hata mesajını göster
                    MessageBox.Show("Hasta silinirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Kapat butonuna tıklandığında çalışacak olay
        private void btnKapat_Click(object sender, EventArgs e)
        {
            // Formu kapat
            this.Close();
        }
    }
} 