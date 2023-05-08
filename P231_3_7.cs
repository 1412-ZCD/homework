using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P231_3_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int n=1;n<1000;n++)
            {
                int s = divsum(n);
                if(n<s && divsum(s)==n)
                {
                    Console.WriteLine(n + "," + s);
                }
            }
        }

        public static int divsum(int n)
        {
            int s = 0;
            for(int i = 1; i < n; i++)
            {
                if (n % i == 0) s += i;
            }
            return s;
        }
    }
}
