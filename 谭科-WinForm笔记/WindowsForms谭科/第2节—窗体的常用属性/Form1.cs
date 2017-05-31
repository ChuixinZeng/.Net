using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第2节_窗体的常用属性
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //单击窗体时，设置窗体的宽度/高度
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 800;//宽度
            this.Height = 500;//高度
        }
    }
}
