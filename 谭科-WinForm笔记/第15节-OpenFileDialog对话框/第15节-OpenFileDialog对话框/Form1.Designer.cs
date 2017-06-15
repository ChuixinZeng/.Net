namespace 第15节_OpenFileDialog对话框
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnOpenSeveral = new System.Windows.Forms.Button();
            this.opdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.btnPath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(371, 22);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(59, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "浏览";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(12, 24);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(339, 21);
            this.txtFileName.TabIndex = 1;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(12, 61);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(339, 368);
            this.txtContent.TabIndex = 1;
            // 
            // btnOpenSeveral
            // 
            this.btnOpenSeveral.Location = new System.Drawing.Point(371, 61);
            this.btnOpenSeveral.Name = "btnOpenSeveral";
            this.btnOpenSeveral.Size = new System.Drawing.Size(59, 23);
            this.btnOpenSeveral.TabIndex = 0;
            this.btnOpenSeveral.Text = "开多个";
            this.btnOpenSeveral.UseVisualStyleBackColor = true;
            this.btnOpenSeveral.Click += new System.EventHandler(this.btnOpenSeveral_Click);
            // 
            // opdOpenFile
            // 
            this.opdOpenFile.FileName = "openFileDialog1";
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(371, 106);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(59, 23);
            this.btnPath.TabIndex = 0;
            this.btnPath.Text = "路径";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 441);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.btnOpenSeveral);
            this.Controls.Add(this.btnOpen);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "打开对话框";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnOpenSeveral;
        private System.Windows.Forms.OpenFileDialog opdOpenFile;
        private System.Windows.Forms.Button btnPath;
    }
}

