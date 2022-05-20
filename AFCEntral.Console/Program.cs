using System;
using DataAccess;

namespace AFCEntral.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");

            var cs = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = AFCentral; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

            SqlServerAccess ssa = new SqlServerAccess(cs);

            var replyCount = ssa.SqlAccessConnect();

            System.Console.WriteLine($"The number of rows in the Person table is: { replyCount}");
        }
  }
}
