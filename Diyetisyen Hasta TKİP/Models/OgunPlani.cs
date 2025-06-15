using System;
using System.Collections.Generic;
using System.Linq;

namespace Diyetisyen_Hasta_TKİP.Models
{
    /// <summary>
    /// Öğün planı bilgilerini tutan model sınıfı
    /// </summary>
    public class OgunPlani
    {
        /// <summary>
        /// Öğün planı ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Hasta ID
        /// </summary>
        public int HastaId { get; set; }

        /// <summary>
        /// Öğün planı tarihi
        /// </summary>
        public DateTime Tarih { get; set; }

        /// <summary>
        /// Öğün planı notları
        /// </summary>
        public string Notlar { get; set; }

        /// <summary>
        /// Öğün planı öğünleri
        /// </summary>
        public List<OgunPlaniOgun> Ogunler { get; set; } = new List<OgunPlaniOgun>();

        /// <summary>
        /// Toplam kalori değerini hesaplar
        /// </summary>
        public decimal ToplamKalori => Ogunler.Sum(o => o.ToplamKalori);

        /// <summary>
        /// Toplam protein değerini hesaplar
        /// </summary>
        public decimal ToplamProtein => Ogunler.Sum(o => o.ToplamProtein);

        /// <summary>
        /// Toplam karbonhidrat değerini hesaplar
        /// </summary>
        public decimal ToplamKarbonhidrat => Ogunler.Sum(o => o.ToplamKarbonhidrat);

        /// <summary>
        /// Toplam yağ değerini hesaplar
        /// </summary>
        public decimal ToplamYag => Ogunler.Sum(o => o.ToplamYag);

        /// <summary>
        /// Öğün planı tamamlanma durumunu hesaplar
        /// </summary>
        public bool Tamamlandi => Ogunler.All(o => o.Tamamlandi);

        /// <summary>
        /// Öğün planı özetini döndürür
        /// </summary>
        public string Ozet => $"{Tarih:dd.MM.yyyy} - {ToplamKalori} kcal";
    }

    /// <summary>
    /// Öğün planı öğün bilgilerini tutan model sınıfı
    /// </summary>
    public class OgunPlaniOgun
    {
        /// <summary>
        /// Öğün planı öğün ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Öğün planı ID
        /// </summary>
        public int OgunPlaniId { get; set; }

        /// <summary>
        /// Öğün adı
        /// </summary>
        public string Ad { get; set; }

        /// <summary>
        /// Öğün saati
        /// </summary>
        public DateTime Saat { get; set; }

        /// <summary>
        /// Öğün notları
        /// </summary>
        public string Notlar { get; set; }

        /// <summary>
        /// Öğün tamamlanma durumu
        /// </summary>
        public bool Tamamlandi { get; set; }

        /// <summary>
        /// Öğün besinleri
        /// </summary>
        public List<OgunPlaniBesin> Besinler { get; set; } = new List<OgunPlaniBesin>();

        /// <summary>
        /// Toplam kalori değerini hesaplar
        /// </summary>
        public decimal ToplamKalori => Besinler.Sum(b => b.ToplamKalori);

        /// <summary>
        /// Toplam protein değerini hesaplar
        /// </summary>
        public decimal ToplamProtein => Besinler.Sum(b => b.ToplamProtein);

        /// <summary>
        /// Toplam karbonhidrat değerini hesaplar
        /// </summary>
        public decimal ToplamKarbonhidrat => Besinler.Sum(b => b.ToplamKarbonhidrat);

        /// <summary>
        /// Toplam yağ değerini hesaplar
        /// </summary>
        public decimal ToplamYag => Besinler.Sum(b => b.ToplamYag);

        /// <summary>
        /// Öğün özetini döndürür
        /// </summary>
        public string Ozet => $"{Ad} - {Saat:HH:mm} - {ToplamKalori} kcal";
    }

    /// <summary>
    /// Öğün planı besin bilgilerini tutan model sınıfı
    /// </summary>
    public class OgunPlaniBesin
    {
        /// <summary>
        /// Öğün planı besin ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Öğün planı öğün ID
        /// </summary>
        public int OgunPlaniOgunId { get; set; }

        /// <summary>
        /// Besin ID
        /// </summary>
        public int BesinId { get; set; }

        /// <summary>
        /// Besin miktarı
        /// </summary>
        public decimal Miktar { get; set; }

        /// <summary>
        /// Besin birimi
        /// </summary>
        public string Birim { get; set; }

        /// <summary>
        /// Besin tamamlanma durumu
        /// </summary>
        public bool Tamamlandi { get; set; }

        /// <summary>
        /// Besin nesnesi
        /// </summary>
        public Besin Besin { get; set; }

        /// <summary>
        /// Toplam kalori değerini hesaplar
        /// </summary>
        public decimal ToplamKalori => Besin?.Kalori * Miktar ?? 0;

        /// <summary>
        /// Toplam protein değerini hesaplar
        /// </summary>
        public decimal ToplamProtein => Besin?.Protein * Miktar ?? 0;

        /// <summary>
        /// Toplam karbonhidrat değerini hesaplar
        /// </summary>
        public decimal ToplamKarbonhidrat => Besin?.Karbonhidrat * Miktar ?? 0;

        /// <summary>
        /// Toplam yağ değerini hesaplar
        /// </summary>
        public decimal ToplamYag => Besin?.Yag * Miktar ?? 0;

        /// <summary>
        /// Besin özetini döndürür
        /// </summary>
        public string Ozet => $"{Besin?.Ad} - {Miktar} {Birim} - {ToplamKalori} kcal";
    }
} 