using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using Diyetisyen_Hasta_TKİP.Models;

namespace Diyetisyen_Hasta_TKİP.Services
{
    public class KullaniciService
    {
        private static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }

        public static Kullanici GirisYap(string kullaniciAdi, string sifre)
        {
            string hashedPassword = HashPassword(sifre);
            string query = $@"SELECT * FROM Kullanicilar 
                            WHERE KullaniciAdi = '{kullaniciAdi}' 
                            AND Sifre = '{hashedPassword}' 
                            AND Aktif = 1";

            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new Kullanici
                {
                    Id = Convert.ToInt32(row["Id"]),
                    KullaniciAdi = row["KullaniciAdi"].ToString(),
                    Ad = row["Ad"].ToString(),
                    Soyad = row["Soyad"].ToString(),
                    Email = row["Email"].ToString(),
                    Telefon = row["Telefon"].ToString(),
                    Rol = row["Rol"].ToString(),
                    KayitTarihi = Convert.ToDateTime(row["KayitTarihi"]),
                    Aktif = Convert.ToBoolean(row["Aktif"])
                };
            }
            return null;
        }

        public static bool KullaniciEkle(Kullanici kullanici)
        {
            string hashedPassword = HashPassword(kullanici.Sifre);
            string query = $@"INSERT INTO Kullanicilar (KullaniciAdi, Sifre, Ad, Soyad, Email, Telefon, Rol, KayitTarihi, Aktif)
                            VALUES ('{kullanici.KullaniciAdi}', '{hashedPassword}', '{kullanici.Ad}', '{kullanici.Soyad}',
                            '{kullanici.Email}', '{kullanici.Telefon}', '{kullanici.Rol}', '{DateTime.Now:yyyy-MM-dd}', 1)";

            try
            {
                DatabaseHelper.ExecuteNonQuery(query);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool SifreDegistir(int kullaniciId, string yeniSifre)
        {
            string hashedPassword = HashPassword(yeniSifre);
            string query = $"UPDATE Kullanicilar SET Sifre = '{hashedPassword}' WHERE Id = {kullaniciId}";

            try
            {
                DatabaseHelper.ExecuteNonQuery(query);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
} 