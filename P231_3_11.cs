using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x =Math.PI/6;
            double y = -1;
            double deltax =1;
            while (Math.Abs(x-y) > 1e-6)
            {
                double fx = x * x + Math.Sin(x) + 1.0;
                double dfx=2*x+Math.Cos(x);
                deltax =-fx/dfx;
                x += deltax;
            }
            Console.WriteLine(x);
        }
    }
}
