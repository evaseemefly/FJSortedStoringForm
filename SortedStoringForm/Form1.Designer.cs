namespace SortedStoringForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lv_fileInfo = new System.Windows.Forms.ListView();
            this.col_fileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_sourcePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_subTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Msg = new System.Windows.Forms.TextBox();
            this.fBd_watcherPath = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.菜单ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.系统设置ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.配置设置ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.高级设置ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.设置监控路径ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtn_Start = new System.Windows.Forms.ToolStripButton();
            this.tsBtn_Stop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtn_Clear = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 53);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(772, 646);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.02094F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.97906F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(766, 635);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lv_fileInfo);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 280);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "转发列表";
            // 
            // lv_fileInfo
            // 
            this.lv_fileInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_fileName,
            this.col_sourcePath,
            this.col_subTime,
            this.col_Type});
            this.lv_fileInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_fileInfo.Location = new System.Drawing.Point(3, 17);
            this.lv_fileInfo.Name = "lv_fileInfo";
            this.lv_fileInfo.Size = new System.Drawing.Size(754, 260);
            this.lv_fileInfo.TabIndex = 2;
            this.lv_fileInfo.UseCompatibleStateImageBehavior = false;
            this.lv_fileInfo.View = System.Windows.Forms.View.Details;
            // 
            // col_fileName
            // 
            this.col_fileName.Text = "文件名称";
            this.col_fileName.Width = 200;
            // 
            // col_sourcePath
            // 
            this.col_sourcePath.Text = "文件路径";
            this.col_sourcePath.Width = 260;
            // 
            // col_subTime
            // 
            this.col_subTime.Text = "创建时间";
            this.col_subTime.Width = 200;
            // 
            // col_Type
            // 
            this.col_Type.Text = "类型";
            this.col_Type.Width = 100;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Msg);
            this.groupBox2.Location = new System.Drawing.Point(3, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 319);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "消息";
            // 
            // txt_Msg
            // 
            this.txt_Msg.Location = new System.Drawing.Point(6, 20);
            this.txt_Msg.Multiline = true;
            this.txt_Msg.Name = "txt_Msg";
            this.txt_Msg.Size = new System.Drawing.Size(748, 293);
            this.txt_Msg.TabIndex = 4;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单ToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(772, 25);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // 菜单ToolStripMenuItem1
            // 
            this.菜单ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统设置ToolStripMenuItem1,
            this.退出ToolStripMenuItem1});
            this.菜单ToolStripMenuItem1.Name = "菜单ToolStripMenuItem1";
            this.菜单ToolStripMenuItem1.Size = new System.Drawing.Size(44, 21);
            this.菜单ToolStripMenuItem1.Text = "菜单";
            // 
            // 系统设置ToolStripMenuItem1
            // 
            this.系统设置ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.配置设置ToolStripMenuItem1,
            this.高级设置ToolStripMenuItem1,
            this.设置监控路径ToolStripMenuItem1});
            this.系统设置ToolStripMenuItem1.Name = "系统设置ToolStripMenuItem1";
            this.系统设置ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.系统设置ToolStripMenuItem1.Text = "系统设置";
            // 
            // 配置设置ToolStripMenuItem1
            // 
            this.配置设置ToolStripMenuItem1.Name = "配置设置ToolStripMenuItem1";
            this.配置设置ToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.配置设置ToolStripMenuItem1.Text = "配置设置";
            this.配置设置ToolStripMenuItem1.Click += new System.EventHandler(this.配置设置ToolStripMenuItem1_Click);
            // 
            // 高级设置ToolStripMenuItem1
            // 
            this.高级设置ToolStripMenuItem1.Enabled = false;
            this.高级设置ToolStripMenuItem1.Name = "高级设置ToolStripMenuItem1";
            this.高级设置ToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.高级设置ToolStripMenuItem1.Text = "高级设置";
            // 
            // 设置监控路径ToolStripMenuItem1
            // 
            this.设置监控路径ToolStripMenuItem1.Name = "设置监控路径ToolStripMenuItem1";
            this.设置监控路径ToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.设置监控路径ToolStripMenuItem1.Text = "设置监控路径";
            this.设置监控路径ToolStripMenuItem1.Click += new System.EventHandler(this.设置监控路径ToolStripMenuItem1_Click);
            // 
            // 退出ToolStripMenuItem1
            // 
            this.退出ToolStripMenuItem1.Name = "退出ToolStripMenuItem1";
            this.退出ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.退出ToolStripMenuItem1.Text = "退出";
            this.退出ToolStripMenuItem1.Click += new System.EventHandler(this.退出ToolStripMenuItem1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtn_Start,
            this.tsBtn_Stop,
            this.toolStripSeparator1,
            this.tsBtn_Clear,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(772, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtn_Start
            // 
            this.tsBtn_Start.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_Start.Image")));
            this.tsBtn_Start.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_Start.Name = "tsBtn_Start";
            this.tsBtn_Start.Size = new System.Drawing.Size(76, 22);
            this.tsBtn_Start.Text = "启动监控";
            this.tsBtn_Start.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsBtn_Stop
            // 
            this.tsBtn_Stop.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_Stop.Image")));
            this.tsBtn_Stop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_Stop.Name = "tsBtn_Stop";
            this.tsBtn_Stop.Size = new System.Drawing.Size(76, 22);
            this.tsBtn_Stop.Text = "停止监控";
            this.tsBtn_Stop.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtn_Clear
            // 
            this.tsBtn_Clear.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_Clear.Image")));
            this.tsBtn_Clear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_Clear.Name = "tsBtn_Clear";
            this.tsBtn_Clear.Size = new System.Drawing.Size(76, 22);
            this.tsBtn_Clear.Text = "清空列表";
            this.tsBtn_Clear.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(100, 22);
            this.toolStripButton1.Text = "遍历监控目录";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 679);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "福建省台实时数据分类存储";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListView lv_fileInfo;
        private System.Windows.Forms.ColumnHeader col_fileName;
        private System.Windows.Forms.ColumnHeader col_sourcePath;
        private System.Windows.Forms.ColumnHeader col_subTime;
        private System.Windows.Forms.ColumnHeader col_Type;
        private System.Windows.Forms.TextBox txt_Msg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FolderBrowserDialog fBd_watcherPath;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 菜单ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 系统设置ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 配置设置ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 高级设置ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 设置监控路径ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtn_Start;
        private System.Windows.Forms.ToolStripButton tsBtn_Stop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtn_Clear;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

