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
    public class QuanLyThamSoDAL
    {
        private Random ran = new Random();
        private string connectionString;
        public QuanLyThamSoDAL()
        {
            ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public bool Them(ThamSoDTO TSDTO)
        {
            string query = string.Empty;
            query += "select count(*) SoLuong from [tblThamSo]";
            List<QuanLyLopDTO> lsDSL = new List<QuanLyLopDTO>();
            string SoLuong = string.Empty;
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
                                SoLuong = reader["SoLuong"].ToString();
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
            SoLuong = (int.Parse(SoLuong) + 1).ToString();
            query = string.Empty;
            query += "insert into [tblThamSo]";
            query += "values (@MaTS,@TenTS,@GiaTriTS)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaTS", SoLuong);
                    cmd.Parameters.AddWithValue("@TenTS", TSDTO.STenThamSo);
                    cmd.Parameters.AddWithValue("@GiaTriTS", TSDTO.SGiaTri);
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

        public bool ThemLop(ThamSoDTO TSDTO)
        {
            string query = string.Empty;
            query += " select [MaLop] from [tblLop]";
            string malop = string.Empty;
            List<string> DanhSachMaLop = new List<string>();
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
                                malop = reader["MaLop"].ToString();
                                DanhSachMaLop.Add(malop);
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
            int malopmoi;
            do
            {
                malopmoi = ran.Next(1, 999);
            } while (DanhSachMaLop.Contains(malopmoi.ToString()));
            query = string.Empty;
            query += "insert into [tblLop]";
            query += "values (@MaLop,@TenLop,@MaKhoi)";
            string makhoi = string.Empty;
            if (TSDTO.STenThamSo == "Tên lớp K10")
            {
                makhoi = "001";
            }
            if (TSDTO.STenThamSo == "Tên lớp K11")
            {
                makhoi = "002";
            }
            if (TSDTO.STenThamSo == "Tên lớp K12")
            {
                makhoi = "003";
            }
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaLop", malopmoi.ToString());
                    cmd.Parameters.AddWithValue("@TenLop", TSDTO.SGiaTri);
                    cmd.Parameters.AddWithValue("@MaKhoi", makhoi.ToString());
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
            query += "select [MaTS] from [tblThamSo]";
            List<QuanLyLopDTO> lsDSL = new List<QuanLyLopDTO>();
            string mats = string.Empty;
            List<string> DanhSachMaTS = new List<string>();
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
                                mats = reader["MaTS"].ToString();
                                DanhSachMaTS.Add(mats);
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
            int matsmoi;
            do
            {
                matsmoi = ran.Next(1, 999);
            } while (DanhSachMaTS.Contains(matsmoi.ToString()));
            query = string.Empty;
            query += "insert into [tblThamSo]";
            query += "values (@MaTS,@TenTS,@GiaTriTS)";
            string key = string.Empty;
            if(TSDTO.STenThamSo=="Tên lớp K10")
            {
                key = "K10";
            }
            if (TSDTO.STenThamSo == "Tên lớp K11")
            {
                key = "K11";
            }
            if (TSDTO.STenThamSo == "Tên lớp K12")
            {
                key = "K12";
            }
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaTS", key+matsmoi.ToString());
                    cmd.Parameters.AddWithValue("@TenTS", TSDTO.STenThamSo);
                    cmd.Parameters.AddWithValue("@GiaTriTS", TSDTO.SGiaTri);
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

        public bool ThemMonHoc(ThamSoDTO TSDTO)
        {
            string query = string.Empty;
            query += " select [MaMonHoc] from [tblMonHoc]";
            string mamh = string.Empty;
            List<string> DanhSachMaMonHoc = new List<string>();
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
                                mamh = reader["MaMonHoc"].ToString();
                                DanhSachMaMonHoc.Add(mamh);
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
            int mamhmoi;
            do
            {
                mamhmoi = ran.Next(1, 999);
            } while (DanhSachMaMonHoc.Contains(mamhmoi.ToString()));
            query = string.Empty;
            query += "insert into [tblMonHoc]";
            query += "values (@MaMH,@TenMH)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaMH", mamhmoi.ToString());
                    cmd.Parameters.AddWithValue("@TenMH", TSDTO.SGiaTri);

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
            query += "select [MaTS] from [tblThamSo]";
            List<QuanLyLopDTO> lsDSL = new List<QuanLyLopDTO>();
            string mats = string.Empty;
            List<string> DanhSachMaTS = new List<string>();
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
                                mats = reader["MaTS"].ToString();
                                DanhSachMaTS.Add(mats);
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
            int matsmoi;
            do
            {
                matsmoi = ran.Next(1, 999);
            } while (DanhSachMaTS.Contains(matsmoi.ToString()));
            query = string.Empty;
            query += "insert into [tblThamSo]";
            query += "values (@MaTS,@TenTS,@GiaTriTS)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaTS", "MH"+matsmoi.ToString());
                    cmd.Parameters.AddWithValue("@TenTS", TSDTO.STenThamSo);
                    cmd.Parameters.AddWithValue("@GiaTriTS", TSDTO.SGiaTri);
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

        public List<ThamSoDTO> SelectAll()
        {
            string query = string.Empty;
            query += "Select * from [tblThamSo] ";

            List<ThamSoDTO> lsDSTS = new List<ThamSoDTO>();

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
                                ThamSoDTO TS = new ThamSoDTO();
                                TS.STenThamSo = reader["TenTS"].ToString();
                                TS.SGiaTri = reader["GiaTriTS"].ToString();
                                lsDSTS.Add(TS);
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
            return lsDSTS;
        }

        public bool Sua(ThamSoDTO TSDTO)
        {
            string query = string.Empty;
            query += "UPDATE [tblThamSo] SET [GiaTriTS]=@GiaTriMoi  WHERE [TenTS]=@TenTS and [GiaTriTS]=@GiaTriCu";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@TenTS", TSDTO.STenThamSo);
                    cmd.Parameters.AddWithValue("@GiaTriCu", TSDTO.SGiaTri);
                    cmd.Parameters.AddWithValue("@GiaTriMoi", TSDTO.SGiaTriMoi);
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

        public bool SuaLop(ThamSoDTO TSDTO)
        {
            string query = string.Empty;
            query += "UPDATE [tblThamSo] SET [GiaTriTS]=@GiaTriMoi  WHERE [TenTS]=@TenTS and [GiaTriTS]=@GiaTriCu";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@TenTS", TSDTO.STenThamSo);
                    cmd.Parameters.AddWithValue("@GiaTriCu", TSDTO.SGiaTri);
                    cmd.Parameters.AddWithValue("@GiaTriMoi", TSDTO.SGiaTriMoi);
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
            query += "UPDATE [tblLop] SET [TenLop]=@GiaTriMoi  WHERE [TenLop]=@GiaTriCu";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@GiaTriCu", TSDTO.SGiaTri);
                    cmd.Parameters.AddWithValue("@GiaTriMoi", TSDTO.SGiaTriMoi);
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

        public bool SuaMonHoc(ThamSoDTO TSDTO)
        {
            string query = string.Empty;
            query += "UPDATE [tblThamSo] SET [GiaTriTS]=@GiaTriMoi  WHERE [TenTS]=@TenTS and [GiaTriTS]=@GiaTriCu";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@TenTS", TSDTO.STenThamSo);
                    cmd.Parameters.AddWithValue("@GiaTriCu", TSDTO.SGiaTri);
                    cmd.Parameters.AddWithValue("@GiaTriMoi", TSDTO.SGiaTriMoi);
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
            query += "UPDATE [tblMonHoc] SET [TenMonHoc]=@GiaTriMoi  WHERE [TenMonHoc]=@GiaTriCu";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@GiaTriCu", TSDTO.SGiaTri);
                    cmd.Parameters.AddWithValue("@GiaTriMoi", TSDTO.SGiaTriMoi);
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



        public bool Xoa(ThamSoDTO TSDTO)
        {
            string query = string.Empty;
            query += "select [MaTS] from [tblThamSo] where [TenTS]=@TenThamSo and [GiaTriTS]=@GiaTriTS ";
            string mats = string.Empty;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@TenThamSo", TSDTO.STenThamSo);
                    cmd.Parameters.AddWithValue("@GiaTriTS", TSDTO.SGiaTri);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                mats = reader["MaTS"].ToString();
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
            query = string.Empty;
            query += "DELETE FROM [tblThamSo] WHERE [MaTS] = @MaThamSo";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaThamSo", mats);
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

        public bool XoaLop(ThamSoDTO TSDTO)
        {
            string query = string.Empty;
            query += "select [MaLop] from [tblLop] where [TenLop]=@TenLop";
            string malop = string.Empty;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@TenLop", TSDTO.SGiaTri);
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
            query = string.Empty;
            query += "delete from [tbllop] where [MaLop]=@MaLop";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaLop", malop);
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
            query += "select [MaTS] from [tblThamSo] where [TenTS]=@TenThamSo and [GiaTriTS]=@GiaTriTS ";
            string mats = string.Empty;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@TenThamSo", TSDTO.STenThamSo);
                    cmd.Parameters.AddWithValue("@GiaTriTS", TSDTO.SGiaTri);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                mats = reader["MaTS"].ToString();
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
            query = string.Empty;
            query += "DELETE FROM [tblThamSo] WHERE [MaTS] = @MaThamSo";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaThamSo", mats);
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

        public bool XoaMonHoc(ThamSoDTO TSDTO)
        {
            string query = string.Empty;
            query += "select [MaMonHoc] from [tblMonHoc] where [TenMonHoc]=@TenMH";
            string mamh = string.Empty;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@TenMH", TSDTO.SGiaTri);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                mamh = reader["MaMonHoc"].ToString();
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
            query = string.Empty;
            query += "delete from [tblMonHoc] where [MaMonHoc]=@MaMH";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaMH", mamh);
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
            query += "select [MaTS] from [tblThamSo] where [TenTS]=@TenThamSo and [GiaTriTS]=@GiaTriTS ";
            string mats = string.Empty;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@TenThamSo", TSDTO.STenThamSo);
                    cmd.Parameters.AddWithValue("@GiaTriTS", TSDTO.SGiaTri);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                mats = reader["MaTS"].ToString();
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
            query = string.Empty;
            query += "DELETE FROM [tblThamSo] WHERE [MaTS] = @MaThamSo";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaThamSo", mats);
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
