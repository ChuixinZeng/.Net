using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MyNotePad
{
    public partial class frmMain : Form
    {
        private string fileName = "";       //保存文件名
        private bool isSaved = false;       //标记是否保存

        public frmMain()
        {
            InitializeComponent();
        }

        //窗体加载事件
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = "无标题 - 记事本";
        }

        //打开
        private void tsmOpenFile_Click(object sender, EventArgs e)
        {
            ofdOpenFile.Filter = "文本文件(*.txt)|*.txt";       //文件筛选器
            if (ofdOpenFile.ShowDialog() == DialogResult.OK)
            {
                fileName = ofdOpenFile.FileName;        //保存文件名
                //创建读取文本文件的流
                using (StreamReader sr = new StreamReader(fileName, Encoding.Default))
                {
                    rtbContents.Text = sr.ReadToEnd();  //读取文件数据并显示
                    this.Text = string.Format("{0} - 记事本", Path.GetFileName(fileName));
                    this.isSaved = true;        //标记文件已经保存
                }
            }
        }

        //保存
        private void tsmSaveFile_Click(object sender, EventArgs e)
        {
            if (fileName == "")//未保存过的新文件
            {
                sfdSave.Filter = "文本文件(*.txt)|*.txt";       //文件筛选器
                if (sfdSave.ShowDialog() == DialogResult.OK)
                {
                    fileName = sfdSave.FileName;            //获取用户指定的文件名
                    this.Text = string.Format("{0} - 记事本", Path.GetFileName(fileName));
                }
            }
            WriteTextToFile();
        }

        //保存数据到文件
        private void WriteTextToFile()
        {
            //创建写入文本文件的流
            using (StreamWriter sw = new StreamWriter(fileName, false, Encoding.Default))
            {
                sw.WriteLine(rtbContents.Text);     //把内容写入流对象
                sw.Flush();             //把流中的数据刷新到文件
                this.isSaved = true;    //标记文件已经保存
            }
        }
    }
}
