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


        public List<string> SelectLop(string TenKhoi)
        {
            string query = string.Empty;
            query += "Select [TenLop]" +
                " from [tblLop],[tblKhoi]" +
                " where [tblLop].[MaKhoi]=[tblKhoi].[MaKhoi] and [TenKhoi]=@TenKhoi";
            List<string> lsDSL = new List<string>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@TenKhoi", TenKhoi);

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                string temp;
                                temp = reader["TenLop"].ToString();
                                lsDSL.Add(temp);
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



        public List<QuanLyLopDTO> SelectDSLop(string TenLop)
        {
            string query = string.Empty;
            query += "Select * " +
                "from [tblHocSinh],[tblLop] " +
                "where [tblHocSinh].[MaLop]=[tblLop].[MaLop] and [tblLop].[TenLop]=@TenLop ";

            List<QuanLyLopDTO> lsDSL = new List<QuanLyLopDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@TenLop", TenLop);

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
                                QLL.HoTen = reader["TenHocSinh"].ToString();
                                QLL.GioiTinh = reader["GioiTinh"].ToString();
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
            query += "select [MaLop] from [tblLop] where [TenLop]=@TenLop";
            List<QuanLyLopDTO> lsDSL = new List<QuanLyLopDTO>();
            string malop = string.Empty;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@TenLop", QLL.TenLop);

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                malop = reader["MaLop"].ToString();
                            }
                        }
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                    }
                }
            }
            QLL.MaLop = malop;
            query = string.Empty;
            query += "update [tblHocSinh] set [MaLop]=@MaLop where [MaHS]=@MaHS";



            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaLop", QLL.MaLop);
                    cmd.Parameters.AddWithValue("@MaHS", QLL.MaHS);
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
            query = string.Empty;
            query += "select * from tblDiem";
            List<string> dsmabangdiem = new List<string>();

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
                                string mabangdiem = string.Empty;
                                mabangdiem = reader["MaBangDiem"].ToString();
                                dsmabangdiem.Add(mabangdiem);
                            }
                        }
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
            Random ran = new Random();
            
            query = string.Empty;
            query += "Select * " +
                "from tblMonHoc";

            List<string> lsMaMon = new List<string>();

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
                                string mamon = string.Empty;
                                mamon = reader["MaMonHoc"].ToString();
                                lsMaMon.Add(mamon);
                            }
                        }
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
            int mabangdiemmoi;
            int mabangdiemmoi2;
            foreach (string mamonhoc in lsMaMon)
            {
                do
                {
                    mabangdiemmoi = ran.Next(1, 999);
                } while (dsmabangdiem.Contains(mabangdiemmoi.ToString()));
                do
                {
                    mabangdiemmoi2 = ran.Next(1, 999);
                } while (dsmabangdiem.Contains(mabangdiemmoi2.ToString()) || mabangdiemmoi2 == mabangdiemmoi);
                query = string.Empty;
                query += "insert into tblDiem values(@MaBangDiem,@MaHS,@MaMonHoc,'1','0','0','0')";

                query += "insert into tblDiem values(@MaBangDiem2,@MaHS,@MaMonHoc,'2','0','0','0')";
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@MaBangDiem", mabangdiemmoi);
                        cmd.Parameters.AddWithValue("@MaBangDiem2", mabangdiemmoi2);
                        cmd.Parameters.AddWithValue("@MaHS", QLL.MaHS);
                        cmd.Parameters.AddWithValue("@MaMonHoc", mamonhoc);
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
            query += "update [tblHocSinh] set [MaLop]=null where [MaHS]=@MaHocSinh";
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
            query = string.Empty;
            query += "delete from tblDiem where MaHS=@MaHocSinh";
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
