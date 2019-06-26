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

        public List<BaoCaoMonDTO> BaoCaoMon(BaoCaoMonDTO DTO)
        {
            List<BaoCaoMonDTO> lsbcm = new List<BaoCaoMonDTO>();
            string query = string.Empty;
            query += "select distinct d.TenLop, e.TenMonHoc, b.TenHK, d.SiSo ";
            query += "from tblDiem a, tblHocKi b, tblHocSinh c, tblLop d, tblMonHoc e ";
            if (DTO.Mon != "" && DTO.HocKy != "")
            {
                query += "where a.MaHK=b.MaHK and a.MaHS=c.MaHS and a.MaMonHoc=e.MaMonHoc and c.MaLop=d.MaLop and e.TenMonHoc=@TenMon and b.TenHK=@TenHK";
            }
            else if(DTO.Mon==""&&DTO.HocKy=="")
            {
                query += "where a.MaHK=b.MaHK and a.MaHS=c.MaHS and a.MaMonHoc=e.MaMonHoc and c.MaLop=d.MaLop";
            }
            else if (DTO.Mon != "" && DTO.HocKy == "")
            {
                query += "where a.MaHK=b.MaHK and a.MaHS=c.MaHS and a.MaMonHoc=e.MaMonHoc and c.MaLop=d.MaLop and e.TenMonHoc=@TenMon";
            }
            else if (DTO.Mon == "" && DTO.HocKy != "")
            {
                query += "where a.MaHK=b.MaHK and a.MaHS=c.MaHS and a.MaMonHoc=e.MaMonHoc and c.MaLop=d.MaLop and b.TenHK=@TenHK";
            }
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@TenMon", DTO.Mon);
                    cmd.Parameters.AddWithValue("@TenHK", DTO.HocKy);

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                BaoCaoMonDTO BCM = new BaoCaoMonDTO();
                                BCM.Lop = reader["TenLop"].ToString();
                                BCM.Mon = reader["TenMonHoc"].ToString();
                                BCM.HocKy = reader["TenHK"].ToString();
                                BCM.SiSo = reader["SiSo"].ToString();
                                BCM.DiemDat = DTO.DiemDat;
                                lsbcm.Add(BCM);
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

            foreach(BaoCaoMonDTO tempBCM in lsbcm)
            {
                query = string.Empty;
                query += "select count(*) SoLuongDat ";
                query += "from tblDiem a, tblHocKi b, tblHocSinh c, tblLop d, tblMonHoc e ";
                query += "where a.MaHK=b.MaHK and a.MaHS=c.MaHS and a.MaMonHoc=e.MaMonHoc " +
                    "and c.MaLop=d.MaLop and e.TenMonHoc=@TenMon and b.TenHK=@TenHK " +
                    "and d.TenLop=@TenLop and a.DiemTrungBinh>= (select GiaTriTS " +
                                                                                    "from tblThamSo " +
                                                                                    "where TenTS = N'Điểm đạt môn') ";
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@TenMon", tempBCM.Mon);
                        cmd.Parameters.AddWithValue("@TenHK", tempBCM.HocKy);
                        cmd.Parameters.AddWithValue("@TenLop", tempBCM.Lop);

                        try
                        {
                            con.Open();
                            SqlDataReader reader = null;
                            reader = cmd.ExecuteReader();
                            if (reader.HasRows == true)
                            {
                                while (reader.Read())
                                {
                                    tempBCM.SLDat = reader["SoLuongDat"].ToString();
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
                tempBCM.TiLeDat = ((float.Parse(tempBCM.SLDat) / float.Parse(tempBCM.SiSo))*100).ToString();
            }
            
         

            return lsbcm;
        }

    }
}
