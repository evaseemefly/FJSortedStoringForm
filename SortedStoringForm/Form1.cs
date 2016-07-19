using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace SortedStoringForm
{
    public partial class Form1 : Form
    {
        private string watcherPath;
        private int watcherInterval;
        private string filter;

        public Form1()
        {
            InitializeComponent();
        }

        private void 系统设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm();
            //1 创建监控对象
            FileSystemWatcher fileWather = new FileSystemWatcher();
            fileWather.Path = watcherPath;
            fileWather.Filter = filter;
            fileWather.Created += new FileSystemEventHandler(OnCreated);
        }

        private static void OnCreated(object source,FileSystemEventArgs e)
        {
            //1 执行分类操作
            //1.1 获取文件名
            string fileName = e.Name;
            //1.2 对文件名进行筛查
            //2 执行赋值操作
            Console.WriteLine();
        }

        private static string CheckFilterFileName(string name,string filterPattern)
        {
            Regex regex = new Regex(filterPattern);
            Match match = regex.Match(name);
            string value = match.Groups[0].Value;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
