using System;
using System.Collections.Generic;

namespace Diyetisyen_Hasta_TKİP
{
    /// <summary>
    /// Hasta ilerleme kayıtlarını tutan model sınıfı
    /// </summary>
    public class IlermeGrafik
    {
        /// <summary>
        /// İlerleme kaydı ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Hasta ID
        /// </summary>
        public int HastaId { get; set; }

        /// <summary>
        /// İlerleme kaydı tarihi
        /// </summary>
        public DateTime Tarih { get; set; }

        /// <summary>
        /// Hasta kilosu (kg)
        /// </summary>
        public decimal Kilo { get; set; }

        /// <summary>
        /// Hasta boyu (cm)
        /// </summary>
        public int Boy { get; set; }

        /// <summary>
        /// Bel çevresi (cm)
        /// </summary>
        public decimal BelCevresi { get; set; }

        /// <summary>
        /// Kalça çevresi (cm)
        /// </summary>
        public decimal KalcaCevresi { get; set; }

        /// <summary>
        /// Vücut yağ oranı (%)
        /// </summary>
        public decimal VucutYagOrani { get; set; }

        /// <summary>
        /// İlerleme kaydı notları
        /// </summary>
        public string Notlar { get; set; }

        /// <summary>
        /// Vücut kitle indeksi (VKI)
        /// </summary>
        public decimal VKI
        {
            get
            {
                if (Boy <= 0) return 0;
                var boyMetre = Boy / 100.0m;
                return Kilo / (boyMetre * boyMetre);
            }
        }

        /// <summary>
        /// Vücut kitle indeksi durumu
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
        /// Bel/Kalça oranı
        /// </summary>
        public decimal BelKalcaOrani
        {
            get
            {
                if (KalcaCevresi <= 0) return 0;
                return BelCevresi / KalcaCevresi;
            }
        }

        /// <summary>
        /// Bel/Kalça oranı durumu
        /// </summary>
        public string BelKalcaOraniDurumu
        {
            get
            {
                if (BelKalcaOrani < 0.85m) return "Düşük Risk";
                if (BelKalcaOrani < 0.90m) return "Orta Risk";
                return "Yüksek Risk";
            }
        }

        /// <summary>
        /// İlerleme kaydı özeti
        /// </summary>
        public string Ozet
        {
            get
            {
                return $"{Tarih:dd.MM.yyyy} - {Kilo} kg, {Boy} cm, VKI: {VKI:F1} ({VKIDurumu})";
            }
        }
    }
} 