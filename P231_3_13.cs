using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P232_3_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int []a=new int[10];
            int tep;
            string input=Console.ReadLine();
            string[] inputArr=input.Split(' ');
            for(int i=0;i<10; i++)
            {
                a[i] = int.Parse(inputArr[i]);
            }

            for(int i=0;i<10; i++)
            {
                Console.Write(a[i]+" ");
            }
            Console.WriteLine();

            for (int j=0;j<5;j++)
            {
                tep = a[j];
                a[j] = a[9 - j];
                a[9 - j] = tep;
            }

            Console.WriteLine("对换后数组：");
            for (int j = 0;j<10; j++)
            {
                Console.Write(a[j]+" ");
            }
            Console.WriteLine() ;
        }
    }
}
