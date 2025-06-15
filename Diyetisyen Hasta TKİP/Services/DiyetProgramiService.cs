using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Diyetisyen_Hasta_TKİP.Models;

namespace Diyetisyen_Hasta_TKİP.Services
{
    public class DiyetProgramiService
    {
        private static string connectionString = "Data Source=.;Initial Catalog=DiyetisyenDB;Integrated Security=True";

        public static DiyetProgrami DiyetProgramiOlustur(DiyetProgrami program)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Diyet programını kaydet
                        string sql = @"INSERT INTO DiyetProgramlari (HastaId, BaslangicTarihi, BitisTarihi, HedefKilo, Notlar, Aktif, OlusturmaTarihi, OlusturanKullaniciId)
                                     VALUES (@HastaId, @BaslangicTarihi, @BitisTarihi, @HedefKilo, @Notlar, @Aktif, @OlusturmaTarihi, @OlusturanKullaniciId);
                                     SELECT SCOPE_IDENTITY();";

                        using (var command = new SqlCommand(sql, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@HastaId", program.HastaId);
                            command.Parameters.AddWithValue("@BaslangicTarihi", program.BaslangicTarihi);
                            command.Parameters.AddWithValue("@BitisTarihi", program.BitisTarihi);
                            command.Parameters.AddWithValue("@HedefKilo", program.HedefKilo);
                            command.Parameters.AddWithValue("@Notlar", (object)program.Notlar ?? DBNull.Value);
                            command.Parameters.AddWithValue("@Aktif", program.Aktif);
                            command.Parameters.AddWithValue("@OlusturmaTarihi", DateTime.Now);
                            command.Parameters.AddWithValue("@OlusturanKullaniciId", program.OlusturanKullaniciId);

                            program.Id = Convert.ToInt32(command.ExecuteScalar());
                        }

                        // Öğünleri kaydet
                        foreach (var ogun in program.Ogunler)
                        {
                            sql = @"INSERT INTO Ogunler (DiyetProgramiId, OgunAdi, Saat, Kalori, Notlar)
                                  VALUES (@DiyetProgramiId, @OgunAdi, @Saat, @Kalori, @Notlar);
                                  SELECT SCOPE_IDENTITY();";

                            using (var command = new SqlCommand(sql, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@DiyetProgramiId", program.Id);
                                command.Parameters.AddWithValue("@OgunAdi", ogun.OgunAdi);
                                command.Parameters.AddWithValue("@Saat", ogun.Saat);
                                command.Parameters.AddWithValue("@Kalori", ogun.Kalori);
                                command.Parameters.AddWithValue("@Notlar", (object)ogun.Notlar ?? DBNull.Value);

                                ogun.Id = Convert.ToInt32(command.ExecuteScalar());
                            }

                            // Öğün besinlerini kaydet
                            foreach (var besin in ogun.Besinler)
                            {
                                sql = @"INSERT INTO OgunBesinler (OgunId, BesinId, Miktar, Birim)
                                      VALUES (@OgunId, @BesinId, @Miktar, @Birim);
                                      SELECT SCOPE_IDENTITY();";

                                using (var command = new SqlCommand(sql, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@OgunId", ogun.Id);
                                    command.Parameters.AddWithValue("@BesinId", besin.BesinId);
                                    command.Parameters.AddWithValue("@Miktar", besin.Miktar);
                                    command.Parameters.AddWithValue("@Birim", besin.Birim);

                                    besin.Id = Convert.ToInt32(command.ExecuteScalar());
                                }
                            }
                        }

                        transaction.Commit();
                        return program;
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public static List<DiyetProgrami> HastaDiyetProgramlariniGetir(int hastaId)
        {
            var programlar = new List<DiyetProgrami>();

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = @"SELECT * FROM DiyetProgramlari WHERE HastaId = @HastaId ORDER BY BaslangicTarihi DESC";

                using (var command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@HastaId", hastaId);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var program = new DiyetProgrami
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                HastaId = reader.GetInt32(reader.GetOrdinal("HastaId")),
                                BaslangicTarihi = reader.GetDateTime(reader.GetOrdinal("BaslangicTarihi")),
                                BitisTarihi = reader.GetDateTime(reader.GetOrdinal("BitisTarihi")),
                                HedefKilo = reader.GetDecimal(reader.GetOrdinal("HedefKilo")),
                                Notlar = reader.IsDBNull(reader.GetOrdinal("Notlar")) ? null : reader.GetString(reader.GetOrdinal("Notlar")),
                                Aktif = reader.GetBoolean(reader.GetOrdinal("Aktif")),
                                OlusturmaTarihi = reader.GetDateTime(reader.GetOrdinal("OlusturmaTarihi")),
                                OlusturanKullaniciId = reader.GetInt32(reader.GetOrdinal("OlusturanKullaniciId"))
                            };

                            programlar.Add(program);
                        }
                    }
                }

                // Her program için öğünleri getir
                foreach (var program in programlar)
                {
                    sql = @"SELECT * FROM Ogunler WHERE DiyetProgramiId = @DiyetProgramiId";

                    using (var command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@DiyetProgramiId", program.Id);

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var ogun = new Ogun
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                    DiyetProgramiId = reader.GetInt32(reader.GetOrdinal("DiyetProgramiId")),
                                    OgunAdi = reader.GetString(reader.GetOrdinal("OgunAdi")),
                                    Saat = reader.GetTimeSpan(reader.GetOrdinal("Saat")),
                                    Kalori = reader.GetDecimal(reader.GetOrdinal("Kalori")),
                                    Notlar = reader.IsDBNull(reader.GetOrdinal("Notlar")) ? null : reader.GetString(reader.GetOrdinal("Notlar"))
                                };

                                program.Ogunler.Add(ogun);
                            }
                        }
                    }

                    // Her öğün için besinleri getir
                    foreach (var ogun in program.Ogunler)
                    {
                        sql = @"SELECT ob.*, b.* FROM OgunBesinler ob
                               INNER JOIN Besinler b ON ob.BesinId = b.Id
                               WHERE ob.OgunId = @OgunId";

                        using (var command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@OgunId", ogun.Id);

                            using (var reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    var besin = new OgunBesin
                                    {
                                        Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                        OgunId = reader.GetInt32(reader.GetOrdinal("OgunId")),
                                        BesinId = reader.GetInt32(reader.GetOrdinal("BesinId")),
                                        Miktar = reader.GetDecimal(reader.GetOrdinal("Miktar")),
                                        Birim = reader.GetString(reader.GetOrdinal("Birim")),
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

            return programlar;
        }
    }
} 