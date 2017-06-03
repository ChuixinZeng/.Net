using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第4节_按钮
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            //通过Form2的按钮来打开Form3
            
            Form3 frm3 = new Form3();
            frm3.Show();
        }
    }
}
