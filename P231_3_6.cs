using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P231_3_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            for(a=1;a<=1000;a++)
            {
                for (b = 0; b <= 1000; b++)
                {
                    for(c = 0; c <= 1000; c++)
                    {
                        for(d = 0; d <= 1000; d++)
                        {
                            if (a * a * a * a + b * b * b * b + c * c * c * c + d * d * d * d == a * 1000 + b * 100 + c * 10 + d)
                            {
                                Console.WriteLine(a * 1000 + b * 100 + c * 10 + d);
                            }
                        }
                    }
                }
            }
        }
    }
}
