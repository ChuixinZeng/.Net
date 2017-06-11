using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//递归算法的效率比较低，一般不建议使用，内存的开销比较高，但是在解决特殊问题的时候可以达到事半功倍的效果

namespace 方法的调用过程
{
    class Program
    {
        static int i = 0;
        static void Main(string[] args)
        {
            M1();
            Console.ReadKey(); //暂停
        }
        static void M1()
        {
            i++;
            Console.WriteLine("M1方法");
            if (i <= 5) //只打印五次M1方法，这样就不会自己调自己，无限循环，导致堆栈溢出
            {
                M1();//函数直接或间接地调用了自己，这就叫递归。MI调用M1自己，没有结束的条件
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
