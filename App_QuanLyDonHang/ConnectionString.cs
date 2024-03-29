using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_QuanLyDonHang
{
    internal class ConnectionString
    {
        private static string StringConnection = @"Data Source=zugooo\sqlexpress;Initial Catalog=QLDH;Integrated Security=True;Encrypt=False";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(StringConnection);
        }
    }
}
