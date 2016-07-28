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
using System.Threading;

namespace SortedStoringForm
{
    public partial class Form1 : Form
    {
        private string typeConfig_Path=null;
        private string pathConfig_Path=null;
        private string watcherPath= null;
        private int watcherInterval;
        private string filter=null;
        private static string targetPath= @"E:\03协同开发\测试\转发目录";
        private List<DataTypeInfo> list_dataType;
        private Dictionary<int, string> dict_dataType;
        private CopyPathInfo copyPath_model;
        private delegate void dg_AddInfo2Lv(SourceFileInfo model);
        FileSystemWatcher[] fileWather;
        private delegate void dg_doCreated(object source, FileSystemEventArgs e);

        public delegate void dg_AddInfo2Msg(string msg);
        

        public Form1()
        {
            InitializeComponent();
        }

        private void 系统设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
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
            //注意由于是监控文件夹下面的子目录，所以此时的file.Name为***\\*****
            //		FullPath	"D:\\02编程\\2016年\\05测试目录\\监控目录\\DSB\\20160726\\2016072500008201.dsb.xml"	string

            var index = e.FullPath.LastIndexOf("\\");
           var names_split= e.FullPath.Split('\\');
            string fileName = names_split.Last();
            string sourcePath = e.FullPath.Substring(0, index);
            string pattern=filter;
            FileInfo file = new FileInfo(Path.Combine(sourcePath, fileName));           
            var date = file.CreationTime;
            //D:\02编程\2016年\05测试目录\监控目录\DSB\20160726
            var file_model = new SourceFileInfo()
            {
                FileName = fileName,
                SourcePath = sourcePath,
                SubTime = date
            };
            
            if (list_dataType.Count>0)
            {
                //1.2 对文件名进行筛查
                //FileHelper.Copy(fileName, watcherPath, targetPath);

                Client client = new Client(dg_addInfo2msg);
                if(client.CheckAndCopy(this.list_dataType, file_model, copyPath_model))
                {
                    AddInfo2Lv(file_model);
                }
                
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
        



        private void Form1_Load(object sender, EventArgs e)
        {
            this.tsBtn_Stop.Enabled = false;
            //读取配置文档至当前的配置集合中
            //LoadConfig();
            
        }

        //读取配置文件中DataType（站代码，名称，规则）集合
        private void LoadConfig()
        {
            #region 7月24日注释掉——读取配置文件
            //XmlHelper.ReadPath(@"E:\03协同开发\福建省分类存储\SortedStoringForm\SortedStoringForm\config.xml");
            //string config_path = System.Environment.CurrentDirectory;
            //list_dataType = XmlHelper.ReadXml2DataTypeInfo(Path.Combine(config_path, "config_type.xml"));
            //copyPath_model = XmlHelper.ReadXml2CopyPathInfo(Path.Combine(config_path, "config_path.xml"));
            #endregion

            //不使用以上方式，通过读取路径的方式
            
            list_dataType = XmlHelper.ReadXml2DataTypeInfo(this.typeConfig_Path);
            dict_dataType= DictionaryHelper.DataType2Dictionary(list_dataType);
            copyPath_model = XmlHelper.ReadXml2CopyPathInfo(this.pathConfig_Path);

        }

        private void 复制测试ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
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
            
            lv_item.SubItems.Add(dict_dataType[model.TypeCode]);
            lv_item.EnsureVisible();
            //this.lv_fileInfo.BeginUpdate();
            if (this.lv_fileInfo.Items.Count > 100)
            {
                this.lv_fileInfo.Items.Clear();
                this.txt_Msg.Clear();
            }
            this.lv_fileInfo.Items.Add(lv_item);
           // AddInfo2Msg("复制:" + model.FileName + "目录：[1]-" + targetPath);

        }

        private void AddInfo2Msg(string msg)
        {
            if (this.txt_Msg.Lines.Count() > 500)
            {
                this.txt_Msg.Clear();
            }
            this.txt_Msg.AppendText(msg + "\r\n");
        }
        

        private void 配置设置ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConfigForm configForm = new ConfigForm();
            configForm.type_Path = this.typeConfig_Path == null ? null : this.typeConfig_Path;
            configForm.path_Path = this.pathConfig_Path == null ? null : this.pathConfig_Path;
            configForm.ShowDialog();
            if (configForm.DialogResult == DialogResult.OK)
            {
                this.typeConfig_Path = configForm.type_Path;
                this.pathConfig_Path = configForm.path_Path;
                this.filter = configForm.watchFilter;
            }
        }

        private void 设置监控路径ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.fBd_watcherPath.ShowDialog() == DialogResult.OK)
            {
                this.watcherPath = fBd_watcherPath.SelectedPath;
            }
        }

        /// <summary>
        /// 判断几个配置文件及监控路径是否已经加载上
        /// </summary>
        /// <returns></returns>
        private bool CheckLoadConfig()
        {
            if (pathConfig_Path == null || typeConfig_Path == null)
            {
                MessageBox.Show("请选择配置路径", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            if (this.watcherPath == null)
            {
                MessageBox.Show("请选择监控路径", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            if (this.filter == null)
            {
                MessageBox.Show("设置过滤匹配条件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            return true;
        }

        private void GetWatherSonDir()
        {
            
            if (list_dataType.Count != 0)
            {
                var dif_datatype=list_dataType.Distinct(new Model.EqualCompare.DataType_Compare()).ToList();
                
                //int index = 0;
                if (dif_datatype.Count>0)
                {
                    fileWather = new FileSystemWatcher[dif_datatype.Count];
                    for (int i = 0; i < dif_datatype.Count; i++)
                    {
                       
                        fileWather[i] = new FileSystemWatcher();
                        //此处需要查询配置文件读取各文件所在的目录
                        fileWather[i].Path = Path.Combine(watcherPath, dif_datatype[i].DirName);
                        fileWather[i].Filter = filter;
                        fileWather[i].Created += new FileSystemEventHandler(fileSysWather_EventHandle);
                        //启用此监视器
                        fileWather[i].IncludeSubdirectories = true;
                        fileWather[i].EnableRaisingEvents = true;
                        //index++;
                    }
                    
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (!CheckLoadConfig())
            {
                return;
            }
            //加载配置信息
            this.LoadConfig();
            //进行复制指定文件的测试
            AddInfo2Msg("监控线程已启动");
            //创建不同文件夹的监控对象

            //1 创建监控对象
            //fileWather = new FileSystemWatcher();
            ////此处需要查询配置文件读取各文件所在的目录
            //fileWather.Path = watcherPath;
            //fileWather.Filter = filter;
            //fileWather.Created += new FileSystemEventHandler(fileSysWather_EventHandle);
            ////启用此监视器
            //fileWather.EnableRaisingEvents = true;
            GetWatherSonDir();
            this.tsBtn_Stop.Enabled = true;
            this.tsBtn_Start.Enabled = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            foreach (var item in this.fileWather)
            {
                item.EnableRaisingEvents = false;
            }
            //this.fileWather.EnableRaisingEvents = false;
            this.tsBtn_Start.Enabled = true;
            this.tsBtn_Stop.Enabled = false;
            AddInfo2Msg("监控线程已暂停");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.lv_fileInfo.Items.Clear();
            this.txt_Msg.Clear();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            if (!CheckLoadConfig())
            {
                return;
            }
            this.LoadConfig();
            Thread thread = new Thread(new ThreadStart(Run));
            thread.IsBackground = true;
            thread.Start();
        }
        private void Run()
        {
            CheckTargetPathExistFile(this.watcherPath);
        }

        private void CheckTargetPathExistFile(string watcherPath)
        {
            //获取监控目录下的全部文件名称
           string[] filesFullName= Directory.GetFiles(watcherPath);
            var filesNames = (from file in filesFullName
                    select Path.GetFileName(file)).ToArray();
            //var files= Directory.GetFileSystemEntries(watcherPath);
            //var temps = Directory.EnumerateFiles(watcherPath).ToArray();
            foreach (var item in filesNames)
            {
                FileSystemEventArgs fileEventArgs = new FileSystemEventArgs(WatcherChangeTypes.Created, watcherPath, item);
                fileSysWather_EventHandle(new object { }, fileEventArgs);
                //OnCreated();
            }
        }

        private void 退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
