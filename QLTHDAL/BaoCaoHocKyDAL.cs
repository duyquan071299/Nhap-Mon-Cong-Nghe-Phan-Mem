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
    public class BaoCaoHocKyDAL
    {
        private string connectionString;
        public BaoCaoHocKyDAL()
        {
            ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public List<BaoCaoHocKyDTO> BaoCaoHocKy(string HocKy)
        {
            List<BaoCaoHocKyDTO> lsBaoCaoHocKy = new List<BaoCaoHocKyDTO>();
            string query = string.Empty;
            query += "Select TenLop, SiSo " +
                "  from tblLop";

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
                                BaoCaoHocKyDTO BHK = new BaoCaoHocKyDTO();
                                BHK.Lop = reader["TenLop"].ToString();
                                BHK.SiSo = reader["SiSo"].ToString();
                                BHK.HocKy = HocKy;
                                lsBaoCaoHocKy.Add(BHK);
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

            foreach (BaoCaoHocKyDTO tempBCHK in lsBaoCaoHocKy)
            {
                query = string.Empty;
                query += "Select count(*) as SoLuongDat" +
                    " from ( Select MaLop, tblDiem.MaHS, AVG(DiemTrungBinh) as DTB" +
                            " from tblDiem, tblHocKi, tblHocSinh" +
                            " where tblDiem.MaHK = tblHocKi.MaHK and TenHK = @TenHK and tblDiem.MaHS = tblHocSinh.MaHS" +
                            " group by tblDiem.MaHS, MaLop) as B, tblLop" +
                    " where tblLop.MaLop = B.MaLop and TenLop = @TenLop and DTB> (select GiaTriTS " +
                                                                                    "from tblThamSo " +
                                                                                    "where TenTS = N'Điểm đạt') ";

                using (SqlConnection con = new SqlConnection(ConnectionString))
                {

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@TenLop", tempBCHK.Lop);
                        cmd.Parameters.AddWithValue("@TenHK", tempBCHK.HocKy);

                        try
                        {
                            con.Open();
                            SqlDataReader reader = null;
                            reader = cmd.ExecuteReader();
                            if (reader.HasRows == true)
                            {
                                while (reader.Read())
                                {
                                    tempBCHK.SLDat = reader["SoLuongDat"].ToString();
                                    
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
                tempBCHK.TiLeDat = ((float.Parse(tempBCHK.SLDat) / float.Parse(tempBCHK.SiSo)) * 100).ToString();

                
            }
            return lsBaoCaoHocKy;
        }
    }
}
