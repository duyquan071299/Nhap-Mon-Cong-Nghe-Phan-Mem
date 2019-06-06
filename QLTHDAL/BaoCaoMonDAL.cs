using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTHDTO;

namespace QLTHDAL
{

    public class BaoCaoMonDAL
    {
        private string connectionString;

        public BaoCaoMonDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public bool them( kn)
        {
            string query = string.Empty;
            query += "INSERT INTO [tblKieuNau] ([maKieuNau], [tenKieuNau], [mota])";
            query += "VALUES (@maKieuNau,@tenKieuNau,@mota)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maKieuNau", kn.Ma);
                    cmd.Parameters.AddWithValue("@tenKieuNau", kn.Ten);
                    cmd.Parameters.AddWithValue("@mota", kn.Mota);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }

        public List<BaoCaoMonDTO> Select()
        {
            string query = string.Empty;
            query += "SELECT [TenLop], [SiSo], [mota]";
            query += "FROM [tblKieuNau]";

            List<KieuNauDTO> lsKieuNau = new List<KieuNauDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                KieuNauDTO kn = new KieuNauDTO();
                                kn.Ma = int.Parse(reader["maKieuNau"].ToString());
                                kn.Ten = reader["tenKieuNau"].ToString();
                                kn.Mota = reader["mota"].ToString();
                                lsKieuNau.Add(kn);
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return null;
                    }
                }
            }
            return lsKieuNau;

        }
    }
}
