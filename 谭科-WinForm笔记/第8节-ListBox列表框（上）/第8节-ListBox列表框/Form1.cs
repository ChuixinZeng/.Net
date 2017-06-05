using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace 第8节_ListBox列表框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //测试
        private void btnTest_Click(object sender, EventArgs e)
        {
            #region 添加条目
            ////添加1个条目
            //lstSource.Items.Add("成都");

            ////添加1个数组
            //lstSource.Items.AddRange(new string[] { "德阳", "北京", "重庆" });

            ////插入
            //lstSource.Items.Insert(2, "晋阳");
            #endregion

            #region 删除条目
            //根据内容删除指定条目
            //lstSource.Items.Remove("它似蜜");

            //根据索引删除指定条目
            //lstSource.Items.RemoveAt(3);

            //清空
            //lstSource.Items.Clear();
            #endregion

            //选中条目，必须选中条目，否则点击测试的时候，程序会异常
            //MessageBox.Show(lstSource.SelectedItem.ToString());

            //选中条目的索引：如果没有选中任何条目，返回值为 -1
            //MessageBox.Show(lstSource.SelectedIndex.ToString());

        }
        //加载窗体时，添加所有菜名
        private void Form1_Load(object sender, EventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("DishMenu.xml");
            XmlElement root = xDoc.DocumentElement;
            foreach (XmlNode node in root.ChildNodes)
            {
                lstSource.Items.Add(node.Attributes["菜名"].InnerText);
            }

            //设置多选
            lstSource.SelectionMode = SelectionMode.MultiExtended; //也可以在图形界面设置，设置selectionmode属性
        }
        //选菜
        private void btnAddAll_Click(object sender, EventArgs e)
        {
            //遍历添加每一个条目
            //foreach (string item in lstSource.Items)
            //{
            //    lstChoice.Items.Add(item);
            //}
            //lstSource.Items.Clear();

            //直接添加集合
            lstChoice.Items.AddRange(lstSource.Items);
            lstSource.Items.Clear();
        }
        //选择多项，只添加选中的多个对象
        private void btnAddChAll_Click(object sender, EventArgs e)
        {
            //将左边选中的多项遍历拿到右边
            foreach (var item in lstSource.SelectedItems)  //selecteditems代表选择的是多项，从选中的多项里面进行循环遍历
            {
                lstChoice.Items.Add(item);
                //lstSource.Items.Remove(item);//不行
            }

            //将已经拿到右边的进行遍历，然后从左边删除相同的项目
            foreach (var item in lstChoice.Items)
            {
                lstSource.Items.Remove(item);
            }
        }
    }
}
