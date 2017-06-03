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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            //文本框的值发生变化时，触发的事件
            ClsBox.tb.Text = txtInput.Text; //把form2中的文本框中的值赋给form1中的txtShow文本框，因为txtShow定义给tb对象了，tb对象来自于clsBox类中的form文本框对象

        }
    }
}
