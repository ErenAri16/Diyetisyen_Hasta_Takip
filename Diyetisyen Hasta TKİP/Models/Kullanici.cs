using System;

namespace Diyetisyen_Hasta_TKİP.Models
{
    public class Kullanici
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Rol { get; set; }
        public DateTime KayitTarihi { get; set; }
        public bool Aktif { get; set; }
    }
} 