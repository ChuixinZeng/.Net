using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第4节_按钮
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //主函数创建出来form1
            //把创建的静态类加入主程序，这个类的值是Form1，即btnOK

            clsForm.fr = new Form1();
            Application.Run(clsForm.fr);

       
        }
    }
}
