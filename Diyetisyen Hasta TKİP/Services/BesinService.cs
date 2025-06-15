using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Diyetisyen_Hasta_TKİP.Models;

namespace Diyetisyen_Hasta_TKİP.Services
{
    public class BesinService
    {
        // Veritabanı bağlantı dizesi
        private readonly string _connectionString = "Data Source=.;Initial Catalog=DiyetisyenDB;Integrated Security=True";

        // Tüm besinleri getir
        public List<Besin> BesinleriGetir()
        {
            var besinler = new List<Besin>();

            try
            {
                // Veritabanı bağlantısını aç
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    // SQL sorgusunu hazırla
                    var command = new SqlCommand("SELECT * FROM Besinler ORDER BY Ad", connection);

                    // Sorguyu çalıştır
                    using (var reader = command.ExecuteReader())
                    {
                        // Her satır için
                        while (reader.Read())
                        {
                            // Besin nesnesini oluştur
                            var besin = new Besin
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                Ad = reader.GetString(reader.GetOrdinal("Ad")),
                                Kalori = reader.GetDecimal(reader.GetOrdinal("Kalori")),
                                Protein = reader.GetDecimal(reader.GetOrdinal("Protein")),
                                Karbonhidrat = reader.GetDecimal(reader.GetOrdinal("Karbonhidrat")),
                                Yag = reader.GetDecimal(reader.GetOrdinal("Yag")),
                                Birim = reader.GetString(reader.GetOrdinal("Birim"))
                            };

                            // Listeye ekle
                            besinler.Add(besin);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata fırlat
                throw new Exception("Besinler getirilirken bir hata oluştu: " + ex.Message);
            }

            return besinler;
        }

        // Belirli bir besini getir
        public Besin BesinGetir(int id)
        {
            try
            {
                // Veritabanı bağlantısını aç
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    // SQL sorgusunu hazırla
                    var command = new SqlCommand("SELECT * FROM Besinler WHERE Id = @Id", connection);
                    command.Parameters.AddWithValue("@Id", id);

                    // Sorguyu çalıştır
                    using (var reader = command.ExecuteReader())
                    {
                        // Kayıt bulundu mu kontrol et
                        if (reader.Read())
                        {
                            // Besin nesnesini oluştur
                            return new Besin
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                Ad = reader.GetString(reader.GetOrdinal("Ad")),
                                Kalori = reader.GetDecimal(reader.GetOrdinal("Kalori")),
                                Protein = reader.GetDecimal(reader.GetOrdinal("Protein")),
                                Karbonhidrat = reader.GetDecimal(reader.GetOrdinal("Karbonhidrat")),
                                Yag = reader.GetDecimal(reader.GetOrdinal("Yag")),
                                Birim = reader.GetString(reader.GetOrdinal("Birim"))
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata fırlat
                throw new Exception("Besin getirilirken bir hata oluştu: " + ex.Message);
            }

            return null;
        }

        // Yeni besin ekle
        public void BesinEkle(Besin besin)
        {
            try
            {
                // Veritabanı bağlantısını aç
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    // SQL sorgusunu hazırla
                    var command = new SqlCommand(@"INSERT INTO Besinler (Ad, Kalori, Protein, Karbonhidrat, Yag, Birim) 
                                                 VALUES (@Ad, @Kalori, @Protein, @Karbonhidrat, @Yag, @Birim);
                                                 SELECT SCOPE_IDENTITY();", connection);

                    // Parametreleri ekle
                    command.Parameters.AddWithValue("@Ad", besin.Ad);
                    command.Parameters.AddWithValue("@Kalori", besin.Kalori);
                    command.Parameters.AddWithValue("@Protein", besin.Protein);
                    command.Parameters.AddWithValue("@Karbonhidrat", besin.Karbonhidrat);
                    command.Parameters.AddWithValue("@Yag", besin.Yag);
                    command.Parameters.AddWithValue("@Birim", besin.Birim);

                    // Sorguyu çalıştır ve yeni ID'yi al
                    besin.Id = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                // Hata fırlat
                throw new Exception("Besin eklenirken bir hata oluştu: " + ex.Message);
            }
        }

        // Besin güncelle
        public void BesinGuncelle(Besin besin)
        {
            try
            {
                // Veritabanı bağlantısını aç
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    // SQL sorgusunu hazırla
                    var command = new SqlCommand(@"UPDATE Besinler 
                                                 SET Ad = @Ad, Kalori = @Kalori, Protein = @Protein, 
                                                     Karbonhidrat = @Karbonhidrat, Yag = @Yag, Birim = @Birim 
                                                 WHERE Id = @Id", connection);

                    // Parametreleri ekle
                    command.Parameters.AddWithValue("@Id", besin.Id);
                    command.Parameters.AddWithValue("@Ad", besin.Ad);
                    command.Parameters.AddWithValue("@Kalori", besin.Kalori);
                    command.Parameters.AddWithValue("@Protein", besin.Protein);
                    command.Parameters.AddWithValue("@Karbonhidrat", besin.Karbonhidrat);
                    command.Parameters.AddWithValue("@Yag", besin.Yag);
                    command.Parameters.AddWithValue("@Birim", besin.Birim);

                    // Sorguyu çalıştır
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Hata fırlat
                throw new Exception("Besin güncellenirken bir hata oluştu: " + ex.Message);
            }
        }

        // Besin sil
        public void BesinSil(int id)
        {
            try
            {
                // Veritabanı bağlantısını aç
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    // SQL sorgusunu hazırla
                    var command = new SqlCommand("DELETE FROM Besinler WHERE Id = @Id", connection);
                    command.Parameters.AddWithValue("@Id", id);

                    // Sorguyu çalıştır
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Hata fırlat
                throw new Exception("Besin silinirken bir hata oluştu: " + ex.Message);
            }
        }
    }
} 