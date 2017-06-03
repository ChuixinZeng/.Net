using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第4节_按钮
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            //this.Close();//关闭当前窗口
            //关闭所有窗口
            //如果能在这里拿到主窗体，关闭它，就能达到关闭所有窗口的目的

            //可以通过静态字段来实现，静态字段对于整个程序来说都是共享的，所以在第4节下面添加一个静态类clsForm.cs
            //使用前面在clsForm.cs和主程序program.cs中定义好的clsForm
            clsForm.fr.Close();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
