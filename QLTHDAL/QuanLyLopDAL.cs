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
     public class QuanLyLopDAL
    {
        private string connectionString;
        public QuanLyLopDAL()
        {
            ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public List<QuanLyLopDTO> SelectDSLop(string TenLop)
        {
            string query = string.Empty;
            query += "Select [tblHocSinh].[MaHS], [TenHocSinh], [GioiTinh], [NgaySinh] " +
                "from [tblHocSinh],[tblDSLop],[tblLop] " +
                "where [tblHocSinh].[MaHS]=[tblDSLop].[MaHS] and [tblDSLop].[MaLop]=[tblLop].[MaLop] and [TenLop]=@TenLop ";

            List<QuanLyLopDTO> lsDSL = new List<QuanLyLopDTO>();

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
                                QuanLyLopDTO QLL = new QuanLyLopDTO();
                                QLL.MaHS = reader["MaHS"].ToString();
                                QLL.HoTen = reader["HoTen"].ToString();
                                QLL.GioiTinh = reader["GioiTinh"].ToString();
                                QLL.NgaySinh = DateTime.Parse(reader["NgaySinh"].ToString());
                                lsDSL.Add(QLL);
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
            return lsDSL;
        }

        public bool Them(QuanLyLopDTO QLL)
        {
            string query = string.Empty;
            query += "INSERT INTO [tblDSLop] ";
            query += "VALUES (@MaHS,@MaLop)";

            SqlCommand cm = new SqlCommand();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cm.CommandText = "Select [MaLop] from [tblLop] where [TenLop]=@TenLop";
                    cm.Parameters.AddWithValue("@TenLop", QLL.TenLop);
                    SqlDataReader reader = null;
                    reader = cm.ExecuteReader();
                    if (reader.HasRows == true)
                    {
                        while (reader.Read())
                        {
                            string MaTemp = reader["MaLop"].ToString();
                            cmd.Parameters.AddWithValue("@MaLop", MaTemp);
                        }
                    }

                    cmd.Parameters.AddWithValue("@MaHocSinh", QLL.MaHS);
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

        public bool Sua(QuanLyLopDTO QLL)
        {
            string query = string.Empty;
            query += "UPDATE tblDSHocSinh SET [MaLop]=@MaLop" +
                "  WHERE [MaHS]=@MaHocSinh";


            SqlCommand cm = new SqlCommand();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cm.CommandText = "Select [MaLop] from [tblLop] where [TenLop]=@TenLop";
                    cm.Parameters.AddWithValue("@TenLop", QLL.TenLop);
                    SqlDataReader reader = null;
                    reader = cm.ExecuteReader();
                    if (reader.HasRows == true)
                    {
                        while (reader.Read())
                        {
                            string MaTemp = reader["MaLop"].ToString();
                            cmd.Parameters.AddWithValue("@MaLop", MaTemp);
                        }
                    }

                    cmd.Parameters.AddWithValue("@MaHocSinh", QLL.MaHS);
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

        public bool Xoa(QuanLyLopDTO QLL)
        {
            string query = string.Empty;
            query += "DELETE FROM [tblDSLop] WHERE [MaHocSinh] = @MaHocSinh";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaHocSinh", QLL.MaHS);
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
    }
}
