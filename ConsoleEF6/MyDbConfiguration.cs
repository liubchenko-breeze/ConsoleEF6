using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace ConsoleEF6
{
    public class MyDbConfiguration : DbConfiguration
    {
        public MyDbConfiguration()
        {
            //SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
            //SetDefaultConnectionFactory(new LocalDbConnectionFactory("SQLEXPRESS1"));
        }
    }
}
