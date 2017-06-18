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
            WriteTextToFile();
        }

        //保存数据到文件
        private void WriteTextToFile()
        {
            if (fileName == "")//未保存过的新文件
            {
                sfdSave.Filter = "文本文件(*.txt)|*.txt";       //文件筛选器
                if (sfdSave.ShowDialog() == DialogResult.OK)
                {
                    fileName = sfdSave.FileName;            //获取用户指定的文件名
                    this.Text = string.Format("{0} - 记事本", Path.GetFileName(fileName));
                }
                //创建写入文本文件的流
                using (StreamWriter sw = new StreamWriter(fileName, false, Encoding.Default))
                {
                    sw.WriteLine(rtbContents.Text);     //把内容写入流对象
                    sw.Flush();             //把流中的数据刷新到文件
                    this.isSaved = true;    //标记文件已经保存
                }
            }
        }

        //新建
        private void tsmNewFile_Click(object sender, EventArgs e)
        {
            if (this.isSaved == false)//文件未保存
            {
                DialogResult dr = MessageBox.Show(null, "文件尚未保存，是否保存？", "警告", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                if (dr == DialogResult.Cancel)//取消
                {
                    return;
                }
                if (dr==DialogResult.Yes)//是
                {
                    WriteTextToFile();
                }
            }
            //初始化窗体
            this.Text = "无标题 - 记事本";
            rtbContents.Clear();
            this.isSaved = false;
            this.fileName = "";
        }

        //文本发生变化的事件
        private void rtbContents_TextChanged(object sender, EventArgs e)
        {
            this.isSaved = false;
            tssCount.Text = rtbContents.TextLength.ToString();
        }

        //另存为
        private void tssmSaveNew_Click(object sender, EventArgs e)
        {
            fileName = "";
            WriteTextToFile();
        }

        //剪切
        private void tssmCut_Click(object sender, EventArgs e)
        {
            rtbContents.Cut();
        }

        //复制
        private void tssmCopy_Click(object sender, EventArgs e)
        {
            rtbContents.Copy();
        }

        //粘贴
        private void tssmPaste_Click(object sender, EventArgs e)
        {
            rtbContents.Paste();
        }

        //全选
        private void tssmChooseAll_Click(object sender, EventArgs e)
        {
            rtbContents.SelectAll();
        }
    }
}
