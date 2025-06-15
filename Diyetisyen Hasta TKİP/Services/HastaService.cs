using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Diyetisyen_Hasta_TKİP.Models;

namespace Diyetisyen_Hasta_TKİP.Services
{
    public class HastaService
    {
        // Veritabanı bağlantı dizesi
        private readonly string _connectionString = "Data Source=.;Initial Catalog=DiyetisyenDB;Integrated Security=True";

        // Tüm hastaları getir
        public List<Hasta> HastalariGetir()
        {
            var hastalar = new List<Hasta>();

            try
            {
                // Veritabanı bağlantısını aç
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    // SQL sorgusunu hazırla
                    var command = new SqlCommand("SELECT * FROM Hastalar ORDER BY Ad, Soyad", connection);

                    // Sorguyu çalıştır
                    using (var reader = command.ExecuteReader())
                    {
                        // Her satır için
                        while (reader.Read())
                        {
                            // Hasta nesnesini oluştur
                            var hasta = new Hasta
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                Ad = reader.GetString(reader.GetOrdinal("Ad")),
                                Soyad = reader.GetString(reader.GetOrdinal("Soyad")),
                                DogumTarihi = reader.GetDateTime(reader.GetOrdinal("DogumTarihi")),
                                Telefon = reader.GetString(reader.GetOrdinal("Telefon")),
                                Email = reader.GetString(reader.GetOrdinal("Email")),
                                Boy = reader.GetInt32(reader.GetOrdinal("Boy")),
                                Kilo = reader.GetDecimal(reader.GetOrdinal("Kilo")),
                                HedefKilo = reader.GetDecimal(reader.GetOrdinal("HedefKilo")),
                                Notlar = reader.GetString(reader.GetOrdinal("Notlar")),
                                KayitTarihi = reader.GetDateTime(reader.GetOrdinal("KayitTarihi"))
                            };

                            // Listeye ekle
                            hastalar.Add(hasta);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata fırlat
                throw new Exception("Hastalar getirilirken bir hata oluştu: " + ex.Message);
            }

            return hastalar;
        }

        // Belirli bir hastayı getir
        public Hasta HastaGetir(int id)
        {
            try
            {
                // Veritabanı bağlantısını aç
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    // SQL sorgusunu hazırla
                    var command = new SqlCommand("SELECT * FROM Hastalar WHERE Id = @Id", connection);
                    command.Parameters.AddWithValue("@Id", id);

                    // Sorguyu çalıştır
                    using (var reader = command.ExecuteReader())
                    {
                        // Kayıt bulundu mu kontrol et
                        if (reader.Read())
                        {
                            // Hasta nesnesini oluştur
                            return new Hasta
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                Ad = reader.GetString(reader.GetOrdinal("Ad")),
                                Soyad = reader.GetString(reader.GetOrdinal("Soyad")),
                                DogumTarihi = reader.GetDateTime(reader.GetOrdinal("DogumTarihi")),
                                Telefon = reader.GetString(reader.GetOrdinal("Telefon")),
                                Email = reader.GetString(reader.GetOrdinal("Email")),
                                Boy = reader.GetInt32(reader.GetOrdinal("Boy")),
                                Kilo = reader.GetDecimal(reader.GetOrdinal("Kilo")),
                                HedefKilo = reader.GetDecimal(reader.GetOrdinal("HedefKilo")),
                                Notlar = reader.GetString(reader.GetOrdinal("Notlar")),
                                KayitTarihi = reader.GetDateTime(reader.GetOrdinal("KayitTarihi"))
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata fırlat
                throw new Exception("Hasta getirilirken bir hata oluştu: " + ex.Message);
            }

            return null;
        }

        // Yeni hasta ekle
        public void HastaEkle(Hasta hasta)
        {
            try
            {
                // Veritabanı bağlantısını aç
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    // SQL sorgusunu hazırla
                    var command = new SqlCommand(@"INSERT INTO Hastalar (Ad, Soyad, DogumTarihi, Telefon, Email, Boy, Kilo, HedefKilo, Notlar, KayitTarihi) 
                                                 VALUES (@Ad, @Soyad, @DogumTarihi, @Telefon, @Email, @Boy, @Kilo, @HedefKilo, @Notlar, @KayitTarihi);
                                                 SELECT SCOPE_IDENTITY();", connection);

                    // Parametreleri ekle
                    command.Parameters.AddWithValue("@Ad", hasta.Ad);
                    command.Parameters.AddWithValue("@Soyad", hasta.Soyad);
                    command.Parameters.AddWithValue("@DogumTarihi", hasta.DogumTarihi);
                    command.Parameters.AddWithValue("@Telefon", hasta.Telefon);
                    command.Parameters.AddWithValue("@Email", hasta.Email);
                    command.Parameters.AddWithValue("@Boy", hasta.Boy);
                    command.Parameters.AddWithValue("@Kilo", hasta.Kilo);
                    command.Parameters.AddWithValue("@HedefKilo", hasta.HedefKilo);
                    command.Parameters.AddWithValue("@Notlar", hasta.Notlar);
                    command.Parameters.AddWithValue("@KayitTarihi", DateTime.Now);

                    // Sorguyu çalıştır ve yeni ID'yi al
                    hasta.Id = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                // Hata fırlat
                throw new Exception("Hasta eklenirken bir hata oluştu: " + ex.Message);
            }
        }

        // Hasta güncelle
        public void HastaGuncelle(Hasta hasta)
        {
            try
            {
                // Veritabanı bağlantısını aç
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    // SQL sorgusunu hazırla
                    var command = new SqlCommand(@"UPDATE Hastalar 
                                                 SET Ad = @Ad, Soyad = @Soyad, DogumTarihi = @DogumTarihi, 
                                                     Telefon = @Telefon, Email = @Email, Boy = @Boy, 
                                                     Kilo = @Kilo, HedefKilo = @HedefKilo, Notlar = @Notlar 
                                                 WHERE Id = @Id", connection);

                    // Parametreleri ekle
                    command.Parameters.AddWithValue("@Id", hasta.Id);
                    command.Parameters.AddWithValue("@Ad", hasta.Ad);
                    command.Parameters.AddWithValue("@Soyad", hasta.Soyad);
                    command.Parameters.AddWithValue("@DogumTarihi", hasta.DogumTarihi);
                    command.Parameters.AddWithValue("@Telefon", hasta.Telefon);
                    command.Parameters.AddWithValue("@Email", hasta.Email);
                    command.Parameters.AddWithValue("@Boy", hasta.Boy);
                    command.Parameters.AddWithValue("@Kilo", hasta.Kilo);
                    command.Parameters.AddWithValue("@HedefKilo", hasta.HedefKilo);
                    command.Parameters.AddWithValue("@Notlar", hasta.Notlar);

                    // Sorguyu çalıştır
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Hata fırlat
                throw new Exception("Hasta güncellenirken bir hata oluştu: " + ex.Message);
            }
        }

        // Hasta sil
        public void HastaSil(int id)
        {
            try
            {
                // Veritabanı bağlantısını aç
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    // SQL sorgusunu hazırla
                    var command = new SqlCommand("DELETE FROM Hastalar WHERE Id = @Id", connection);
                    command.Parameters.AddWithValue("@Id", id);

                    // Sorguyu çalıştır
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Hata fırlat
                throw new Exception("Hasta silinirken bir hata oluştu: " + ex.Message);
            }
        }
    }
} 