using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Diyetisyen_Hasta_TKİP
{
    public class DatabaseHelper
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["DiyetisyenDB"].ConnectionString;

        public static bool TestConnection()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static DataTable ExecuteQuery(string query)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    DataTable dt = new DataTable();
                    try
                    {
                        conn.Open();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Veritabanı sorgusu çalıştırılırken hata oluştu: " + ex.Message);
                    }
                    return dt;
                }
            }
        }

        public static int ExecuteNonQuery(string query)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        return cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Veritabanı işlemi çalıştırılırken hata oluştu: " + ex.Message);
                    }
                }
            }
        }
    }
} 