using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEF6
{
    class Program
    {
        static void Main(string[] args)
        {
            var serv = new ServiceImitation();

            var task = serv.Operation1();
            Console.WriteLine("create cash");
            task.Wait();

            Console.WriteLine("Run async");
            var task2 = serv.Operation1();
            task2.Wait();
            Console.WriteLine("Run sunc");

            serv.Operation2();

            Console.WriteLine("Finish");

            Console.ReadLine();
        }
    }
}
