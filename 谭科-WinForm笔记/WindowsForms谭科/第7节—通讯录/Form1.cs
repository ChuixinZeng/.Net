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
using System.Xml;

namespace 第7节_通讯录
{
    public partial class frmConBook : Form
    {
        public frmConBook()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSwim.Checked)

            {
                MessageBox.Show(chbSwim.Text);
            }

            else
            {
            //else里面什么都不写的话，代表什么都不干
            }
            

        }

        //窗体加载时，检查xml文件是否存在，如果不存在，则创建，这个xml文件是用来保存通讯录信息的

        private void frmConBook_Load(object sender, EventArgs e)
        {
            //这里面使用到了两个类，一个是IO，一个是xml类，需要在开头声明

            //创建的xml文件默认保存在debug文件夹里面：E:\GitRepository\VSCodeForC-\谭科-WinForm笔记\WindowsForms谭科\第7节—通讯录\bin\Debug

            if (File.Exists("Contact.xml")==false)
            {

                XmlDocument xDoc = new XmlDocument();
                XmlDeclaration xmlDec = xDoc.CreateXmlDeclaration("1.0", "utf-8", "yes");
                xDoc.AppendChild(xmlDec);

                xDoc.AppendChild(xDoc.CreateElement("Persons"));
                xDoc.Save("Contact.xml");


            }

            //性别默认选中为男
            rdbMale.Checked = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region 获取窗体的输入值

           

            string strPhone = txtPhone.Text.Trim();
            if(strPhone =="")
            {
                MessageBox.Show("请输入电话！");
                txtPhone.Focus();//控件获取焦点，如果用户没有输入电话，则焦点集中到输入电话文本框；
                return;
         
            }

            string strName = txtName.Text.Trim();
            if (strName == "")
            {
                MessageBox.Show("请输入姓名！");
                txtName.Focus();//控件获取焦点，如果用户没有输入姓名，则焦点集中到输入姓名文本框；
                return;

            }

            string strSex = rdbMale.Checked?"男":"女";
            string strMail = txtMail.Text.Trim() == "" ? "无" : txtMail.Text.Trim();


            string strInsterest = "";
            foreach (CheckBox cn in grbInterest.Controls)
            {
                if(cn.Checked)
                {
                    strInsterest = strInsterest + cn.Text + "-";
                }
            }
            //去掉foreach获取的字符串后面的横杠
            strInsterest = strInsterest.Substring(0, strInsterest.Length - 1);

            #endregion

            #region 写入XML文档

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("Contact.xml");  //加载文档
            XmlElement root = xDoc.DocumentElement;  //获取根节点

            //实际开发中，这里应该先判断输入的手机号是否存在，如果存在就是修改的工作，如果不存在就是添加，可以使用Xpath查询表达式

            //--------------------------------------新建节点
            XmlElement xePerson =  xDoc.CreateElement("Person");
            xePerson.SetAttribute("phone", strPhone);  //填写手机号,电话作为根节点

            XmlElement xeName = xDoc.CreateElement("Name");
            xeName.InnerText = strName;
            xePerson.AppendChild(xeName);

            XmlElement xeSex = xDoc.CreateElement("Sex");
            xeSex.InnerText = strSex;
            xePerson.AppendChild(xeSex);

            XmlElement xeEmail = xDoc.CreateElement("Email");
            xeEmail.InnerText = strMail;
            xePerson.AppendChild(xeEmail);

            XmlElement xeInsterest = xDoc.CreateElement("Insterest");
            xeInsterest.InnerText = strInsterest;
            xePerson.AppendChild(xeInsterest);
            //---------------------------------------------节点创建完毕

            root.AppendChild(xePerson);   //将新节点添加到根节点下面，电话作为根节点
            xDoc.Save("Contact.xml");   //保存
            MessageBox.Show("信息保存成功！");

            #endregion

        }
    }
}
