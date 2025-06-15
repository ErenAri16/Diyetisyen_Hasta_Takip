using System;

namespace Diyetisyen_Hasta_TKİP.Models
{
    /// <summary>
    /// Besin bilgilerini tutan model sınıfı
    /// </summary>
    public class Besin
    {
        /// <summary>
        /// Besin ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Besin adı
        /// </summary>
        public string Ad { get; set; }

        /// <summary>
        /// Besin kalorisi (kcal)
        /// </summary>
        public decimal Kalori { get; set; }

        /// <summary>
        /// Besin proteini (g)
        /// </summary>
        public decimal Protein { get; set; }

        /// <summary>
        /// Besin karbonhidratı (g)
        /// </summary>
        public decimal Karbonhidrat { get; set; }

        /// <summary>
        /// Besin yağı (g)
        /// </summary>
        public decimal Yag { get; set; }

        /// <summary>
        /// Besin birimi (g, ml, adet vb.)
        /// </summary>
        public string Birim { get; set; }

        /// <summary>
        /// Besin tam adını döndürür
        /// </summary>
        public string TamAd => $"{Ad} ({Birim})";

        /// <summary>
        /// Besin enerji değerini döndürür
        /// </summary>
        public string EnerjiDegeri => $"{Kalori} kcal";

        /// <summary>
        /// Besin makro besin değerlerini döndürür
        /// </summary>
        public string MakroDegerler => $"P: {Protein}g, K: {Karbonhidrat}g, Y: {Yag}g";

        /// <summary>
        /// Besin protein/kalori oranını hesaplar
        /// </summary>
        public decimal ProteinKaloriOrani
        {
            get
            {
                if (Kalori == 0) return 0;
                return (Protein * 4) / Kalori;
            }
        }

        /// <summary>
        /// Besin karbonhidrat/kalori oranını hesaplar
        /// </summary>
        public decimal KarbonhidratKaloriOrani
        {
            get
            {
                if (Kalori == 0) return 0;
                return (Karbonhidrat * 4) / Kalori;
            }
        }

        /// <summary>
        /// Besin yağ/kalori oranını hesaplar
        /// </summary>
        public decimal YagKaloriOrani
        {
            get
            {
                if (Kalori == 0) return 0;
                return (Yag * 9) / Kalori;
            }
        }

        /// <summary>
        /// Besin makro besin oranlarını döndürür
        /// </summary>
        public string MakroOranlar => $"P: %{ProteinKaloriOrani:P0}, K: %{KarbonhidratKaloriOrani:P0}, Y: %{YagKaloriOrani:P0}";
    }
} 