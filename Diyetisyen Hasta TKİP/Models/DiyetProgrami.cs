using System;
using System.Collections.Generic;

namespace Diyetisyen_Hasta_TKİP.Models
{
    public class DiyetProgrami
    {
        public int Id { get; set; }
        public int HastaId { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public decimal HedefKilo { get; set; }
        public string Notlar { get; set; }
        public bool Aktif { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        public int OlusturanKullaniciId { get; set; }
        public List<Ogun> Ogunler { get; set; }

        public DiyetProgrami()
        {
            Ogunler = new List<Ogun>();
        }
    }

    public class Ogun
    {
        public int Id { get; set; }
        public int DiyetProgramiId { get; set; }
        public string OgunAdi { get; set; }
        public TimeSpan Saat { get; set; }
        public decimal Kalori { get; set; }
        public string Notlar { get; set; }
        public List<OgunBesin> Besinler { get; set; }

        public Ogun()
        {
            Besinler = new List<OgunBesin>();
        }
    }

    public class OgunBesin
    {
        public int Id { get; set; }
        public int OgunId { get; set; }
        public int BesinId { get; set; }
        public decimal Miktar { get; set; }
        public string Birim { get; set; }
        public Besin Besin { get; set; }
    }

    public class Besin
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public decimal Kalori { get; set; }
        public decimal Protein { get; set; }
        public decimal Karbonhidrat { get; set; }
        public decimal Yag { get; set; }
        public string Birim { get; set; }
    }
} 