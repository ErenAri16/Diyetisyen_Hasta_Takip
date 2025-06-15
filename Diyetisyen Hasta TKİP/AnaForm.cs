using System;
using System.Windows.Forms;

namespace Diyetisyen_Hasta_TKİP
{
    public partial class AnaForm : Form
    {
        // Form yüklendiğinde çalışacak olay
        private void AnaForm_Load(object sender, EventArgs e)
        {
            // Form başlığını ayarla
            this.Text = "Diyetisyen Hasta Takip Sistemi";
            
            // Form boyutunu ayarla
            this.WindowState = FormWindowState.Maximized;
            
            // Menü öğelerini etkinleştir
            menuHastaYonetimi.Enabled = true;
            menuBesinYonetimi.Enabled = true;
            menuOgunPlani.Enabled = true;
            menuIlermeGrafik.Enabled = true;
            menuRaporlar.Enabled = true;
        }

        // Hasta yönetimi menü öğesine tıklandığında çalışacak olay
        private void menuHastaYonetimi_Click(object sender, EventArgs e)
        {
            // Hasta yönetimi formunu aç
            using (var form = new HastaYonetimForm())
            {
                form.ShowDialog();
            }
        }

        // Besin yönetimi menü öğesine tıklandığında çalışacak olay
        private void menuBesinYonetimi_Click(object sender, EventArgs e)
        {
            // Besin yönetimi formunu aç
            using (var form = new BesinYonetimForm())
            {
                form.ShowDialog();
            }
        }

        // Öğün planı menü öğesine tıklandığında çalışacak olay
        private void menuOgunPlani_Click(object sender, EventArgs e)
        {
            // Öğün planı formunu aç
            using (var form = new OgunPlaniForm())
            {
                form.ShowDialog();
            }
        }

        // İlerleme grafiği menü öğesine tıklandığında çalışacak olay
        private void menuIlermeGrafik_Click(object sender, EventArgs e)
        {
            // İlerleme grafiği formunu aç
            using (var form = new IlermeGrafikForm())
            {
                form.ShowDialog();
            }
        }

        // Raporlar menü öğesine tıklandığında çalışacak olay
        private void menuRaporlar_Click(object sender, EventArgs e)
        {
            // Raporlar formunu aç
            using (var form = new RaporlarForm())
            {
                form.ShowDialog();
            }
        }

        // Çıkış menü öğesine tıklandığında çalışacak olay
        private void menuCikis_Click(object sender, EventArgs e)
        {
            // Uygulamadan çık
            Application.Exit();
        }
    }
} 