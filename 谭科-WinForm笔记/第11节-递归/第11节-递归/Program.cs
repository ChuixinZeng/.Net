using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 第11节_递归
{
    class Program
    {
        static void Main(string[] args)
        {
            //阶乘：
            //5的阶乘：5*4*3*2*1
            //4的阶乘：4*3*2*1
            //3的阶乘：3*2*1
            Console.WriteLine(GetFact(4));
        }
        static int GetFact(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            return n * GetFact(n - 1);
        }
    }
}