using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class SqlServerAccess
    {


        public SqlServerAccess(string myConnectionString)
        {
            MyConnectionString = myConnectionString;
        }

         public string MyConnectionString { get; init; }

        public int SqlAccessConnect()
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = MyConnectionString;
                cn.Open();

                using (SqlCommand cm = new SqlCommand())
                {
                    cm.Connection = cn;

                    cm.CommandText = "SELECT Count(*) FROM Member";
                    cm.CommandType = CommandType.Text;

                    var reply = (int)cm.ExecuteScalar();

                    return reply;
                }
            }
        }
    }
}
