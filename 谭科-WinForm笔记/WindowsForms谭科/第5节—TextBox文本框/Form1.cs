using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第5节_TextBox文本框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //点击确定，进行登陆验证
        private void btnOK_Click(object sender, EventArgs e)
        {
            string userName = txtUid.Text.Trim();//获取用户名
            string userPassword = txtPID.Text;//获取密码

            MessageBox.Show(userName + "-----"+userPassword);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //单击显示Form2

            Form2 frm2 = new Form2();
            frm2.Show();
        }

        //sender代表触发事件的对象是什么，是click，还是keypress还是其他
        //e代表发生事件的具体信息，每个事件e代表的信息都不一样

        private void txtShow_KeyPress(object sender, KeyPressEventArgs e)
        {
            //键盘上面按一个键的时候，触发事件，弹出一个窗口，显示键盘触发的键的值，同时值返回到文本框
            //MessageBox.Show(e.KeyChar.ToString());
            //或者
            //e.keychar输出的是char字符，需要转换为string字符串
            //MessageBox.Show(Convert.ToString(e.KeyChar));


            ////判断输入文本框的信息是不是数字
            //if (char.IsDigit(e.KeyChar))
            //{

            //    MessageBox.Show("您敲的是数字");
            //}
            //else
            //{
            //    MessageBox.Show("您敲的不是数字");
            //}



            //判断输入文本框的信息是不是数字
            if (char.IsDigit(e.KeyChar))//如果输入的是数字
            {

                e.Handled = false; //表示不取消显示
            }
            else
            {
                e.Handled = true;//表示取消显示非数字的东西显示到文本框
            }
        }
    }
}
