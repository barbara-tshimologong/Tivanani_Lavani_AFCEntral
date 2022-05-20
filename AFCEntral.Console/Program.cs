using System;
using DataAccess;

namespace AFCEntral.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");

            SqlServerAccess ssa = new SqlServerAccess();
            ssa.MyConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = AFCentral; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

            var replyCount = ssa.SqlAccessConnect();

            System.Console.WriteLine($"The number of rows in the Person table is: { replyCount}");
        }
  }
}
