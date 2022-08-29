using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EmailFundProject
{
    class Connection
    {
        public SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-AK16H71\SQLEXPRESS;Initial Catalog=EFDatabase;Integrated Security=True";
            return con;
        }
    }
}
