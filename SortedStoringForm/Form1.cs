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
using Model;
using IOHelper;
using Common;

namespace SortedStoringForm
{
    public partial class Form1 : Form
    {
        private static string watcherPath= @"E:\03协同开发\测试\监控目录";
        private int watcherInterval;
        private static string filter="*.txt";
        private static string targetPath= @"E:\03协同开发\测试\转发目录";
        private List<DataTypeInfo> list_dataType;
        private CopyPathInfo copyPath_model;
        private delegate void dg_AddInfo2Lv(SourceFileInfo model);

        private delegate void dg_doCreated(object source, FileSystemEventArgs e);

        public delegate void dg_AddInfo2Msg(string msg);
        

        public Form1()
        {
            InitializeComponent();
        }

        private void 系统设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm();
            
        }

        private void fileSysWather_EventHandle(object sender,FileSystemEventArgs e)
        {
            if (this.lv_fileInfo.InvokeRequired)
            {
                //this.lv_fileInfo.Invoke(new dg_AddInfo2Lv(AddInfo2Lv),e);
                this.lv_fileInfo.Invoke(new dg_doCreated(OnCreated),sender, e);
            }
        }

        private void OnCreated(object source,FileSystemEventArgs e)
        {
            dg_AddInfo2Msg dg_addInfo2msg = new dg_AddInfo2Msg(AddInfo2Msg);
            //1 执行分类操作
            //1.1 获取文件名
            string fileName = e.Name;
            
            string pattern=filter;
            FileInfo file = new FileInfo(Path.Combine(watcherPath, fileName));            
            var date = file.CreationTime;
            var file_model = new SourceFileInfo()
            {
                FileName = e.Name,
                SourcePath = watcherPath,
                SubTime = date
            };
            var copy_model = new CopyPathInfo()
            {
                PrefixName = "",
                
            };
            if (list_dataType.Count>0)
            {
                //1.2 对文件名进行筛查
                FileHelper.Copy(fileName, watcherPath, targetPath);
                Client client = new Client(dg_addInfo2msg);
                client.CheckAndCopy(this.list_dataType, file_model, copyPath_model);
                AddInfo2Lv(file_model);
            }
            else
            {
                return;
            }
           
        }

        private void RemoveInfoFromListView()
        {
            //判断listView中的总行数
            if (this.lv_fileInfo.Items.Count > 0)
            {
                //执行删除操作
                this.lv_fileInfo.Items.RemoveAt(0);
            }
        }

        

        private static bool CheckFilterFileName(string name,string filterPattern)
        {
            Regex regex = new Regex(filterPattern);
            Match match = regex.Match(name);
            string value = match.Groups[0].Value;
            if (string.IsNullOrEmpty(value))
            {
                return true;
            }
            return false;
        }

        private int index = 0;
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            index++;
            SourceFileInfo temp = new SourceFileInfo()
            {
                FileName = "测试文件"+index,
                SourcePath = "C:",
                SubTime = DateTime.Now,
                TypeCode = 1
            };
            this.AddInfo2Lv(temp);
            //this.AddInfo2Lv(temp);
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //读取配置文档至当前的配置集合中
            LoadConfig();
            
        }

        //读取配置文件中DataType（站代码，名称，规则）集合
        private void LoadConfig()
        {
            //XmlHelper.ReadPath(@"E:\03协同开发\福建省分类存储\SortedStoringForm\SortedStoringForm\config.xml");
            list_dataType= XmlHelper.ReadXml2DataTypeInfo(@"E:\03协同开发\福建省分类存储\SortedStoringForm\SortedStoringForm\config_type.xml");
            copyPath_model = XmlHelper.ReadXml2CopyPathInfo(@"E:\03协同开发\福建省分类存储\SortedStoringForm\SortedStoringForm\config_path.xml");

        }


        private void 删除测试ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.RemoveInfoFromListView();
        }

        private void 复制测试ToolStripMenuItem_Click(object sender, EventArgs e)
        {           

            //进行复制指定文件的测试
            AddInfo2Msg("监控线程已启动");
            //1 创建监控对象
            FileSystemWatcher fileWather = new FileSystemWatcher();
            fileWather.Path = watcherPath;
            fileWather.Filter = filter;
            fileWather.Created += new FileSystemEventHandler(fileSysWather_EventHandle);
            //启用此监视器
            fileWather.EnableRaisingEvents = true;
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }


        //向datagridView中添加指定的对象
        private void AddInfo2Lv(SourceFileInfo model)
        {
            ListViewItem lv_item = new ListViewItem(model.FileName);

            lv_item.SubItems.Add(model.SourcePath);
            lv_item.SubItems.Add(model.SubTime.ToString());
            lv_item.SubItems.Add(model.TypeCode.ToString());
            lv_item.EnsureVisible();
            //this.lv_fileInfo.BeginUpdate();
            this.lv_fileInfo.Items.Add(lv_item);
            AddInfo2Msg("复制:" + model.FileName + "目录：[1]-" + targetPath);

        }

        private void AddInfo2Msg(string msg)
        {
            this.txt_Msg.AppendText(msg + "\r\n");
        }

        //private void 测试ToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    XmlHelper.ReadPath(@"E:\03协同开发\福建省分类存储\SortedStoringForm\SortedStoringForm\config.xml");
        //    XmlHelper.ReadXml2DataTypeInfo(); 
        //}

        
    }
}
