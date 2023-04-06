using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace P231_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double N = 100; //改变N的大小来改变随机数生成个数
            int[] n = new int[6];
            int count = -1;
            Random rnd = new Random();

            for (int i = 0; i < N; i++)
            {

                int num = rnd.Next(1, 7);
                switch (num)
                {
                    case 1: n[0]++; break;
                    case 2: n[1]++; break;
                    case 3: n[2]++; break;
                    case 4: n[3]++; break;
                    case 5: n[4]++; break;
                    case 6: n[5]++; break;
                }
                ++count;
                for (int j = 1; j <= N / 5; j++)
                {
                    if (count == j * 5)
                    {
                        Console.WriteLine();
                    }
                }
                Console.Write(num + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("数字" + (i + 1) + "出现的概率=" + (n[i] / N )* 100 + "%");
            }
        }
    }
}
