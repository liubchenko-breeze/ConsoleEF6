using System.Data.Entity;

namespace ConsoleEF6
{
    //[DbConfigurationType(typeof(MyDbConfiguration))]
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("name=testDatabseSection")
        {

        }
        public DbSet<Blogs> Blogs { get; set; }


    }
}
