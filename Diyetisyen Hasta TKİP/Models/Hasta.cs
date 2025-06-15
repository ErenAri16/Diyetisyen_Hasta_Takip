using System;

namespace Diyetisyen_Hasta_TKİP.Models
{
    /// <summary>
    /// Hasta bilgilerini tutan model sınıfı
    /// </summary>
    public class Hasta
    {
        /// <summary>
        /// Hasta ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Hasta adı
        /// </summary>
        public string Ad { get; set; }

        /// <summary>
        /// Hasta soyadı
        /// </summary>
        public string Soyad { get; set; }

        /// <summary>
        /// Hasta doğum tarihi
        /// </summary>
        public DateTime DogumTarihi { get; set; }

        /// <summary>
        /// Hasta telefon numarası
        /// </summary>
        public string Telefon { get; set; }

        /// <summary>
        /// Hasta e-posta adresi
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Hasta boyu (cm)
        /// </summary>
        public int Boy { get; set; }

        /// <summary>
        /// Hasta kilosu (kg)
        /// </summary>
        public decimal Kilo { get; set; }

        /// <summary>
        /// Hasta hedef kilosu (kg)
        /// </summary>
        public decimal HedefKilo { get; set; }

        /// <summary>
        /// Hasta notları
        /// </summary>
        public string Notlar { get; set; }

        /// <summary>
        /// Kayıt tarihi
        /// </summary>
        public DateTime KayitTarihi { get; set; }

        /// <summary>
        /// Hasta tam adını döndürür
        /// </summary>
        public string TamAd => $"{Ad} {Soyad}";

        /// <summary>
        /// Hasta yaşını hesaplar
        /// </summary>
        public int Yas
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - DogumTarihi.Year;
                if (DogumTarihi.Date > today.AddYears(-age)) age--;
                return age;
            }
        }

        /// <summary>
        /// Vücut kitle indeksini hesaplar
        /// </summary>
        public decimal VKI
        {
            get
            {
                if (Boy == 0) return 0;
                var boyMetre = Boy / 100.0m;
                return Kilo / (boyMetre * boyMetre);
            }
        }

        /// <summary>
        /// Vücut kitle indeksi durumunu döndürür
        /// </summary>
        public string VKIDurumu
        {
            get
            {
                if (VKI < 18.5m) return "Zayıf";
                if (VKI < 25m) return "Normal";
                if (VKI < 30m) return "Fazla Kilolu";
                if (VKI < 35m) return "Obez (Sınıf I)";
                if (VKI < 40m) return "Obez (Sınıf II)";
                return "Obez (Sınıf III)";
            }
        }

        /// <summary>
        /// Hedef kiloya ulaşmak için kaç kilo vermesi/gainmesi gerektiğini hesaplar
        /// </summary>
        public decimal HedefFark => HedefKilo - Kilo;
    }
} 