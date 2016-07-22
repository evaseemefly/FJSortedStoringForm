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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.删除测试ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制测试ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.删除测试ToolStripMenuItem,
            this.复制测试ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(772, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 菜单ToolStripMenuItem
            // 
            this.菜单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统设置ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
            this.菜单ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.菜单ToolStripMenuItem.Text = "菜单";
            // 
            // 系统设置ToolStripMenuItem
            // 
            this.系统设置ToolStripMenuItem.Name = "系统设置ToolStripMenuItem";
            this.系统设置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.系统设置ToolStripMenuItem.Text = "系统设置";
            this.系统设置ToolStripMenuItem.Click += new System.EventHandler(this.系统设置ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(68, 21);
            this.toolStripMenuItem1.Text = "添加测试";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 删除测试ToolStripMenuItem
            // 
            this.删除测试ToolStripMenuItem.Name = "删除测试ToolStripMenuItem";
            this.删除测试ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.删除测试ToolStripMenuItem.Text = "删除测试";
            this.删除测试ToolStripMenuItem.Click += new System.EventHandler(this.删除测试ToolStripMenuItem_Click);
            // 
            // 复制测试ToolStripMenuItem
            // 
            this.复制测试ToolStripMenuItem.Name = "复制测试ToolStripMenuItem";
            this.复制测试ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.复制测试ToolStripMenuItem.Text = "启动监控";
            this.复制测试ToolStripMenuItem.Click += new System.EventHandler(this.复制测试ToolStripMenuItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(772, 685);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(766, 642);
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
            this.groupBox2.Location = new System.Drawing.Point(3, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 319);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "消息";
            // 
            // txt_Msg
            // 
            this.txt_Msg.Location = new System.Drawing.Point(6, 11);
            this.txt_Msg.Multiline = true;
            this.txt_Msg.Name = "txt_Msg";
            this.txt_Msg.Size = new System.Drawing.Size(748, 302);
            this.txt_Msg.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 710);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "福建省台实时数据分类存储";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ListView lv_fileInfo;
        private System.Windows.Forms.ColumnHeader col_fileName;
        private System.Windows.Forms.ColumnHeader col_sourcePath;
        private System.Windows.Forms.ColumnHeader col_subTime;
        private System.Windows.Forms.ColumnHeader col_Type;
        private System.Windows.Forms.ToolStripMenuItem 删除测试ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制测试ToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_Msg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

