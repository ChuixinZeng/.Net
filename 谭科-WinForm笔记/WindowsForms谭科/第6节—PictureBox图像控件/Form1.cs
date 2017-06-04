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

namespace 第6节_PictureBox图像控件
{
    public partial class Form1 : Form
    {
        string[] picNames = null;//用于保存图片路径
        int index = 0;//表示当前显示的图片的索引号

        public Form1()
        {
            InitializeComponent();
        }

        //窗体加载时，应该讲所有图片的路径获得并保存到一个数组中

        

        private void Form1_Load(object sender, EventArgs e)
        {
            picNames = Directory.GetFiles(@"E:\GitRepository\VSCodeForC-\谭科-WinForm笔记\WindowsForms谭科\Pics");
            this.index = 0;
            ShowPic(); //调用下面设置的方法，显示第一张图片

        }

        //显示图片的方法

        private void ShowPic()
        {

            //picBox.Load(picNames[this.index]);//用来显示index索引号对应的图片
            picBox.Image = Image.FromFile(picNames[this.index]);//第二种显示图片的方法

        }

        //第一张图片

        private void btnFirst_Click(object sender, EventArgs e)
        {
            this.index = 0;
            ShowPic();
        }

        //前一张
        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (this.index == 0)//如果已经是第一张，index为0,这是如果不使用IF的话，就会减到负一，下标越界，导致失败异常
            {
                this.index = picNames.Length - 1;//就跳到最后一张去

            }
            else {
                this.index--;
            }
            
            ShowPic();

        }

        //最后一张
        private void btnLast_Click(object sender, EventArgs e)
        {
            this.index = picNames.Length - 1;
            ShowPic();
        }

        //下一张

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (this.index == picNames.Length-1)//如果已经是最后一张
            {
                this.index = 0;//就跳到第一张去

            }
            else
            {
                this.index++;
            }
            ShowPic();
        }


       //tick事件跟timer控件的interval属性搭配使用，interval的单位是毫秒，默认是100毫秒,1000毫秒等于1秒
       //每隔interval毫秒，执行一次tick事件里面的代码

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();//产生一个随机对象
           this.index = r.Next(0, picNames.Length);//取0到图片数量
            ShowPic();

        }

        private void btnRand_Click(object sender, EventArgs e)
        {
            if (btnRand.Text == "启动随机")//点击启动随机按钮，开始随机显示图片，同时按钮变成关闭随机
            {
                timer1.Enabled = true;
                btnRand.Text = "关闭随机";
            }
            else
            {
                timer1.Enabled = false;
                btnRand.Text = "启动随机";
            }
        }
    }
}
