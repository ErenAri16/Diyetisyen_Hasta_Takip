using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Diyetisyen_Hasta_TKİP
{
    public class IlermeGrafikService
    {
        // Veritabanı bağlantı dizesi
        private readonly string _connectionString = "Data Source=.;Initial Catalog=DiyetisyenDB;Integrated Security=True";

        // Tüm ilerleme kayıtlarını getir
        public List<IlermeGrafik> IlermeKayitlariniGetir(int hastaId)
        {
            var kayitlar = new List<IlermeGrafik>();

            try
            {
                // Veritabanı bağlantısını aç
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    // SQL sorgusunu hazırla
                    var command = new SqlCommand("SELECT * FROM IlermeGrafikler WHERE HastaId = @HastaId ORDER BY Tarih", connection);
                    command.Parameters.AddWithValue("@HastaId", hastaId);

                    // Sorguyu çalıştır
                    using (var reader = command.ExecuteReader())
                    {
                        // Her satır için
                        while (reader.Read())
                        {
                            // İlerleme kaydı nesnesini oluştur
                            var kayit = new IlermeGrafik
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                HastaId = reader.GetInt32(reader.GetOrdinal("HastaId")),
                                Tarih = reader.GetDateTime(reader.GetOrdinal("Tarih")),
                                Kilo = reader.GetDecimal(reader.GetOrdinal("Kilo")),
                                Boy = reader.GetInt32(reader.GetOrdinal("Boy")),
                                BelCevresi = reader.GetDecimal(reader.GetOrdinal("BelCevresi")),
                                KalcaCevresi = reader.GetDecimal(reader.GetOrdinal("KalcaCevresi")),
                                VucutYagOrani = reader.GetDecimal(reader.GetOrdinal("VucutYagOrani")),
                                Notlar = reader.GetString(reader.GetOrdinal("Notlar"))
                            };

                            // Listeye ekle
                            kayitlar.Add(kayit);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata fırlat
                throw new Exception("İlerleme kayıtları getirilirken bir hata oluştu: " + ex.Message);
            }

            return kayitlar;
        }

        // Belirli bir ilerleme kaydını getir
        public IlermeGrafik IlermeKaydiGetir(int id)
        {
            try
            {
                // Veritabanı bağlantısını aç
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    // SQL sorgusunu hazırla
                    var command = new SqlCommand("SELECT * FROM IlermeGrafikler WHERE Id = @Id", connection);
                    command.Parameters.AddWithValue("@Id", id);

                    // Sorguyu çalıştır
                    using (var reader = command.ExecuteReader())
                    {
                        // Kayıt bulundu mu kontrol et
                        if (reader.Read())
                        {
                            // İlerleme kaydı nesnesini oluştur
                            return new IlermeGrafik
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                HastaId = reader.GetInt32(reader.GetOrdinal("HastaId")),
                                Tarih = reader.GetDateTime(reader.GetOrdinal("Tarih")),
                                Kilo = reader.GetDecimal(reader.GetOrdinal("Kilo")),
                                Boy = reader.GetInt32(reader.GetOrdinal("Boy")),
                                BelCevresi = reader.GetDecimal(reader.GetOrdinal("BelCevresi")),
                                KalcaCevresi = reader.GetDecimal(reader.GetOrdinal("KalcaCevresi")),
                                VucutYagOrani = reader.GetDecimal(reader.GetOrdinal("VucutYagOrani")),
                                Notlar = reader.GetString(reader.GetOrdinal("Notlar"))
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata fırlat
                throw new Exception("İlerleme kaydı getirilirken bir hata oluştu: " + ex.Message);
            }

            return null;
        }

        // Yeni ilerleme kaydı ekle
        public void IlermeKaydiEkle(IlermeGrafik kayit)
        {
            try
            {
                // Veritabanı bağlantısını aç
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    // SQL sorgusunu hazırla
                    var command = new SqlCommand(@"INSERT INTO IlermeGrafikler (HastaId, Tarih, Kilo, Boy, BelCevresi, KalcaCevresi, VucutYagOrani, Notlar) 
                                                 VALUES (@HastaId, @Tarih, @Kilo, @Boy, @BelCevresi, @KalcaCevresi, @VucutYagOrani, @Notlar);
                                                 SELECT SCOPE_IDENTITY();", connection);

                    // Parametreleri ekle
                    command.Parameters.AddWithValue("@HastaId", kayit.HastaId);
                    command.Parameters.AddWithValue("@Tarih", kayit.Tarih);
                    command.Parameters.AddWithValue("@Kilo", kayit.Kilo);
                    command.Parameters.AddWithValue("@Boy", kayit.Boy);
                    command.Parameters.AddWithValue("@BelCevresi", kayit.BelCevresi);
                    command.Parameters.AddWithValue("@KalcaCevresi", kayit.KalcaCevresi);
                    command.Parameters.AddWithValue("@VucutYagOrani", kayit.VucutYagOrani);
                    command.Parameters.AddWithValue("@Notlar", kayit.Notlar);

                    // Sorguyu çalıştır ve yeni ID'yi al
                    kayit.Id = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                // Hata fırlat
                throw new Exception("İlerleme kaydı eklenirken bir hata oluştu: " + ex.Message);
            }
        }

        // İlerleme kaydı güncelle
        public void IlermeKaydiGuncelle(IlermeGrafik kayit)
        {
            try
            {
                // Veritabanı bağlantısını aç
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    // SQL sorgusunu hazırla
                    var command = new SqlCommand(@"UPDATE IlermeGrafikler 
                                                 SET Tarih = @Tarih, Kilo = @Kilo, Boy = @Boy, 
                                                     BelCevresi = @BelCevresi, KalcaCevresi = @KalcaCevresi, 
                                                     VucutYagOrani = @VucutYagOrani, Notlar = @Notlar 
                                                 WHERE Id = @Id", connection);

                    // Parametreleri ekle
                    command.Parameters.AddWithValue("@Id", kayit.Id);
                    command.Parameters.AddWithValue("@Tarih", kayit.Tarih);
                    command.Parameters.AddWithValue("@Kilo", kayit.Kilo);
                    command.Parameters.AddWithValue("@Boy", kayit.Boy);
                    command.Parameters.AddWithValue("@BelCevresi", kayit.BelCevresi);
                    command.Parameters.AddWithValue("@KalcaCevresi", kayit.KalcaCevresi);
                    command.Parameters.AddWithValue("@VucutYagOrani", kayit.VucutYagOrani);
                    command.Parameters.AddWithValue("@Notlar", kayit.Notlar);

                    // Sorguyu çalıştır
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Hata fırlat
                throw new Exception("İlerleme kaydı güncellenirken bir hata oluştu: " + ex.Message);
            }
        }

        // İlerleme kaydı sil
        public void IlermeKaydiSil(int id)
        {
            try
            {
                // Veritabanı bağlantısını aç
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    // SQL sorgusunu hazırla
                    var command = new SqlCommand("DELETE FROM IlermeGrafikler WHERE Id = @Id", connection);
                    command.Parameters.AddWithValue("@Id", id);

                    // Sorguyu çalıştır
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Hata fırlat
                throw new Exception("İlerleme kaydı silinirken bir hata oluştu: " + ex.Message);
            }
        }
    }
} 