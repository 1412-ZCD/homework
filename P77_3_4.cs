using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P77_3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           while (true)
            {
                Console.WriteLine("请用户输入一个1~12的整数：");
                int num = int.Parse(Console.ReadLine());
                if (num < 1 || num > 12)
                {
                    Console.WriteLine("您输入的数字不在1~12的范围内！");
                    continue;
                }
                else
                {
                    switch(num)
                    {
                        case 1:
                            Console.WriteLine("1月有31天。");
                            break;
                        case 2:
                            Console.WriteLine("2月有27或28天。");
                            break;
                        case 3:
                            Console.WriteLine("3月有31天。");
                            break;
                        case 4:
                            Console.WriteLine("4月有30天。");
                            break;
                        case 5:
                            Console.WriteLine("5有31天。");
                            break;
                        case 6:
                            Console.WriteLine("6月有30天。");
                            break;
                        case 7:
                            Console.WriteLine("7月有31天。");
                            break;
                        case 8:
                            Console.WriteLine("8月有31天。");
                            break;
                        case 9:
                            Console.WriteLine("9月有30天。");
                            break;
                        case 10:
                            Console.WriteLine("10月有31天。");
                            break;
                        case 11:
                            Console.WriteLine("11月有30天。");
                            break;
                        case 12:
                            Console.WriteLine("12月有31天。");
                            break;
                    }
                }
            }
        }
    }
}
