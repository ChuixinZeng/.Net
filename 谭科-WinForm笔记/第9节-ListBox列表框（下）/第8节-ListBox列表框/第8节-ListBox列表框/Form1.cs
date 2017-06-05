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

        //测试，点击测试按钮的时候，返回菜名和价格，这个地方单独测试一下，可以先把后面的form1_load中的内容先注释掉，再测试这个

        private void btnTest_Click(object sender, EventArgs e)
        {
            List<Dish> dsList = new List<Dish>();
            dsList.Add(new Dish() { Name = "鱼香茄子", Price = 12.5D });
            dsList.Add(new Dish() { Name = "麻婆豆腐", Price = 22.5D });
            dsList.Add(new Dish() { Name = "豆瓣饭", Price = 7.6D });
            lstSource.DataSource = dsList;
            lstSource.DisplayMember = "Name";//列表框上显示的内容
            lstSource.ValueMember = "Price";//列表框条目上的实际值
        }

        //加载窗体时，添加所有菜名
        private void Form1_Load(object sender, EventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("DishMenu.xml");
            XmlElement root = xDoc.DocumentElement;
            List<Dish> dsList = new List<Dish>(); //定义一个集合，用来存放菜的名称和价格
            foreach (XmlNode node in root.ChildNodes)
            {
                string dsName = node.Attributes["菜名"].InnerText;//获取菜名
                double dsPrice = Convert.ToDouble(node.Attributes["价格"].InnerText);//获取价格
                dsList.Add(new Dish() { Name = dsName, Price = dsPrice });//向集合中添加1个菜的对象，对象是基于Dish.cs类
            }

            //向列表框添加集合，在列表框显示上面添加好的集合
            lstSource.DataSource = dsList;
            lstSource.DisplayMember = "Name";//列表框上显示的内容
            lstSource.ValueMember = "Price";//列表框条目上的实际值
        }
        //列表框单击事件
        private void lstSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(lstSource.SelectedValue.ToString());
        }
        //点菜并计算消费
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstSource.SelectedIndex==-1)
            {
                MessageBox.Show("请选择您想吃的菜");
                return;
            }
            lstChoice.Items.Add(lstSource.SelectedItem);
            lstChoice.DisplayMember = "Name";//列表框上显示的内容
            lstChoice.ValueMember = "Price";//列表框条目上的实际值
            lblMoney.Text = (Convert.ToDouble(lblMoney.Text) + Convert.ToDouble(lstSource.SelectedValue)).ToString(); //价格累计，text文本框已经显示的金额加上后来的金额
        }
    }
}
