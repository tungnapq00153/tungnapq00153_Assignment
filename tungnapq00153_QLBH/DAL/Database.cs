using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace tungnapq00153_QLBH.DAL
{
    class Database
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=ANHTUNG-PC\SQL_KODCTHINGHI;Database=tungnapq00153_QLBH;User Id=sa;Password=Abc123!@#;";
            con.Open();

            return con;
        }
    }
}
