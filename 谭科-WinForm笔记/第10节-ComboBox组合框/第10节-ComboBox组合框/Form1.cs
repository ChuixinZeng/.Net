using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace 第10节_ComboBox组合框
{
    public partial class Form1 : Form
    {
        Dictionary<string, List<string>> pcDic = new Dictionary<string, List<string>>(); //创建保存身份和城市列表的字典和泛型集合
        public Form1()
        {
            InitializeComponent();
        }

        //窗体加载时，填充“省”
        private void Form1_Load(object sender, EventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();   //创建文档对象
            xDoc.Load("pcData.xml");        //加载文档到内存
            XmlElement root = xDoc.DocumentElement;     //获取根节点
            //-------------------------------------------xml文档内容读取到字典里
            foreach (XmlNode rtNode in root.ChildNodes)
            {
                string key = rtNode.Attributes["省份"].InnerText; //把省份保存到字典的的string里面
                List<string> item = new List<string>(); //保存身份下面的城市到泛型集合里面
                foreach (XmlNode child in rtNode.ChildNodes) 
                {
                    item.Add(child.InnerText);
                }
                pcDic.Add(key, item);

                //用key填充“省”
                cmbProvince.Items.Add(key); //把身份添加到combobox身份组合框

                cmbProvince.SelectedIndex = 0; //设置默认的下拉框选中设置，默认选中身份里面的第一项
            }
        }

        //当选择某个省的时候，加载该省的所有市
        private void cmbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selPro = cmbProvince.SelectedItem.ToString();        //选中的省份名称
            cmbCity.DataSource = pcDic[selPro]; //把省份里面包含的item加载到城市下拉框

            //也可以先把省份对应的城市集合放到一个数组当中，然后由cmbcity下拉框调用

            //string[] datas = pcDic[selPro].ToArray();
            //cmbCity.Items.AddRange(datas);

            //也可以对该省所对应的集合做循环遍历，逐个添加到“市”

        }
    }
}
