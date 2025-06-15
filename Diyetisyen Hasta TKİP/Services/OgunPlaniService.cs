using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Diyetisyen_Hasta_TKİP.Models;

namespace Diyetisyen_Hasta_TKİP.Services
{
    public class OgunPlaniService
    {
        private readonly string _connectionString = "Data Source=.;Initial Catalog=DiyetisyenDB;Integrated Security=True";

        public static OgunPlani OgunPlaniOlustur(OgunPlani plan)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Öğün planını kaydet
                        string sql = @"INSERT INTO OgunPlanlari (HastaId, Tarih, ToplamKalori, ToplamProtein, ToplamKarbonhidrat, ToplamYag, Notlar, Tamamlandi, OlusturmaTarihi, OlusturanKullaniciId)
                                     VALUES (@HastaId, @Tarih, @ToplamKalori, @ToplamProtein, @ToplamKarbonhidrat, @ToplamYag, @Notlar, @Tamamlandi, @OlusturmaTarihi, @OlusturanKullaniciId);
                                     SELECT SCOPE_IDENTITY();";

                        using (var command = new SqlCommand(sql, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@HastaId", plan.HastaId);
                            command.Parameters.AddWithValue("@Tarih", plan.Tarih);
                            command.Parameters.AddWithValue("@ToplamKalori", plan.ToplamKalori);
                            command.Parameters.AddWithValue("@ToplamProtein", plan.ToplamProtein);
                            command.Parameters.AddWithValue("@ToplamKarbonhidrat", plan.ToplamKarbonhidrat);
                            command.Parameters.AddWithValue("@ToplamYag", plan.ToplamYag);
                            command.Parameters.AddWithValue("@Notlar", (object)plan.Notlar ?? DBNull.Value);
                            command.Parameters.AddWithValue("@Tamamlandi", plan.Tamamlandi);
                            command.Parameters.AddWithValue("@OlusturmaTarihi", DateTime.Now);
                            command.Parameters.AddWithValue("@OlusturanKullaniciId", plan.OlusturanKullaniciId);

                            plan.Id = Convert.ToInt32(command.ExecuteScalar());
                        }

                        // Öğünleri kaydet
                        foreach (var ogun in plan.Ogunler)
                        {
                            sql = @"INSERT INTO OgunPlaniOgunler (OgunPlaniId, OgunAdi, Saat, ToplamKalori, ToplamProtein, ToplamKarbonhidrat, ToplamYag, Notlar, Tamamlandi)
                                  VALUES (@OgunPlaniId, @OgunAdi, @Saat, @ToplamKalori, @ToplamProtein, @ToplamKarbonhidrat, @ToplamYag, @Notlar, @Tamamlandi);
                                  SELECT SCOPE_IDENTITY();";

                            using (var command = new SqlCommand(sql, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@OgunPlaniId", plan.Id);
                                command.Parameters.AddWithValue("@OgunAdi", ogun.OgunAdi);
                                command.Parameters.AddWithValue("@Saat", ogun.Saat);
                                command.Parameters.AddWithValue("@ToplamKalori", ogun.ToplamKalori);
                                command.Parameters.AddWithValue("@ToplamProtein", ogun.ToplamProtein);
                                command.Parameters.AddWithValue("@ToplamKarbonhidrat", ogun.ToplamKarbonhidrat);
                                command.Parameters.AddWithValue("@ToplamYag", ogun.ToplamYag);
                                command.Parameters.AddWithValue("@Notlar", (object)ogun.Notlar ?? DBNull.Value);
                                command.Parameters.AddWithValue("@Tamamlandi", ogun.Tamamlandi);

                                ogun.Id = Convert.ToInt32(command.ExecuteScalar());
                            }

                            // Besinleri kaydet
                            foreach (var besin in ogun.Besinler)
                            {
                                sql = @"INSERT INTO OgunPlaniBesinler (OgunPlaniOgunId, BesinId, Miktar, Birim, Kalori, Protein, Karbonhidrat, Yag, Tamamlandi)
                                      VALUES (@OgunPlaniOgunId, @BesinId, @Miktar, @Birim, @Kalori, @Protein, @Karbonhidrat, @Yag, @Tamamlandi);
                                      SELECT SCOPE_IDENTITY();";

                                using (var command = new SqlCommand(sql, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@OgunPlaniOgunId", ogun.Id);
                                    command.Parameters.AddWithValue("@BesinId", besin.BesinId);
                                    command.Parameters.AddWithValue("@Miktar", besin.Miktar);
                                    command.Parameters.AddWithValue("@Birim", besin.Birim);
                                    command.Parameters.AddWithValue("@Kalori", besin.Kalori);
                                    command.Parameters.AddWithValue("@Protein", besin.Protein);
                                    command.Parameters.AddWithValue("@Karbonhidrat", besin.Karbonhidrat);
                                    command.Parameters.AddWithValue("@Yag", besin.Yag);
                                    command.Parameters.AddWithValue("@Tamamlandi", besin.Tamamlandi);

                                    besin.Id = Convert.ToInt32(command.ExecuteScalar());
                                }
                            }
                        }

                        transaction.Commit();
                        return plan;
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public static List<OgunPlani> HastaOgunPlanlariniGetir(int hastaId, DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            var planlar = new List<OgunPlani>();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string sql = @"SELECT * FROM OgunPlanlari 
                             WHERE HastaId = @HastaId 
                             AND Tarih BETWEEN @BaslangicTarihi AND @BitisTarihi
                             ORDER BY Tarih DESC";

                using (var command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@HastaId", hastaId);
                    command.Parameters.AddWithValue("@BaslangicTarihi", baslangicTarihi);
                    command.Parameters.AddWithValue("@BitisTarihi", bitisTarihi);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var plan = new OgunPlani
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                HastaId = reader.GetInt32(reader.GetOrdinal("HastaId")),
                                Tarih = reader.GetDateTime(reader.GetOrdinal("Tarih")),
                                ToplamKalori = reader.GetDecimal(reader.GetOrdinal("ToplamKalori")),
                                ToplamProtein = reader.GetDecimal(reader.GetOrdinal("ToplamProtein")),
                                ToplamKarbonhidrat = reader.GetDecimal(reader.GetOrdinal("ToplamKarbonhidrat")),
                                ToplamYag = reader.GetDecimal(reader.GetOrdinal("ToplamYag")),
                                Notlar = reader.IsDBNull(reader.GetOrdinal("Notlar")) ? null : reader.GetString(reader.GetOrdinal("Notlar")),
                                Tamamlandi = reader.GetBoolean(reader.GetOrdinal("Tamamlandi")),
                                OlusturmaTarihi = reader.GetDateTime(reader.GetOrdinal("OlusturmaTarihi")),
                                OlusturanKullaniciId = reader.GetInt32(reader.GetOrdinal("OlusturanKullaniciId"))
                            };

                            planlar.Add(plan);
                        }
                    }
                }

                // Her plan için öğünleri getir
                foreach (var plan in planlar)
                {
                    sql = @"SELECT * FROM OgunPlaniOgunler WHERE OgunPlaniId = @OgunPlaniId";

                    using (var command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@OgunPlaniId", plan.Id);

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var ogun = new OgunPlaniOgun
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                    OgunPlaniId = reader.GetInt32(reader.GetOrdinal("OgunPlaniId")),
                                    OgunAdi = reader.GetString(reader.GetOrdinal("OgunAdi")),
                                    Saat = reader.GetTimeSpan(reader.GetOrdinal("Saat")),
                                    ToplamKalori = reader.GetDecimal(reader.GetOrdinal("ToplamKalori")),
                                    ToplamProtein = reader.GetDecimal(reader.GetOrdinal("ToplamProtein")),
                                    ToplamKarbonhidrat = reader.GetDecimal(reader.GetOrdinal("ToplamKarbonhidrat")),
                                    ToplamYag = reader.GetDecimal(reader.GetOrdinal("ToplamYag")),
                                    Notlar = reader.IsDBNull(reader.GetOrdinal("Notlar")) ? null : reader.GetString(reader.GetOrdinal("Notlar")),
                                    Tamamlandi = reader.GetBoolean(reader.GetOrdinal("Tamamlandi"))
                                };

                                plan.Ogunler.Add(ogun);
                            }
                        }
                    }

                    // Her öğün için besinleri getir
                    foreach (var ogun in plan.Ogunler)
                    {
                        sql = @"SELECT opb.*, b.* FROM OgunPlaniBesinler opb
                               INNER JOIN Besinler b ON opb.BesinId = b.Id
                               WHERE opb.OgunPlaniOgunId = @OgunPlaniOgunId";

                        using (var command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@OgunPlaniOgunId", ogun.Id);

                            using (var reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    var besin = new OgunPlaniBesin
                                    {
                                        Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                        OgunPlaniOgunId = reader.GetInt32(reader.GetOrdinal("OgunPlaniOgunId")),
                                        BesinId = reader.GetInt32(reader.GetOrdinal("BesinId")),
                                        Miktar = reader.GetDecimal(reader.GetOrdinal("Miktar")),
                                        Birim = reader.GetString(reader.GetOrdinal("Birim")),
                                        Kalori = reader.GetDecimal(reader.GetOrdinal("Kalori")),
                                        Protein = reader.GetDecimal(reader.GetOrdinal("Protein")),
                                        Karbonhidrat = reader.GetDecimal(reader.GetOrdinal("Karbonhidrat")),
                                        Yag = reader.GetDecimal(reader.GetOrdinal("Yag")),
                                        Tamamlandi = reader.GetBoolean(reader.GetOrdinal("Tamamlandi")),
                                        Besin = new Besin
                                        {
                                            Id = reader.GetInt32(reader.GetOrdinal("BesinId")),
                                            Ad = reader.GetString(reader.GetOrdinal("Ad")),
                                            Kalori = reader.GetDecimal(reader.GetOrdinal("Kalori")),
                                            Protein = reader.GetDecimal(reader.GetOrdinal("Protein")),
                                            Karbonhidrat = reader.GetDecimal(reader.GetOrdinal("Karbonhidrat")),
                                            Yag = reader.GetDecimal(reader.GetOrdinal("Yag")),
                                            Birim = reader.GetString(reader.GetOrdinal("Birim"))
                                        }
                                    };

                                    ogun.Besinler.Add(besin);
                                }
                            }
                        }
                    }
                }
            }

            return planlar;
        }

        public static void OgunPlaniGuncelle(OgunPlani plan)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Öğün planını güncelle
                        string sql = @"UPDATE OgunPlanlari 
                                     SET Tarih = @Tarih,
                                         ToplamKalori = @ToplamKalori,
                                         ToplamProtein = @ToplamProtein,
                                         ToplamKarbonhidrat = @ToplamKarbonhidrat,
                                         ToplamYag = @ToplamYag,
                                         Notlar = @Notlar,
                                         Tamamlandi = @Tamamlandi
                                     WHERE Id = @Id";

                        using (var command = new SqlCommand(sql, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@Id", plan.Id);
                            command.Parameters.AddWithValue("@Tarih", plan.Tarih);
                            command.Parameters.AddWithValue("@ToplamKalori", plan.ToplamKalori);
                            command.Parameters.AddWithValue("@ToplamProtein", plan.ToplamProtein);
                            command.Parameters.AddWithValue("@ToplamKarbonhidrat", plan.ToplamKarbonhidrat);
                            command.Parameters.AddWithValue("@ToplamYag", plan.ToplamYag);
                            command.Parameters.AddWithValue("@Notlar", (object)plan.Notlar ?? DBNull.Value);
                            command.Parameters.AddWithValue("@Tamamlandi", plan.Tamamlandi);

                            command.ExecuteNonQuery();
                        }

                        // Öğünleri güncelle
                        foreach (var ogun in plan.Ogunler)
                        {
                            sql = @"UPDATE OgunPlaniOgunler 
                                  SET OgunAdi = @OgunAdi,
                                      Saat = @Saat,
                                      ToplamKalori = @ToplamKalori,
                                      ToplamProtein = @ToplamProtein,
                                      ToplamKarbonhidrat = @ToplamKarbonhidrat,
                                      ToplamYag = @ToplamYag,
                                      Notlar = @Notlar,
                                      Tamamlandi = @Tamamlandi
                                  WHERE Id = @Id";

                            using (var command = new SqlCommand(sql, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@Id", ogun.Id);
                                command.Parameters.AddWithValue("@OgunAdi", ogun.OgunAdi);
                                command.Parameters.AddWithValue("@Saat", ogun.Saat);
                                command.Parameters.AddWithValue("@ToplamKalori", ogun.ToplamKalori);
                                command.Parameters.AddWithValue("@ToplamProtein", ogun.ToplamProtein);
                                command.Parameters.AddWithValue("@ToplamKarbonhidrat", ogun.ToplamKarbonhidrat);
                                command.Parameters.AddWithValue("@ToplamYag", ogun.ToplamYag);
                                command.Parameters.AddWithValue("@Notlar", (object)ogun.Notlar ?? DBNull.Value);
                                command.Parameters.AddWithValue("@Tamamlandi", ogun.Tamamlandi);

                                command.ExecuteNonQuery();
                            }

                            // Besinleri güncelle
                            foreach (var besin in ogun.Besinler)
                            {
                                sql = @"UPDATE OgunPlaniBesinler 
                                      SET Miktar = @Miktar,
                                          Birim = @Birim,
                                          Kalori = @Kalori,
                                          Protein = @Protein,
                                          Karbonhidrat = @Karbonhidrat,
                                          Yag = @Yag,
                                          Tamamlandi = @Tamamlandi
                                      WHERE Id = @Id";

                                using (var command = new SqlCommand(sql, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@Id", besin.Id);
                                    command.Parameters.AddWithValue("@Miktar", besin.Miktar);
                                    command.Parameters.AddWithValue("@Birim", besin.Birim);
                                    command.Parameters.AddWithValue("@Kalori", besin.Kalori);
                                    command.Parameters.AddWithValue("@Protein", besin.Protein);
                                    command.Parameters.AddWithValue("@Karbonhidrat", besin.Karbonhidrat);
                                    command.Parameters.AddWithValue("@Yag", besin.Yag);
                                    command.Parameters.AddWithValue("@Tamamlandi", besin.Tamamlandi);

                                    command.ExecuteNonQuery();
                                }
                            }
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
    }
} 