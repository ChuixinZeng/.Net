using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace 第15节_OpenFileDialog对话框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //浏览
        private void btnOpen_Click(object sender, EventArgs e)
        {
            //设置标题
            opdOpenFile.Title = "谭科要打开文件了";

            //设置文件筛选器，|前面是定义下拉列表的，|后面才是筛选的文件后缀
            //opdOpenFile.Filter = "所有文件(*.*)|*.*|文本文件(*.txt)|*.txt|Excel文件(*.xls;*.xlsx)|*.xls;*.xls*|媒体文件(*.mp4)|*.mp4";
            opdOpenFile.Filter = "文本文件(*.txt)|*.txt";

            //显示“打开”对话框
            DialogResult dr = opdOpenFile.ShowDialog();
            if (dr == DialogResult.OK)//用户选择了文件，并点击“打开”按钮
            {
                //获取用户选择的文件路径
                txtFileName.Text = opdOpenFile.FileName; //单个文件用FileName，多个文件用FileNames
            }

            //读取文件内容并显示到文本框
            txtContent.Text = File.ReadAllText(txtFileName.Text,Encoding.Default);
        }

        //允许用户多选文件
        private void btnOpenSeveral_Click(object sender, EventArgs e)
        {
            opdOpenFile.Filter = "文本文件(*.txt)|*.txt";
            opdOpenFile.Multiselect = true;//允许用户选择多个文件

            //显示“打开”对话框
            DialogResult dr = opdOpenFile.ShowDialog();
            if (dr == DialogResult.OK)//用户选择了文件，并点击“打开”按钮
            {
                //获取用户选择的文件路径
                string[] files = opdOpenFile.FileNames;
            }
        }

        //相对路径和绝对路径
        private void btnPath_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("测试.xlsx");//相对路径：有时候会被其他对话框更改
            //这种使用相对路径的做法是不准确的。

            //建议的做法：获取程序（exe）所在路径，依赖前面导入的.Reflection命名空间
            MessageBox.Show(Assembly.GetExecutingAssembly().Location);//当前exe程序的全路径
        }
    }
}
