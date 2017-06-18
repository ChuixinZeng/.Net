using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 第14节_MessageBox消息框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //显示设置：
        //关于按钮：枚举   MessageBoxButtons
        //关于图标：枚举   MessageBoxIcon
        //关于默认按钮：   MessageBoxDefaultButton
        private void btnOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show(null, "你喜欢我吗？", "提问", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);//Buttion2代表将messagebox的第二个按钮设置成默认按钮（默认按钮变成否）
        }
        //退出：返回值的演示
        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(null, "确定退出吗？", "退出", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            //DialogResult是MessageBox里面支持的参数
            if (dr == DialogResult.Yes)//用户点了“是”
            {
                this.Close();
            }
        }
    }
}
