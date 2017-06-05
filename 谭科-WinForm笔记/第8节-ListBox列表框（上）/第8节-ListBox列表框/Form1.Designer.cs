namespace 第8节_ListBox列表框
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstSource = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstChoice = new System.Windows.Forms.ListBox();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.btnAddChAll = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnDelChAll = new System.Windows.Forms.Button();
            this.btnDelAll = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstSource);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "菜单";
            // 
            // lstSource
            // 
            this.lstSource.FormattingEnabled = true;
            this.lstSource.ItemHeight = 12;
            this.lstSource.Location = new System.Drawing.Point(6, 20);
            this.lstSource.Name = "lstSource";
            this.lstSource.Size = new System.Drawing.Size(138, 220);
            this.lstSource.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstChoice);
            this.groupBox2.Location = new System.Drawing.Point(246, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 254);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "选择";
            // 
            // lstChoice
            // 
            this.lstChoice.FormattingEnabled = true;
            this.lstChoice.ItemHeight = 12;
            this.lstChoice.Location = new System.Drawing.Point(6, 20);
            this.lstChoice.Name = "lstChoice";
            this.lstChoice.Size = new System.Drawing.Size(138, 220);
            this.lstChoice.TabIndex = 0;
            // 
            // btnAddAll
            // 
            this.btnAddAll.Location = new System.Drawing.Point(183, 38);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(45, 23);
            this.btnAddAll.TabIndex = 2;
            this.btnAddAll.Text = ">>>";
            this.btnAddAll.UseVisualStyleBackColor = true;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // btnAddChAll
            // 
            this.btnAddChAll.Location = new System.Drawing.Point(183, 74);
            this.btnAddChAll.Name = "btnAddChAll";
            this.btnAddChAll.Size = new System.Drawing.Size(45, 23);
            this.btnAddChAll.TabIndex = 2;
            this.btnAddChAll.Text = ">>";
            this.btnAddChAll.UseVisualStyleBackColor = true;
            this.btnAddChAll.Click += new System.EventHandler(this.btnAddChAll_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(183, 110);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(45, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = ">";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(183, 146);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(45, 23);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "<";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnDelChAll
            // 
            this.btnDelChAll.Location = new System.Drawing.Point(183, 182);
            this.btnDelChAll.Name = "btnDelChAll";
            this.btnDelChAll.Size = new System.Drawing.Size(45, 23);
            this.btnDelChAll.TabIndex = 2;
            this.btnDelChAll.Text = "<<";
            this.btnDelChAll.UseVisualStyleBackColor = true;
            // 
            // btnDelAll
            // 
            this.btnDelAll.Location = new System.Drawing.Point(183, 218);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(45, 23);
            this.btnDelAll.TabIndex = 2;
            this.btnDelAll.Text = "<<<";
            this.btnDelAll.UseVisualStyleBackColor = true;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(12, 287);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 3;
            this.btnTest.Text = "测试";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 329);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnDelAll);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnDelChAll);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnAddChAll);
            this.Controls.Add(this.btnAddAll);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "点菜";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstChoice;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.Button btnAddChAll;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnDelChAll;
        private System.Windows.Forms.Button btnDelAll;
        private System.Windows.Forms.Button btnTest;
    }
}

