using System;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleEF6
{
    public class ServiceImitation
    {
        public ServiceImitation()
        {
        }

        public async Task Operation1()
        {
            var sw = new Stopwatch();
            sw.Start();
            using(var db = new MyDbContext())
            {
                for (int i = 0; i < 10; i++)
                {
                    db.Blogs.Add(new Blogs { Name = "New name" + i, Title = "New title" + i });
                }

                await db.SaveChangesAsync();

                var blogs = await (from b in db.Blogs
                                   orderby b.Name
                                   select b).ToListAsync();

                foreach (var blog in blogs)
                {
                    Console.WriteLine(" - " + blog.Name);
                }

            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }

        public void Operation2()
        {
            var sw = new Stopwatch();
            sw.Start();
            using (var db = new MyDbContext())
            {
                for (int i = 0; i < 10; i++)
                {
                    db.Blogs.Add(new Blogs { Name = "New name" + i, Title = "New title" + i });
                }

                db.SaveChanges();

                var blogs = (from b in db.Blogs
                                  orderby b.Name
                                  select b).ToList();

                foreach (var blog in blogs)
                {
                    Console.WriteLine(" - " + blog.Name);
                }

            }

            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
    }
}
