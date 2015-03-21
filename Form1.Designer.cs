namespace PhotoMananger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSeperator = new System.Windows.Forms.TextBox();
            this.chkDV = new System.Windows.Forms.CheckBox();
            this.txtDV = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkSubDir = new System.Windows.Forms.CheckBox();
            this.rdMove = new System.Windows.Forms.RadioButton();
            this.rdCopy = new System.Windows.Forms.RadioButton();
            this.rdSkip = new System.Windows.Forms.RadioButton();
            this.rdOverwrite = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBrowseSourceDir = new System.Windows.Forms.Button();
            this.btnBrowseTargetDir = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtLogs = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStatDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStatPhoto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStatDV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStatIgnore = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(79, 22);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(366, 21);
            this.txtSource.TabIndex = 0;
            this.txtSource.Text = "I:\\";
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(79, 49);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(366, 21);
            this.txtTarget.TabIndex = 1;
            this.txtTarget.Text = "J:\\Canon";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(520, 20);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(151, 50);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "开始执行";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "源目录";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "目标目录";
            // 
            // txtSeperator
            // 
            this.txtSeperator.Location = new System.Drawing.Point(53, 23);
            this.txtSeperator.Name = "txtSeperator";
            this.txtSeperator.Size = new System.Drawing.Size(52, 21);
            this.txtSeperator.TabIndex = 5;
            this.txtSeperator.Text = "_";
            // 
            // chkDV
            // 
            this.chkDV.AutoSize = true;
            this.chkDV.Checked = true;
            this.chkDV.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDV.Location = new System.Drawing.Point(11, 25);
            this.chkDV.Name = "chkDV";
            this.chkDV.Size = new System.Drawing.Size(60, 16);
            this.chkDV.TabIndex = 7;
            this.chkDV.Text = "子目录";
            this.chkDV.UseVisualStyleBackColor = true;
            // 
            // txtDV
            // 
            this.txtDV.Location = new System.Drawing.Point(73, 23);
            this.txtDV.Name = "txtDV";
            this.txtDV.Size = new System.Drawing.Size(54, 21);
            this.txtDV.TabIndex = 8;
            this.txtDV.Text = "DV";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDV);
            this.groupBox1.Controls.Add(this.chkDV);
            this.groupBox1.Location = new System.Drawing.Point(409, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 60);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "视频文件";
            // 
            // chkSubDir
            // 
            this.chkSubDir.AutoSize = true;
            this.chkSubDir.Checked = true;
            this.chkSubDir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSubDir.Location = new System.Drawing.Point(6, 25);
            this.chkSubDir.Name = "chkSubDir";
            this.chkSubDir.Size = new System.Drawing.Size(72, 16);
            this.chkSubDir.TabIndex = 12;
            this.chkSubDir.Text = "递归处理";
            this.chkSubDir.UseVisualStyleBackColor = true;
            // 
            // rdMove
            // 
            this.rdMove.AccessibleName = "a";
            this.rdMove.AutoSize = true;
            this.rdMove.Location = new System.Drawing.Point(10, 24);
            this.rdMove.Name = "rdMove";
            this.rdMove.Size = new System.Drawing.Size(47, 16);
            this.rdMove.TabIndex = 14;
            this.rdMove.Text = "移动";
            this.rdMove.UseVisualStyleBackColor = true;
            // 
            // rdCopy
            // 
            this.rdCopy.AccessibleName = "a";
            this.rdCopy.AutoSize = true;
            this.rdCopy.Checked = true;
            this.rdCopy.Location = new System.Drawing.Point(63, 24);
            this.rdCopy.Name = "rdCopy";
            this.rdCopy.Size = new System.Drawing.Size(47, 16);
            this.rdCopy.TabIndex = 15;
            this.rdCopy.TabStop = true;
            this.rdCopy.Text = "拷贝";
            this.rdCopy.UseVisualStyleBackColor = true;
            // 
            // rdSkip
            // 
            this.rdSkip.AccessibleName = "b";
            this.rdSkip.AutoSize = true;
            this.rdSkip.Checked = true;
            this.rdSkip.Location = new System.Drawing.Point(71, 24);
            this.rdSkip.Name = "rdSkip";
            this.rdSkip.Size = new System.Drawing.Size(47, 16);
            this.rdSkip.TabIndex = 19;
            this.rdSkip.TabStop = true;
            this.rdSkip.Text = "跳过";
            this.rdSkip.UseVisualStyleBackColor = true;
            // 
            // rdOverwrite
            // 
            this.rdOverwrite.AccessibleName = "b";
            this.rdOverwrite.AutoSize = true;
            this.rdOverwrite.Location = new System.Drawing.Point(12, 24);
            this.rdOverwrite.Name = "rdOverwrite";
            this.rdOverwrite.Size = new System.Drawing.Size(47, 16);
            this.rdOverwrite.TabIndex = 18;
            this.rdOverwrite.Text = "覆盖";
            this.rdOverwrite.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdCopy);
            this.groupBox2.Controls.Add(this.rdMove);
            this.groupBox2.Location = new System.Drawing.Point(10, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(125, 60);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "处理方式";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdOverwrite);
            this.groupBox3.Controls.Add(this.rdSkip);
            this.groupBox3.Location = new System.Drawing.Point(149, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(134, 60);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "文件存在时";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkSubDir);
            this.groupBox4.Location = new System.Drawing.Point(300, 82);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(93, 60);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "子目录";
            // 
            // btnBrowseSourceDir
            // 
            this.btnBrowseSourceDir.Location = new System.Drawing.Point(447, 20);
            this.btnBrowseSourceDir.Name = "btnBrowseSourceDir";
            this.btnBrowseSourceDir.Size = new System.Drawing.Size(53, 23);
            this.btnBrowseSourceDir.TabIndex = 24;
            this.btnBrowseSourceDir.Text = "浏览";
            this.btnBrowseSourceDir.UseVisualStyleBackColor = true;
            this.btnBrowseSourceDir.Click += new System.EventHandler(this.btnBrowseSourceDir_Click);
            // 
            // btnBrowseTargetDir
            // 
            this.btnBrowseTargetDir.Location = new System.Drawing.Point(447, 49);
            this.btnBrowseTargetDir.Name = "btnBrowseTargetDir";
            this.btnBrowseTargetDir.Size = new System.Drawing.Size(54, 23);
            this.btnBrowseTargetDir.TabIndex = 25;
            this.btnBrowseTargetDir.Text = "浏览";
            this.btnBrowseTargetDir.UseVisualStyleBackColor = true;
            this.btnBrowseTargetDir.Click += new System.EventHandler(this.btnBrowseTargetDir_Click);
            // 
            // txtLogs
            // 
            this.txtLogs.BackColor = System.Drawing.Color.Black;
            this.txtLogs.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogs.ForeColor = System.Drawing.Color.Lime;
            this.txtLogs.Location = new System.Drawing.Point(6, 19);
            this.txtLogs.Multiline = true;
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLogs.Size = new System.Drawing.Size(649, 241);
            this.txtLogs.TabIndex = 13;
            this.txtLogs.TextChanged += new System.EventHandler(this.txtLogs_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtLogs);
            this.groupBox5.Location = new System.Drawing.Point(10, 208);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(661, 269);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "日志";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.txtSeperator);
            this.groupBox6.Location = new System.Drawing.Point(560, 82);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(111, 60);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "日期目录命名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "分隔符";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.txtStatIgnore);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.txtStatDV);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.txtStatPhoto);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.txtStatDate);
            this.groupBox7.Location = new System.Drawing.Point(10, 148);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(661, 54);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "统计";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "日期归类";
            // 
            // txtStatDate
            // 
            this.txtStatDate.Location = new System.Drawing.Point(61, 25);
            this.txtStatDate.Name = "txtStatDate";
            this.txtStatDate.ReadOnly = true;
            this.txtStatDate.Size = new System.Drawing.Size(52, 21);
            this.txtStatDate.TabIndex = 5;
            this.txtStatDate.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "导出照片";
            // 
            // txtStatPhoto
            // 
            this.txtStatPhoto.Location = new System.Drawing.Point(198, 24);
            this.txtStatPhoto.Name = "txtStatPhoto";
            this.txtStatPhoto.ReadOnly = true;
            this.txtStatPhoto.Size = new System.Drawing.Size(52, 21);
            this.txtStatPhoto.TabIndex = 9;
            this.txtStatPhoto.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "导出视频";
            // 
            // txtStatDV
            // 
            this.txtStatDV.Location = new System.Drawing.Point(329, 24);
            this.txtStatDV.Name = "txtStatDV";
            this.txtStatDV.ReadOnly = true;
            this.txtStatDV.Size = new System.Drawing.Size(52, 21);
            this.txtStatDV.TabIndex = 11;
            this.txtStatDV.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(403, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "跳过";
            // 
            // txtStatIgnore
            // 
            this.txtStatIgnore.Location = new System.Drawing.Point(438, 25);
            this.txtStatIgnore.Name = "txtStatIgnore";
            this.txtStatIgnore.ReadOnly = true;
            this.txtStatIgnore.Size = new System.Drawing.Size(52, 21);
            this.txtStatIgnore.TabIndex = 13;
            this.txtStatIgnore.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 480);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnBrowseTargetDir);
            this.Controls.Add(this.btnBrowseSourceDir);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.txtSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "相片自动日期分类器 for Canon DIGITAL IXUS 860 IS ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSeperator;
        private System.Windows.Forms.CheckBox chkDV;
        private System.Windows.Forms.TextBox txtDV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkSubDir;
        private System.Windows.Forms.RadioButton rdMove;
        private System.Windows.Forms.RadioButton rdCopy;
        private System.Windows.Forms.RadioButton rdSkip;
        private System.Windows.Forms.RadioButton rdOverwrite;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnBrowseSourceDir;
        private System.Windows.Forms.Button btnBrowseTargetDir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.TextBox txtLogs;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStatDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStatIgnore;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStatDV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStatPhoto;
    }
}

