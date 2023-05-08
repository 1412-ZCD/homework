using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P231_3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x ;
            for (x = 0; x <= 40; x++)
            {
                if (x * 2 + 4 * (40 - x) == 100)
                {
                    Console.WriteLine("鸡的个数：" + x);
                    Console.WriteLine("兔的个数："+(40-x));
                }
            }

        }
    }
}
