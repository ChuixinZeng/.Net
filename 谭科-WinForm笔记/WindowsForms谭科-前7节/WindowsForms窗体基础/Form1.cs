using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//其实所有的控件都是继承至form类

namespace WindowsForms窗体基础
{
    public partial class Form1 : Form  //partial代表这是一个部分类，这部分主要放form的后台代码
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) //窗体创建加载完成后，需要执行的操作
        {
            //form1_load是窗体的默认事件，双击窗口的时候自动生成的，证明load事件用的比较多

            /* 窗体加载的时候，弹出一个欢迎框
                MessageBox.Show("欢迎来到窗体学习"); */

            //当窗体加载的时候，就设置左边距为50
            this.Left = 50;

        }

        private void 名字修改一下_Click(object sender, EventArgs e)
        {
            //控件的属性里面name修改成什么，上面的click名称就是什么

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //单击主窗体的时候，发生click事件，设置窗体上边距20，左边距50
            //this.Top = 20;
            //this.Left = 50;

            //单击的时候左边距加50，这样实现窗体不停往右边跑的效果
            this.Left += 50;


        }
    }
}
