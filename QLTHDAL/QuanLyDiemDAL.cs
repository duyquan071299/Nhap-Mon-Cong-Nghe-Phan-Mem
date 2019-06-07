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

        public List<QuanLyDiemDTO> SelectHS(string TenLop)
        {
            string query = string.Empty;
            query += "Select [TenHocSinh], [GioiTinh]" +
                " from [tblDiem],[tblHocSinh],[tblLop]" +
                " where [tblDiem].[MaHS]=[tblHocSinh].[MaHS] and [tblDiem].[MaLop]=[tblLop].[MaLop] and [tblDSLop].TenLop=@TenLop";

            List<QuanLyDiemDTO> lsQLD = new List<QuanLyDiemDTO>();

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
                                QuanLyDiemDTO QLD = new QuanLyDiemDTO();
                                QLD.HoTen = reader["TenHocSinh"].ToString();
                                QLD.GioiTinh = reader["GioiTinh"].ToString();
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

        public bool Them(QuanLyDiemDTO QLD)
        {
            string query = string.Empty;
            query += "UPDATE tblHocSinh SET [Diem15]=@Diem15,[Diem45]=@Diem45,[DiemHocKy]=@DiemHocKy,[DiemTB]=@DiemTB " +
                " WHERE [MaHS]=@MaHocSinh";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    SqlCommand cm = new SqlCommand();

                    cm.CommandText = "Select [MaHS] from [tblHocSinh] where [TenHocSinh]=@TenHS";
                    cm.Parameters.AddWithValue("@TenHS", QLD.HoTen);
                    SqlDataReader reader = null;
                    reader = cm.ExecuteReader();
                    if (reader.HasRows == true)
                    {
                        while (reader.Read())
                        {
                            string MaTemp = reader["MaHS"].ToString();
                            cmd.Parameters.AddWithValue("@MaHS", MaTemp);
                        }
                    }

                    cmd.Parameters.AddWithValue("@Diem15", QLD.Diem15Ph);
                    cmd.Parameters.AddWithValue("@Diem45", QLD.Diem45Ph);
                    cmd.Parameters.AddWithValue("@DiemHocKy", QLD.DiemHocKy);
                    cmd.Parameters.AddWithValue("@DiemTB", QLD.DiemTB);
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

        public bool Sua(QuanLyDiemDTO QLD)
        {
            string query = string.Empty;
            query += "UPDATE tblHocSinh SET [Diem15]=@Diem15,[Diem45]=@Diem45,[DiemHocKy]=@DiemHocKy,[DiemTB]=@DiemTB  WHERE [MaHS]=@MaHocSinh";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    SqlCommand cm = new SqlCommand();

                    cm.CommandText = "Select [MaHS] from [tblHocSinh] where [TenHocSinh]=@TenHS";
                    cm.Parameters.AddWithValue("@TenHS", QLD.HoTen);
                    SqlDataReader reader = null;
                    reader = cm.ExecuteReader();
                    if (reader.HasRows == true)
                    {
                        while (reader.Read())
                        {
                            string MaTemp = reader["MaHS"].ToString();
                            cmd.Parameters.AddWithValue("@MaHS", MaTemp);
                        }
                    }
                    cmd.Parameters.AddWithValue("@Diem15", QLD.Diem15Ph);
                    cmd.Parameters.AddWithValue("@Diem45", QLD.Diem45Ph);
                    cmd.Parameters.AddWithValue("@DiemHocKy", QLD.DiemHocKy);
                    cmd.Parameters.AddWithValue("@DiemTB", QLD.DiemTB);
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
