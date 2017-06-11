using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace 第13节_ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //加载窗体，获取信息并填充ListView
        private void Form1_Load(object sender, EventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("Users.xml");
            XmlElement root = xDoc.DocumentElement;

            //绑定图片来源
            lvwDataShow.LargeImageList = imgEmpHead;//大图标模式使用的来源
            lvwDataShow.SmallImageList = imgEmpHead;//小图标模式使用的来源

            ////设置listview的显示格式

            //lvwDataShow.View = View.Details;//details代表以表格形式显示
            //lvwDataShow.GridLines = true; //设置表格中使用网格线来显示；
            //lvwDataShow.FullRowSelect = true; //允许整行选中



            //创建标题，自定义列，有点类似HTML中的自定义列的表头名称，名字是自己起的
            //lvwDataShow.Columns.Add("姓名", lvwDataShow.Width / 4, HorizontalAlignment.Left);

            XmlNode rtFirstNode = root.ChildNodes[0]; //第一个子节点

            //MessageBox.Show(rtFirstNode.Attributes.Count.ToString()); //验证node下面的属性是不是4个
            int iCols = rtFirstNode.Attributes.Count;

            //通过循环创建标题，左对齐

            for (int i = 0; i < iCols; i++)
            {
                lvwDataShow.Columns.Add(rtFirstNode.Attributes[i].Name, lvwDataShow.Width / iCols, HorizontalAlignment.Left);
            }

            //填充数据
            #region 添加1行数据
            //ListViewItem lvi = new ListViewItem();
            //lvi.Text = "谭科";
            //lvi.SubItems.Add("男");
            //lvi.SubItems.Add("888");
            //lvi.SubItems.Add("管理员");
            //lvwDataShow.Items.Add(lvi); 
            #endregion
            foreach (XmlNode rtNode in root.ChildNodes) //childnodes表示xml文件root根节点下面的全部子节点，rtnode表示每一个子节点，通过foreach获取
            {
                ListViewItem lvi = new ListViewItem();//创建新的一行，行对象创建好了，参考谭科的图片，ListViewItem代表表格中的一行，这个试验中一行表格有四个属性字段
                //循环多少次，就创建多少行
                lvi.Text = rtNode.Attributes[0].Value; //子节点第一个属性的值
                for (int i = 1; i < rtNode.Attributes.Count; i++) //从第1个属性开始循环添加到list，2-4个属性，填充子节点第2-4个属性的值
                {
                    lvi.SubItems.Add(rtNode.Attributes[i].Value);
                }

                //绑定图片的来源在第28-29行进行绑定
                //如果性别等于男就是0，否则就是1，下面用到了一个表达式
                //根据性别，设置图像的索引,subitems时listviewitem行里面的一个属性，1代表第二个属性，图标是针对每一行添加的，所以不要在循环里面做

                lvi.ImageIndex = lvi.SubItems[1].Text == "男" ? 0 : 1;
                lvwDataShow.Items.Add(lvi);
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            //设置ListView的默认显示格式，对应的是Detail按钮
            lvwDataShow.View = View.Details;     //视图模式
            //下面的两个属性只适合于Detals模式，因为其他几种模式不存在整行的说法
            lvwDataShow.GridLines = true;       //显示网格线
            lvwDataShow.FullRowSelect = true;   //允许整行选中
        }

        private void btnLargeIcon_Click(object sender, EventArgs e)
        {
            lvwDataShow.View = View.LargeIcon;     //视图模式
        }

        private void btnSmallIcon_Click(object sender, EventArgs e)
        {
            lvwDataShow.View = View.SmallIcon;     //视图模式
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            lvwDataShow.View = View.List;    //视图模式
        }
        //选中某一条的时候
        private void lvwDataShow_SelectedIndexChanged(object sender, EventArgs e)//选中的索引号发生变化的时候（每一行选中的时候都有一个索引号）
        {
            if (lvwDataShow.FocusedItem != null) //获取焦点的那一项，即选中的那一项，它的文本不为空的时候，不加这个IF，当选中第二行的时候会报错异常
                //因为选中一行之后，再去选中另外一行的时候，在这两个操作之间实际上会有一瞬间先设置属性为空，在吧第二行填充进来
            {
                txtUid.Text = lvwDataShow.FocusedItem.Text;
                txtPwd.Text = lvwDataShow.FocusedItem.SubItems[2].Text; //表示获取到的第3列的密码
            }
        }
    }
}
