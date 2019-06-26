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
    public class TraCuuDAL
    {
        private string connectionString;
        public TraCuuDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public List<TraCuuTTHSDTO> TraCuuHocSinh(TraCuuTTHSDTO TTHSDTO)
        {
            List<TraCuuTTHSDTO> lsTTHS = new List<TraCuuTTHSDTO>();
            string query = string.Empty;
            if (TTHSDTO.HoTen != "" && TTHSDTO.MaHS != "" && TTHSDTO.Lop != "")
            {
                query += "select a.*,b.TenLop ";
                query += "from tblHocSinh a, tblLop b ";
                query += "where a.MaLop = b.MaLop and (a.MaHS = @MaHS and b.TenLop = @TenLop)";
            }
            else if (TTHSDTO.HoTen != "" && TTHSDTO.MaHS != "" && TTHSDTO.Lop == "")
            {
                query += "select a.*,b.TenLop ";
                query += "from tblHocSinh a, tblLop b ";
                query += "where a.MaLop = b.MaLop and a.MaHS = @MaHS ";
            }
            else if (TTHSDTO.HoTen != "" && TTHSDTO.MaHS == "" && TTHSDTO.Lop == "")
            {
                query += "select a.*,b.TenLop ";
                query += "from tblHocSinh a, tblLop b ";
                query += "where a.MaLop = b.MaLop and a.TenHocSinh = @TenHS ";
            }
            else if (TTHSDTO.HoTen == "" && TTHSDTO.MaHS != "" && TTHSDTO.Lop == "")
            {
                query += "select a.*,b.TenLop ";
                query += "from tblHocSinh a, tblLop b ";
                query += "where a.MaLop = b.MaLop and a.MaHS = @MaHS ";
            }
            else if (TTHSDTO.HoTen == "" && TTHSDTO.MaHS == "" && TTHSDTO.Lop != "")
            {
                query += "select a.*,b.TenLop ";
                query += "from tblHocSinh a, tblLop b ";
                query += "where a.MaLop = b.MaLop and b.TenLop = @TenLop ";
            }
            else if (TTHSDTO.HoTen != "" && TTHSDTO.MaHS == "" && TTHSDTO.Lop != "")
            {
                query += "select a.*,b.TenLop ";
                query += "from tblHocSinh a, tblLop b ";
                query += "where a.MaLop = b.MaLop and b.TenLop = @TenLop and a.TenHocSinh=@TenHS ";
            }
            else if(TTHSDTO.HoTen == "" && TTHSDTO.MaHS != "" && TTHSDTO.Lop != "")
            {
                query += "select a.*,b.TenLop ";
                query += "from tblHocSinh a, tblLop b ";
                query += "where a.MaLop = b.MaLop and b.TenLop = @TenLop and a.MaHS =@MaHS ";
            }
            else if (TTHSDTO.HoTen == "" && TTHSDTO.MaHS == "" && TTHSDTO.Lop == "")
            {
                query += "select a.*,b.TenLop ";
                query += "from tblHocSinh a, tblLop b ";
                query += "where a.MaLop = b.MaLop";
            }
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@TenLop", TTHSDTO.Lop);
                    cmd.Parameters.AddWithValue("@TenHS", TTHSDTO.HoTen);
                    cmd.Parameters.AddWithValue("@MaHS", TTHSDTO.MaHS);

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                TraCuuTTHSDTO QLHS = new TraCuuTTHSDTO();
                                QLHS.MaHS = reader["MaHS"].ToString();
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
                                QLHS.Lop = reader["TenLop"].ToString();
                                lsTTHS.Add(QLHS);
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
            
            if (TTHSDTO.HoTen != "" && TTHSDTO.MaHS != "" && TTHSDTO.Lop == "")
            {
                query += "select a.* ";
                query += "from tblHocSinh a ";
                query += "where a.MaHS = @MaHS and a.TenHocSinh=@TenHS and a.MaLop is null";
            }
            else if (TTHSDTO.HoTen != "" && TTHSDTO.MaHS == "" && TTHSDTO.Lop == "")
            {
                query += "select a.* ";
                query += "from tblHocSinh a ";
                query += "where a.TenHocSinh = @TenHS and a.MaLop is null";
            }
            else if (TTHSDTO.HoTen == "" && TTHSDTO.MaHS != "" && TTHSDTO.Lop == "")
            {
                query += "select a.* ";
                query += "from tblHocSinh a ";
                query += "where a.MaHS = @MaHS and a.MaLop is null";
            }
            else if (TTHSDTO.HoTen == "" && TTHSDTO.MaHS == "" && TTHSDTO.Lop == "")
            {
                query += "select a.* ";
                query += "from tblHocSinh a ";
                query += "where a.MaLop is null";
            }
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@TenLop", TTHSDTO.Lop);
                    cmd.Parameters.AddWithValue("@TenHS", TTHSDTO.HoTen);
                    cmd.Parameters.AddWithValue("@MaHS", TTHSDTO.MaHS);

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                TraCuuTTHSDTO QLHS = new TraCuuTTHSDTO();
                                QLHS.MaHS = reader["MaHS"].ToString();
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
                                QLHS.Lop = "";
                                lsTTHS.Add(QLHS);
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

            return lsTTHS;
        }

        public List<TraCuuDiemDTO> TraCuuDiem(TraCuuDiemDTO TTDiemDTO)
        {
            List<TraCuuDiemDTO> lsTTDiem = new List<TraCuuDiemDTO>();
            string query = string.Empty;
            query += "select d.MaHS,d.TenHocSinh, e.TenLop, c.TenHK,b.TenMonHoc,a.Diem15,a.Diem45,a.DiemCuoiKi,a.DiemTrungBinh ";
            query += "from tblDiem a, tblMonHoc b, tblHocKi c, tblHocSinh d, tblLop e ";
            if (TTDiemDTO.MSHocSInh != "" && TTDiemDTO.HoTenHS != "" && TTDiemDTO.Mon != "" && TTDiemDTO.HocKy != "")
            {
                query += "where d.MaLop=e.MaLop and a.MaHS = d.MaHS and a.MaHK = c.MaHK and a.MaMonHoc = b.MaMonHoc and d.MaHS = @MaHS and d.TenHocSinh = @TenHS and b.TenMonHoc=@TenMH and c.TenHK=@TenHK";
            }
            else if (TTDiemDTO.MSHocSInh != "" && TTDiemDTO.HoTenHS == "" && TTDiemDTO.Mon != "" && TTDiemDTO.HocKy != "")
            {
                query += "where d.MaLop=e.MaLop and a.MaHS = d.MaHS and a.MaHK = c.MaHK and a.MaMonHoc = b.MaMonHoc and d.MaHS = @MaHS and b.TenMonHoc=@TenMH and c.TenHK=@TenHK";
            }
            else if (TTDiemDTO.MSHocSInh == "" && TTDiemDTO.HoTenHS != "" && TTDiemDTO.Mon != "" && TTDiemDTO.HocKy != "")
            {
                query += "where d.MaLop=e.MaLop and a.MaHS = d.MaHS and a.MaHK = c.MaHK and a.MaMonHoc = b.MaMonHoc and d.TenHocSinh = @TenHS and b.TenMonHoc=@TenMH and c.TenHK=@TenHK";
            }
            else if (TTDiemDTO.MSHocSInh != "" && TTDiemDTO.HoTenHS == "" && TTDiemDTO.Mon == "" && TTDiemDTO.HocKy == "")
            {
                query += "where d.MaLop=e.MaLop and a.MaHS = d.MaHS and a.MaHK = c.MaHK and a.MaMonHoc = b.MaMonHoc and d.MaHS = @MaHS";
            }
            else if (TTDiemDTO.MSHocSInh == "" && TTDiemDTO.HoTenHS != "" && TTDiemDTO.Mon == "" && TTDiemDTO.HocKy == "")
            {
                query += "where d.MaLop=e.MaLop and a.MaHS = d.MaHS and a.MaHK = c.MaHK and a.MaMonHoc = b.MaMonHoc and d.TenHocSinh = @TenHS";
            }
            else if (TTDiemDTO.MSHocSInh != "" && TTDiemDTO.HoTenHS == "" && TTDiemDTO.Mon != "" && TTDiemDTO.HocKy == "")
            {
                query += "where d.MaLop=e.MaLop and a.MaHS = d.MaHS and a.MaHK = c.MaHK and a.MaMonHoc = b.MaMonHoc and d.MaHS = @MaHS and b.TenMonHoc=@TenMH";
            }
            else if (TTDiemDTO.MSHocSInh == "" && TTDiemDTO.HoTenHS != "" && TTDiemDTO.Mon != "" && TTDiemDTO.HocKy == "")
            {
                query += "where d.MaLop=e.MaLop and a.MaHS = d.MaHS and a.MaHK = c.MaHK and a.MaMonHoc = b.MaMonHoc and d.TenHocSinh = @TenHS and b.TenMonHoc=@TenMH";
            }
            else if (TTDiemDTO.MSHocSInh != "" && TTDiemDTO.HoTenHS == "" && TTDiemDTO.Mon == "" && TTDiemDTO.HocKy != "")
            {
                query += "where d.MaLop=e.MaLop and a.MaHS = d.MaHS and a.MaHK = c.MaHK and a.MaMonHoc = b.MaMonHoc and d.MaHS = @MaHS and c.TenHK=@TenHK";
            }
            else if (TTDiemDTO.MSHocSInh == "" && TTDiemDTO.HoTenHS != "" && TTDiemDTO.Mon == "" && TTDiemDTO.HocKy != "")
            {
                query += "where d.MaLop=e.MaLop and a.MaHS = d.MaHS and a.MaHK = c.MaHK and a.MaMonHoc = b.MaMonHoc and d.TenHocSinh = @TenHS and c.TenHK=@TenHK";
            }
            else if (TTDiemDTO.MSHocSInh != "" && TTDiemDTO.HoTenHS != "" && TTDiemDTO.Mon == "" && TTDiemDTO.HocKy == "")
            {
                query += "where d.MaLop=e.MaLop and a.MaHS = d.MaHS and a.MaHK = c.MaHK and a.MaMonHoc = b.MaMonHoc and d.MaHS = @MaHS and d.TenHocSinh = @TenHS";
            }
            else if (TTDiemDTO.MSHocSInh != "" && TTDiemDTO.HoTenHS != "" && TTDiemDTO.Mon != "" && TTDiemDTO.HocKy == "")
            {
                query += "where d.MaLop=e.MaLop and a.MaHS = d.MaHS and a.MaHK = c.MaHK and a.MaMonHoc = b.MaMonHoc and d.MaHS = @MaHS and d.TenHocSinh = @TenHS and b.TenMonHoc=@TenMH";
            }
            else if (TTDiemDTO.MSHocSInh != "" && TTDiemDTO.HoTenHS != "" && TTDiemDTO.Mon == "" && TTDiemDTO.HocKy != "")
            {
                query += "where d.MaLop=e.MaLop and a.MaHS = d.MaHS and a.MaHK = c.MaHK and a.MaMonHoc = b.MaMonHoc and d.MaHS = @MaHS and d.TenHocSinh = @TenHS and c.TenHK=@TenHK";
            }
            else if (TTDiemDTO.MSHocSInh == "" && TTDiemDTO.HoTenHS == "" && TTDiemDTO.Mon != "" && TTDiemDTO.HocKy != "")
            {
                query += "where d.MaLop=e.MaLop and a.MaHS = d.MaHS and a.MaHK = c.MaHK and a.MaMonHoc = b.MaMonHoc and b.TenMonHoc=@TenMH and c.TenHK=@TenHK";
            }
            else if (TTDiemDTO.MSHocSInh == "" && TTDiemDTO.HoTenHS == "" && TTDiemDTO.Mon == "" && TTDiemDTO.HocKy != "")
            {
                query += "where d.MaLop=e.MaLop and a.MaHS = d.MaHS and a.MaHK = c.MaHK and a.MaMonHoc = b.MaMonHoc and c.TenHK=@TenHK";
            }
            else if (TTDiemDTO.MSHocSInh == "" && TTDiemDTO.HoTenHS == "" && TTDiemDTO.Mon != "" && TTDiemDTO.HocKy == "")
            {
                query += "where d.MaLop=e.MaLop and a.MaHS = d.MaHS and a.MaHK = c.MaHK and a.MaMonHoc = b.MaMonHoc and b.TenMonHoc=@TenMH";
            }
            else if (TTDiemDTO.MSHocSInh == "" && TTDiemDTO.HoTenHS == "" && TTDiemDTO.Mon == "" && TTDiemDTO.HocKy == "")
            {
                query += "where d.MaLop=e.MaLop and a.MaHS = d.MaHS and a.MaHK = c.MaHK and a.MaMonHoc = b.MaMonHoc";
            }
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaHS", TTDiemDTO.MSHocSInh);
                    cmd.Parameters.AddWithValue("@TenHS", TTDiemDTO.HoTenHS);
                    cmd.Parameters.AddWithValue("@TenHK", TTDiemDTO.HocKy);
                    cmd.Parameters.AddWithValue("@TenMH", TTDiemDTO.Mon);

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                TraCuuDiemDTO QLD = new TraCuuDiemDTO();
                                QLD.MSHocSInh = reader["MaHS"].ToString();
                                QLD.HoTenHS = reader["TenHocSinh"].ToString();
                                QLD.Diem15Ph = reader["Diem15"].ToString();
                                QLD.Diem45Ph = reader["Diem45"].ToString();
                                QLD.DiemCK = reader["DiemCuoiKi"].ToString();
                                QLD.DiemTB = reader["DiemTrungBinh"].ToString();
                                QLD.Lop = reader["TenLop"].ToString();
                                QLD.Mon = reader["TenMonHoc"].ToString();
                                QLD.HocKy = reader["TenHK"].ToString();
                                lsTTDiem.Add(QLD);
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

            return lsTTDiem;
        }
    }
}
