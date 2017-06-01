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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        //单击窗体时，设置窗体的宽度/高度
        private void Form1_Click(object sender, EventArgs e)
        {
            //this.Width = 800;//宽度
            //this.Height = 500;//高度

            //也可以通过size属性进行设置
            //如果报错的话，把鼠标放到错误的字段上，按F1，可以直接打开官方的帮助
            //下面的size，鼠标放在上面，显示是一个重载，按F12可以看到相关信息

            this.Size = new Size(800, 600);


        }
    }
}
