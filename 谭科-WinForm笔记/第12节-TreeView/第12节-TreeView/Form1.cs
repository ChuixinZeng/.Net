using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace 第12节_TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //测试按钮
        private void btnTest_Click(object sender, EventArgs e)
        {
            TreeNode trTop = tvFiles.Nodes.Add("总公司");
            trTop.Nodes.Add("成都分公司");
            TreeNode trNodeBJ = trTop.Nodes.Add("北京分公司");
            trTop.Nodes.Add("上海分公司");
            trTop.Nodes.Add("杭州分公司");

            trNodeBJ.Nodes.Add("行政部");
            trNodeBJ.Nodes.Add("生产部");
            trNodeBJ.Nodes.Add("财务部");
        }

        //窗体加载事件
        private void Form1_Load(object sender, EventArgs e)
        {
            TreeNode trTop = tvFiles.Nodes.Add("所有文件");                  //顶级节点
            LoadFiles("所有文件", trTop);               //添加“所有文件”下的所有子节点
        }

        private void LoadFiles(string path, TreeNode node)
        {
            //将当前目录下的所有txt文件添加为节点
            string[] files = Directory.GetFiles(path, "*.txt", SearchOption.TopDirectoryOnly);
            foreach (string file in files)
            {
                TreeNode trNodeFile = node.Nodes.Add(Path.GetFileName(file));//file表示文件的全路径
                trNodeFile.Tag = file;//Tag没有具体含义，就是为了保存一些辅助数据的。
            }

            //将当前目录下的所有直接子文件夹添加为节点
            string[] dirs = Directory.GetDirectories(path);
            foreach (string dir in dirs)
            {
                TreeNode trNodeDir = node.Nodes.Add(Path.GetFileName(dir));//dir表示的是文件夹的全路径
                trNodeDir.Tag = 1;
                LoadFiles(dir, trNodeDir);
            }
        }
        //双击某个节点时，读取文件
        private void tvFiles_DoubleClick(object sender, EventArgs e)
        {
            string fileName = tvFiles.SelectedNode.Tag.ToString();
            if (fileName == "1")
            {
                return;
            }
            //为什么出现乱码？
            //C#编辑器默认的编码格式是UTF-8
            txtContent.Text = File.ReadAllText(fileName, Encoding.Default);
        }
    }
}
