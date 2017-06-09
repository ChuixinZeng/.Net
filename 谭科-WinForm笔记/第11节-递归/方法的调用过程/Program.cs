using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 方法的调用过程
{
    class Program
    {
        static int i = 0;
        static void Main(string[] args)
        {
            M1();
            Console.ReadKey();
        }
        static void M1()
        {
            i++;
            Console.WriteLine("M1方法");
            if (i <= 5)
            {
                M1();//函数直接或间接地调用了自己，这就叫递归。
            }

            //使用递归，必须有一个结束的条件，也叫递归出口。
        }
        static void M2()
        {
            Console.WriteLine("M2方法");
            M3();
        }

        static void M3()
        {
            Console.WriteLine("M3方法");
        }
    }
}
