using System;
using System.Windows.Forms;
using Diyetisyen_Hasta_TKİP.Models;
using Diyetisyen_Hasta_TKİP.Services;

namespace Diyetisyen_Hasta_TKİP
{
    public partial class LoginForm : Form
    {
        public static Kullanici GirisYapanKullanici { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtKullaniciAdi.Text) || string.IsNullOrEmpty(txtSifre.Text))
                {
                    MessageBox.Show("Lütfen kullanıcı adı ve şifre giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                GirisYapanKullanici = KullaniciService.GirisYap(txtKullaniciAdi.Text, txtSifre.Text);
                if (GirisYapanKullanici != null)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giriş yapılırken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
} 