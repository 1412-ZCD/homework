using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P231_3_9
{
    internal class Program
    {
        static int Fib(int n)
        {
            if(n==1) return 0;
            else if(n==2) return 1;
            else return Fib(n-1)+Fib(n-2);
        }

        static int FIB(int x)
        {
            int[] y=new int[x+1];
            if (x == 1) return 0;
            if (x == 2) return 1;
            for(int i = 3; i <= x; i++)
            {
                y[1] = 0;
                y[2] = 1;
                y[i] = y[i-1]+y[i-2];
                if (i == x) return y[i];
            }
            return 0;
            
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("请输入一个数：");
            string input=Console.ReadLine();
            n=int.Parse(input);
            Console.WriteLine(Fib(n));
            Console.WriteLine(FIB(n));
        }
    }
}
