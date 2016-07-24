using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SortedStoringForm
{
    public partial class ConfigForm : Form
    {
        public string type_Path;
        public string path_Path;
        public string watchFilter;

        public ConfigForm()
        {
            InitializeComponent();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            this.watchFilter = txt_watcherFilter.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string typePath = null;
            if (this.txt_type.Text != null)
            {
                type_Path = this.txt_type.Text;
            }
            
            if (this.oFd_configType.ShowDialog() == DialogResult.OK)
            {
                type_Path = oFd_configType.FileName;
            }
            
            this.txt_type.Text = type_Path;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string pathPath = null;
            
            if (this.txt_path.Text != null)
            {
                path_Path = this.txt_path.Text;
            }
            if (this.oFd_configPath.ShowDialog() == DialogResult.OK)
            {
                path_Path = oFd_configPath.FileName;
            }
            this.txt_path.Text = path_Path;
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            this.txt_watcherFilter.Text = "*.xml";
            this.txt_type.Text = this.type_Path;
            this.txt_path.Text = this.path_Path;
        }
    }
}
