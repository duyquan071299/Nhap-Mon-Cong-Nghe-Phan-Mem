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
    public class QuanLyHocSinhDAL
    {
        private string connectionString;
        public QuanLyHocSinhDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public bool Them(QuanLyHocSinhDTO QLHS)
        {
            string query = string.Empty;
            query += "INSERT INTO [tblHocSinh] ";
            query += "VALUES (@MaHocSinh,@Khoi,@HoTen,@GioiTinh,@NgaySinh,@NoiSinh," +
                    "@NguyenQuan,@DanToc,@TonGiao,@HoKhauTT," +
                    "@TenCha,@NNCha,@TenMe,@NNMe,@UuTien)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaHocSinh", QLHS.MaHS);
                    cmd.Parameters.AddWithValue("@Khoi", QLHS.Khoi);
                    cmd.Parameters.AddWithValue("@HoTen", QLHS.HoTen);
                    cmd.Parameters.AddWithValue("@GioiTinh", QLHS.GioiTinh);
                    cmd.Parameters.AddWithValue("@NgaySinh", QLHS.NgaySinh);
                    cmd.Parameters.AddWithValue("@NoiSinh", QLHS.NoiSinh);
                    cmd.Parameters.AddWithValue("@NguyenQuan", QLHS.NguyenQuan);
                    cmd.Parameters.AddWithValue("@DanToc", QLHS.DanToc);
                    cmd.Parameters.AddWithValue("@TonGiao", QLHS.TonGiao);
                    cmd.Parameters.AddWithValue("@HoKhauTT", QLHS.HoKhauTT);
                    cmd.Parameters.AddWithValue("@TenCha", QLHS.TenCha);
                    cmd.Parameters.AddWithValue("@NNCha", QLHS.NNCha);
                    cmd.Parameters.AddWithValue("@TenMe", QLHS.TenMe);
                    cmd.Parameters.AddWithValue("@NNMe", QLHS.NNMe);
                    cmd.Parameters.AddWithValue("@UuTien", QLHS.UuTien);

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

        public bool Xoa(QuanLyHocSinhDTO QLHS)
        {
            string query = string.Empty;
            query += "DELETE FROM [tblHocSinh] WHERE [MaHS] = @MaHocSinh";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaHocSinh", QLHS.MaHS);
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

        public bool Sua(QuanLyHocSinhDTO QLHS)
        {
            string query = string.Empty;
            query += "UPDATE [tblHocSinh] SET [TenHocSinh]=@HoTen,[GioiTinh]=@GioiTinh,[NgaySinh]=@NgaySinh,[NoiSinh]=@NoiSinh," +
                    "[NguyenQuan]=@NguyenQuan,[DanToc]=@DanToc,[TonGiao]=@TonGiao,[HoKhauTT]=@HoKhauTT," +
                    "[TenCha]=@TenCha,[TenMe]=@TenMe,[NNCha]=@NNCha,[NNMe]=@NNMe,[UuTien]=@UuTien,[Khoi]=@Khoi  WHERE [MaHS]=@MaHocSinh";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaHocSinh", QLHS.MaHS);
                    cmd.Parameters.AddWithValue("@Khoi", QLHS.Khoi);
                    cmd.Parameters.AddWithValue("@HoTen", QLHS.HoTen);
                    cmd.Parameters.AddWithValue("@GioiTinh", QLHS.GioiTinh);
                    cmd.Parameters.AddWithValue("@NgaySinh", QLHS.NgaySinh);
                    cmd.Parameters.AddWithValue("@NoiSinh", QLHS.NoiSinh);
                    cmd.Parameters.AddWithValue("@NguyenQuan", QLHS.NguyenQuan);
                    cmd.Parameters.AddWithValue("@DanToc", QLHS.DanToc);
                    cmd.Parameters.AddWithValue("@TonGiao", QLHS.TonGiao);
                    cmd.Parameters.AddWithValue("@HoKhauTT", QLHS.HoKhauTT);
                    cmd.Parameters.AddWithValue("@TenCha", QLHS.TenCha);
                    cmd.Parameters.AddWithValue("@NNCha", QLHS.NNCha);
                    cmd.Parameters.AddWithValue("@TenMe", QLHS.TenMe);
                    cmd.Parameters.AddWithValue("@NNMe", QLHS.NNMe);
                    cmd.Parameters.AddWithValue("@UuTien", QLHS.UuTien);
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

        public List<string> SelectMSSV()
        {
            string query = string.Empty;
            query += "Select [MaHocSinh] from [tblHocSinh] ";

            List<string> lsMSHS = new List<string>();

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
                                string Mshs = reader["MaHocSinh"].ToString();
                                lsMSHS.Add(Mshs);
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
            return lsMSHS;
        }

        public List<QuanLyHocSinhDTO> Select()
        {
            string query = string.Empty;
            query += "Select * from [tblHocSinh] ";

            List<QuanLyHocSinhDTO> lsDSHS = new List<QuanLyHocSinhDTO>();

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
                                QuanLyHocSinhDTO QLHS = new QuanLyHocSinhDTO();
                                QLHS.MaHS = reader["MaHS"].ToString();
                                QLHS.Khoi = reader["Khoi"].ToString();
                                QLHS.HoTen = reader["TenHocSinh"].ToString();
                                QLHS.GioiTinh = reader["GioiTinh"].ToString();
                                QLHS.NgaySinh = DateTime.Parse(reader["NgaySinh"].ToString());
                                QLHS.NoiSinh = reader["NoiSinh"].ToString();
                                QLHS.NguyenQuan = reader["NguyenQuan"].ToString();
                                QLHS.DanToc = reader["DanToc"].ToString();
                                QLHS.TonGiao = reader["TonGiao"].ToString();
                                QLHS.HoKhauTT = reader["HoKhauTT"].ToString();
                                QLHS.TenCha = reader["TenCha"].ToString();
                                QLHS.NNCha = reader["NNCha"].ToString();
                                QLHS.TenMe = reader["TenMe"].ToString();
                                QLHS.NNMe = reader["NNMe"].ToString();
                                QLHS.UuTien = reader["UuTien"].ToString();
                                lsDSHS.Add(QLHS);
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
            return lsDSHS;
        }

    }
}
