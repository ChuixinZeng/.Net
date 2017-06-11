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
            //递归可以分而治之，把一个复杂的问题分解成简单的问题
            Console.WriteLine(GetFact(4)); //算4的阶乘，调用的是下面的GetFact方法
        }
        static int GetFact(int n)
        {
            if (n == 0 || n == 1) //n变成0或者变成1，都返回1，这样就可以只执行到4*3*2*1，而不是*0导致结果为0，因为0乘以任何数都为0
            {
                return 1;
            }
            return n * GetFact(n - 1);
        }
    }
}