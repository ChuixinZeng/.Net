namespace 第7节_通讯录
{
    partial class frmConBook
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.chbSwim = new System.Windows.Forms.CheckBox();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.grbInterest = new System.Windows.Forms.GroupBox();
            this.chbRead = new System.Windows.Forms.CheckBox();
            this.chbLanQiu = new System.Windows.Forms.CheckBox();
            this.chbDance = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grbInterest.SuspendLayout();
            this.SuspendLayout();
            // 
            // chbSwim
            // 
            this.chbSwim.AutoSize = true;
            this.chbSwim.Location = new System.Drawing.Point(16, 32);
            this.chbSwim.Name = "chbSwim";
            this.chbSwim.Size = new System.Drawing.Size(48, 16);
            this.chbSwim.TabIndex = 0;
            this.chbSwim.Text = "游泳";
            this.chbSwim.UseVisualStyleBackColor = true;
            this.chbSwim.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(104, 121);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(35, 16);
            this.rdbMale.TabIndex = 1;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "男";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(190, 121);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(35, 16);
            this.rdbFemale.TabIndex = 2;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "女";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grbInterest);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdbMale);
            this.groupBox1.Controls.Add(this.rdbFemale);
            this.groupBox1.Location = new System.Drawing.Point(13, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 281);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "详细信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Location = new System.Drawing.Point(13, 352);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(43, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(190, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "查询";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(43, 64);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "修改";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(190, 64);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "删除";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "电话：";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(95, 27);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(168, 21);
            this.txtPhone.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "姓名：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(95, 74);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(168, 21);
            this.txtName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "性别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "电子邮箱：";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(95, 149);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(168, 21);
            this.txtMail.TabIndex = 9;
            // 
            // grbInterest
            // 
            this.grbInterest.Controls.Add(this.chbDance);
            this.grbInterest.Controls.Add(this.chbLanQiu);
            this.grbInterest.Controls.Add(this.chbRead);
            this.grbInterest.Controls.Add(this.chbSwim);
            this.grbInterest.Location = new System.Drawing.Point(38, 185);
            this.grbInterest.Name = "grbInterest";
            this.grbInterest.Size = new System.Drawing.Size(257, 78);
            this.grbInterest.TabIndex = 10;
            this.grbInterest.TabStop = false;
            this.grbInterest.Text = "兴趣和特长";
            // 
            // chbRead
            // 
            this.chbRead.AutoSize = true;
            this.chbRead.Location = new System.Drawing.Point(66, 32);
            this.chbRead.Name = "chbRead";
            this.chbRead.Size = new System.Drawing.Size(48, 16);
            this.chbRead.TabIndex = 1;
            this.chbRead.Text = "看书";
            this.chbRead.UseVisualStyleBackColor = true;
            // 
            // chbLanQiu
            // 
            this.chbLanQiu.AutoSize = true;
            this.chbLanQiu.Location = new System.Drawing.Point(121, 32);
            this.chbLanQiu.Name = "chbLanQiu";
            this.chbLanQiu.Size = new System.Drawing.Size(48, 16);
            this.chbLanQiu.TabIndex = 2;
            this.chbLanQiu.Text = "篮球";
            this.chbLanQiu.UseVisualStyleBackColor = true;
            // 
            // chbDance
            // 
            this.chbDance.AutoSize = true;
            this.chbDance.Location = new System.Drawing.Point(176, 32);
            this.chbDance.Name = "chbDance";
            this.chbDance.Size = new System.Drawing.Size(48, 16);
            this.chbDance.TabIndex = 3;
            this.chbDance.Text = "跳舞";
            this.chbDance.UseVisualStyleBackColor = true;
            // 
            // frmConBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 464);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmConBook";
            this.Text = "通讯录";
            this.Load += new System.EventHandler(this.frmConBook_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.grbInterest.ResumeLayout(false);
            this.grbInterest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chbSwim;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grbInterest;
        private System.Windows.Forms.CheckBox chbDance;
        private System.Windows.Forms.CheckBox chbLanQiu;
        private System.Windows.Forms.CheckBox chbRead;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAdd;
    }
}

