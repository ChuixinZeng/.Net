namespace 第13节_ListView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lvwDataShow = new System.Windows.Forms.ListView();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnLargeIcon = new System.Windows.Forms.Button();
            this.btnSmallIcon = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.imgEmpHead = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtUid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lvwDataShow
            // 
            this.lvwDataShow.Location = new System.Drawing.Point(12, 12);
            this.lvwDataShow.MultiSelect = false;
            this.lvwDataShow.Name = "lvwDataShow";
            this.lvwDataShow.Size = new System.Drawing.Size(346, 198);
            this.lvwDataShow.TabIndex = 0;
            this.lvwDataShow.UseCompatibleStateImageBehavior = false;
            this.lvwDataShow.SelectedIndexChanged += new System.EventHandler(this.lvwDataShow_SelectedIndexChanged);
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(12, 227);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(75, 23);
            this.btnDetails.TabIndex = 1;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnLargeIcon
            // 
            this.btnLargeIcon.Location = new System.Drawing.Point(102, 227);
            this.btnLargeIcon.Name = "btnLargeIcon";
            this.btnLargeIcon.Size = new System.Drawing.Size(75, 23);
            this.btnLargeIcon.TabIndex = 1;
            this.btnLargeIcon.Text = "LargeIcon";
            this.btnLargeIcon.UseVisualStyleBackColor = true;
            this.btnLargeIcon.Click += new System.EventHandler(this.btnLargeIcon_Click);
            // 
            // btnSmallIcon
            // 
            this.btnSmallIcon.Location = new System.Drawing.Point(12, 266);
            this.btnSmallIcon.Name = "btnSmallIcon";
            this.btnSmallIcon.Size = new System.Drawing.Size(75, 23);
            this.btnSmallIcon.TabIndex = 1;
            this.btnSmallIcon.Text = "SmallIcon";
            this.btnSmallIcon.UseVisualStyleBackColor = true;
            this.btnSmallIcon.Click += new System.EventHandler(this.btnSmallIcon_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(102, 266);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // imgEmpHead
            // 
            this.imgEmpHead.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgEmpHead.ImageStream")));
            this.imgEmpHead.TransparentColor = System.Drawing.Color.Transparent;
            this.imgEmpHead.Images.SetKeyName(0, "男.jpg");
            this.imgEmpHead.Images.SetKeyName(1, "女.jpg");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "用户名：";
            // 
            // txtUid
            // 
            this.txtUid.Location = new System.Drawing.Point(258, 229);
            this.txtUid.Name = "txtUid";
            this.txtUid.Size = new System.Drawing.Size(100, 21);
            this.txtUid.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码：";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(258, 268);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(100, 21);
            this.txtPwd.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 305);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnSmallIcon);
            this.Controls.Add(this.btnLargeIcon);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.lvwDataShow);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListView";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwDataShow;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnLargeIcon;
        private System.Windows.Forms.Button btnSmallIcon;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.ImageList imgEmpHead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPwd;
    }
}

