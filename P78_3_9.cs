using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P78_3_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();
            bool[] isprime = new bool[100];
            int i, j;
            for(int n=2;n<isprime.Length;n++)
            {
                isprime[n] = true;
            }
            for( i = 2; i <isprime.Length; i++)
            {
                if (isprime[i]) 
                {
                    for (j = 2 * i; j <isprime.Length; j += i)
                    {
                        isprime[j] = false;
                    }
                    if (isprime[i])
                    {
                        array.Add(i);
                    }
                }
            }
            foreach(object o in array) 
            {
                Console.Write(o+" ");
            }
        }
        
    }
}
