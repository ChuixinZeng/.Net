using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace 第3节_设置窗体背景
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //单击窗体，随机更换背景图片
        private void Form1_Click(object sender, EventArgs e)
        {

            //this.BackgroundImage = Image.FromFile(@"E:\GitRepository\VSCodeForC-\谭科-WinForm笔记\WindowsForms谭科\Pics\timg.jpg");

            //获取指定路径下的全部图片的文件名（全路径）
            string[] picNames = Directory.GetFiles(@"E:\GitRepository\VSCodeForC-\谭科-WinForm笔记\WindowsForms谭科\Pics");

            //MessageBox.Show(picNames[0]); //检查是否能得到第一章图片的路径

            //设置读取某一张，利用数组
            //this.BackgroundImage = Image.FromFile(picNames[0]);

            //设置点击的时候，随机读取显示图片

            Random r = new Random();   //创建一个随机数对象
                                       //我只有四张图片，所以取值的时候从0到4，不能从0到3
                                       // int i = r.Next(0, 4);  这种写法容易产生越界

            //这种写法不会越界，有多少文件，获取多少
            int i = r.Next(0, picNames.Length);   
            this.BackgroundImage = Image.FromFile(picNames[i]); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
