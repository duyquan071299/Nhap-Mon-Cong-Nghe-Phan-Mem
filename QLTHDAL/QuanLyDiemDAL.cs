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
    public class QuanLyDiemDAL
    {
        private string connectionString;
        public QuanLyDiemDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public List<QuanLyDiemDTO> SelectHS(QuanLyDiemDTO qldDTO)
        {
            string query = string.Empty;
            query += "Select a.MaHS, a.TenHocSinh,c.Diem15,c.Diem45,c.DiemCuoiKi, c.DiemTrungBinh " +
                    "from tblHocSinh a,tblLop b, tblDiem c, tblMonHoc d, tblHocKi e" +
                    " where a.MaLop = b.MaLop and a.MaHS = c.MaHS and c.MaMonHoc = d.MaMonHoc and c.MaHK = e.MaHK "+
                    "and b.TenLop = @TenLop and e.TenHK = @TenHK and d.TenMonHoc = @TenMon";

            List<QuanLyDiemDTO> lsQLD = new List<QuanLyDiemDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@TenLop", qldDTO.Lop);
                    cmd.Parameters.AddWithValue("@TenHK", qldDTO.HocKy);
                    cmd.Parameters.AddWithValue("@TenMon", qldDTO.Mon);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                QuanLyDiemDTO QLD = new QuanLyDiemDTO();
                                QLD.MaHS = reader["MaHS"].ToString();
                                QLD.HoTen = reader["TenHocSinh"].ToString();
                                QLD.Diem15Ph = reader["Diem15"].ToString();
                                QLD.Diem45Ph = reader["Diem45"].ToString();
                                QLD.DiemHocKy = reader["DiemCuoiKi"].ToString();
                                QLD.DiemTB = reader["DiemTrungBinh"].ToString();
                                lsQLD.Add(QLD);
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
            return lsQLD;
        }
        

        public bool Sua(QuanLyDiemDTO QLD)
        {
            string query = string.Empty;
            query += "select a.MaHK, b.MaMonHoc " +
                    "from tblHocKi a, tblMonHoc b " +
                    "where a.TenHK = @TenHK and b.TenMonHoc = @TenMon";
            string mahk = string.Empty;
            string mamonhoc = string.Empty;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@TenHK", QLD.HocKy);
                    cmd.Parameters.AddWithValue("@TenMon", QLD.Mon);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                mahk = reader["MaHK"].ToString();
                                mamonhoc = reader["MaMonHoc"].ToString();
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

            query = string.Empty;
            query += "UPDATE tblDiem SET [Diem15]=@Diem15,[Diem45]=@Diem45,[DiemCuoiKi]=@DiemCuoiKi,[DiemTrungBinh]=(@Diem15 + @Diem45 * 2 + @DiemCuoiKi * 3)/6   WHERE [MaHS]=@MaHS and MaMonHoc=@MaMon and MaHK=@MaHK";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaHS", QLD.MaHS);
                    cmd.Parameters.AddWithValue("@MaMon", mamonhoc);
                    cmd.Parameters.AddWithValue("@MaHK", mahk);
                    cmd.Parameters.AddWithValue("@Diem15", float.Parse(QLD.Diem15Ph));
                    cmd.Parameters.AddWithValue("@Diem45", float.Parse(QLD.Diem45Ph));
                    cmd.Parameters.AddWithValue("@DiemCuoiKi", float.Parse(QLD.DiemHocKy));
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

        public bool LamMoi(QuanLyDiemDTO QLD)
        {
            string query = string.Empty;
            query += "select a.MaHK, b.MaMonHoc, c.MaHS " +
                    "from tblHocKi a, tblMonHoc b, tblHocSinh c, tblLop d " +
                    "where c.MaLop=d.MaLop and a.TenHK = @TenHK and b.TenMonHoc = @TenMon and d.TenLop=@TenLop";
            string mahk = string.Empty;
            string mamonhoc = string.Empty;
            List<string> lsmahs = new List<string>();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@TenHK", QLD.HocKy);
                    cmd.Parameters.AddWithValue("@TenMon", QLD.Mon);
                    cmd.Parameters.AddWithValue("@TenLop", QLD.Lop);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                string mahs = string.Empty;
                                mahk = reader["MaHK"].ToString();
                                mamonhoc = reader["MaMonHoc"].ToString();
                                mahs = reader["MaHS"].ToString();
                                lsmahs.Add(mahs);
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
            foreach (string mahs in lsmahs)
            {
                query = string.Empty;
                query += "UPDATE tblDiem SET [Diem15]='0',[Diem45]='0',[DiemCuoiKi]='0',[DiemTrungBinh]='0' WHERE MaMonHoc=@MaMon and MaHK=@MaHK and MaHS=@MaHS";
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@MaHS", mahs);
                        cmd.Parameters.AddWithValue("@MaMon", mamonhoc);
                        cmd.Parameters.AddWithValue("@MaHK", mahk);
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

        public List<QuanLyDiemDTO> SelectDSMonHoc()
        {
            string query = string.Empty;
            query += "Select * " +
                "from tblMonHoc";

            List<QuanLyDiemDTO> lsDSMon = new List<QuanLyDiemDTO>();

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
                                QuanLyDiemDTO QLD = new QuanLyDiemDTO();
                                QLD.Mon = reader["TenMonHoc"].ToString();
                                lsDSMon.Add(QLD);
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
            return lsDSMon;
        }


    } 
}
