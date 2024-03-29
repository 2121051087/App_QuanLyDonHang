using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_QuanLyDonHang
{
    internal class Modify
    {
       public Modify()
        {
        }
        SqlCommand sqlCommand; //  thuc thi cau lenh sql
        SqlDataReader dataReader; //  doc du lieu tu sql

        public List<TaiKhoan> taiKhoans(string query) // check tai khoan
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            using (SqlConnection sqlConnection = ConnectionString.GetConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    taiKhoans.Add(new TaiKhoan(dataReader.GetString(0), dataReader.GetString(1)));
                }
                
                sqlConnection.Close();
            }
            return taiKhoans;
        }

        public void Command(string query)//dung de dang ki tai khoan
        {
            using (SqlConnection sqlConnection = ConnectionString.GetConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
    }
}
