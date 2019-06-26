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
    public class PhanQuyenDAL
    {
        private string connectionString;
        public PhanQuyenDAL()
        {
            ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public bool CheckTenDangNhap(string TenUser)
        {
            string query = string.Empty;
            List<string> lsTenDangNhap = new List<string>();
            query = "  select TenUser" +
                " from tblUser " +
                "where TenUser = @TenUser";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@TenUser", TenUser);

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                string tempTenUser = reader["TenUser"].ToString();
                                lsTenDangNhap.Add(tempTenUser);
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
            if(!lsTenDangNhap.Contains(TenUser))
            {
                return false;
            }
            return true;
        }

        public List<string> TimNguoiDung(string TenUser)
        {
            string query = string.Empty;
            List<string> lsPhanQuyen = new List<string>();
            query = "  select TenQuyen" +
                " from tblQuyen, tblUser_Quyen, tblUser " +
                "where tblUser_Quyen.MaUser = tblUser.MaUser and tblUser_Quyen.MaQuyen = tblQuyen.MaQuyen and TenUser = @TenUser";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@TenUser", TenUser);

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                              string Pq = reader["TenQuyen"].ToString();
                               lsPhanQuyen.Add(Pq);
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
           
            return lsPhanQuyen;
        }

        public bool ChinhSuaQuyen(string MaUser, string MaQuyen, bool Order)
        {
            if(Order==true)
            {
                string query = string.Empty;
                List<string> lsPhanQuyen = new List<string>();
                query = "insert into tblUser_Quyen values(@MaUser,@MaQuyen)";
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@MaUser", MaUser);
                        cmd.Parameters.AddWithValue("@MaQuyen",MaQuyen);
                        

                        try
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            con.Dispose();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            con.Close();
                            return false;
                        }
                    }
                }
            }
            else if(Order==false)
            {
                string query = string.Empty;
                List<string> lsPhanQuyen = new List<string>();
                query = "delete from tblUser_Quyen where MaUser=@MaUser and MaQuyen=@MaQuyen";
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@MaUser", MaUser);
                        cmd.Parameters.AddWithValue("@MaQuyen", MaQuyen);


                        try
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            con.Dispose();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            con.Close();
                            return false;
                        }
                    }
                }
            }
            return false;
        }


        public string getMaUser(string TenUser)
        {
            string query = string.Empty;
            string MaUser = string.Empty;
            query = "  select MaUser" +
                " from tblUser " +
                "where TenUser = @TenUser";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@TenUser", TenUser);

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                              MaUser= reader["MaUser"].ToString();
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
            return MaUser;

        }

        public string getMaQuyen(string TenQuyen)
        {
            string query = string.Empty;
            string MaQuyen = string.Empty;
            query = "select MaQuyen" +
                " from tblQuyen " +
                "where TenQuyen = @TenQuyen";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@TenQuyen", TenQuyen);

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                MaQuyen= reader["MaQuyen"].ToString();
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
            return MaQuyen;
        }

        public bool XoaNguoiDung(string MaUser)
        {
            string query = string.Empty;
            query += "delete from tblUser_Quyen where MaUser=@MaUser ";
            query += "delete from tblUser where MaUser=@MaUser";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaUser", MaUser);
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

        public bool TaoNguoiDung(string TenUser, string MatKhau)
        {
            string query = string.Empty;
            query += " select MaUser from tblUser";
            string mauser = string.Empty;
            List<string> DanhSachMaUser = new List<string>();
            List<string> DanhsachTenUser = new List<string>();
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
                                mauser = reader["MaUser"].ToString();
                                DanhSachMaUser.Add(mauser);
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

            int mausermoi = 0;
            do
            {
                mausermoi++;
                mauser = "US" + mausermoi.ToString();
            } while (DanhSachMaUser.Contains(mauser));
            query = string.Empty;
            query += "insert into tblUser values(@MaUser,@TenUser,@MatKhau)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaUser", mauser);
                    cmd.Parameters.AddWithValue("@TenUser", TenUser);
                    cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
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
