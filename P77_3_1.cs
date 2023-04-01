using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace P77_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("请用户输入一个非0浮点数:");
                string fudianshu = Console.ReadLine();
                decimal x = decimal.Parse(fudianshu);
                int fz = (int)x;                            //fz表示浮点数整数部分
                decimal fx = x - (decimal)fz;               //fx表示浮点数小数（0.xxx形式）
                Boolean f =true;
                while(f)
                {
                    fx = fx* 10;
                    int fxz = (int)fx;                      //fxz表示浮点数小数的整数部分，√，就是0或-0
                    decimal ZZ = (decimal)fxz - fx;         //ZZ表示浮点数小数的整数部分与浮点数小数的差
                    if (ZZ != 0)                            //ZZ等于0则已经将浮点数小数部分单独表示出来，不再是0.xxx的形式
                    {
                        continue;
                    }
                    else
                    {
                        f= false;
                    }
                }
                fx = (int)fx;
                if (x < 0)
                {
                    fx = -fx;
                }
                Console.WriteLine("该浮点数的整数部分为:" + fz);
                Console.WriteLine("该浮点数的小数部分为:" + fx);



                //Console.WriteLine("请用户输入一个非0浮点数:");
                //string a = Console.ReadLine();
                //decimal x = decimal.Parse(a);
                //int y = (int)x;
                //decimal z = x - (decimal)y;
                //if (x < 0)
                //{
                //    z = -z;
                //}
                //Console.WriteLine("该浮点数的整数部分为:" + y);
                //Console.WriteLine("该浮点数的小数部分为:" + z);

            }

        }
    }
}
