using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P231_3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            for (m = 0; m <= 33; m++)
            {
                for (n = 0; n <= 20; n++)
                {
                    if (3 * m + 5 * n + (100 - m - n) / 3.0 == 100)
                    {
                        Console.WriteLine("公鸡个数：" + m);
                        Console.WriteLine("母鸡个数：" + n);
                        Console.WriteLine("小鸡个数：" + (100 - m - n));
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
