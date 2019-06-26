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
    public class DangNhapDAL
    {
        private string connectionString;

        public DangNhapDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public string ConnectionString { get => connectionString; set => connectionString = value; }


        public bool DangNhap(DangNhapDTO User)
        {
            string query = string.Empty;
            List<DangNhapDTO> lsUser = new List<DangNhapDTO>();
            query = "Select TenUser, MatKhau from [tblUser]";
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
                                DangNhapDTO Dn = new DangNhapDTO();
                                Dn.TenDangNhap= reader["TenUser"].ToString();
                                Dn.MatKhau= reader["MatKhau"].ToString();
                                lsUser.Add(Dn);
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
            foreach(DangNhapDTO tempDTO in lsUser)
            {
                if(tempDTO.TenDangNhap==User.TenDangNhap)
                {
                    if(tempDTO.MatKhau==User.MatKhau)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }


            return false;
        }
    }
}
