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
    public partial class Form1 : Form
    {
        /// <summary>
        ///form1是主函数运行时创建的窗体，叫主窗体
        ///一旦关闭主窗体，所有窗体都会被关闭
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // this.Close();//关闭窗体

            //btnOK frm = new btnOK();//新建窗体
            //frm.Show();//显示窗体，新建的窗体依赖于父窗体，父窗体关掉了，后面的所有窗体都会关掉

            //给按钮设置默认值的三种方式，默认创建的第一个按钮就是默认按钮，我们按键盘的enter键的时候，会执行这个按钮
            //1:设置默认按钮：选中窗体，设置acceptbuttion
            //2:Esc控制：选中窗体，设置CancelButton
            //3:加快捷键：选中按钮，设置text值为 &加上字母

            Form2 frm2 = new Form2();
            frm2.Show();

            {

            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //下面是一个提示框，按ESC能显示
            MessageBox.Show("我是ESC按钮"); 

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我是快捷按钮");
        }
    }
}
