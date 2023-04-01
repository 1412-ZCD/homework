using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P78_3_5
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("请输入两个不相等的自然数：");
            int n=int.Parse(Console.ReadLine());
            int m=int.Parse(Console.ReadLine());
            int i;
            int top =n <m ? m : n;
            int down = n < m ? n : m;
            ArrayList arrayList = new ArrayList();
            for ( down = n < m ? n : m; down <= top-1; down++)
            {
                for( i = 2;i<= down; i++)
                {
                    if(down%i == 0)
                    {
                        break;
                    }
                }
                if (i == down)
                {
                    arrayList.Add(down);
                }
            }
           
            foreach(object o in arrayList)
            {
                Console.Write(o+" ");
            }
        }
    }
}
