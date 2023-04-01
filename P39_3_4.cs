using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            string a = Console.ReadLine();
            Console.Write("b=");
            string b = Console.ReadLine();
            double x = double.Parse(a);
            double y = double.Parse(b);
            Console.WriteLine ("a*b="+(x*y));
        }
    }
}
