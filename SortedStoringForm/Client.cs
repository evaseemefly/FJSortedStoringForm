using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLL;
using Model;
using IBLL;
using System.Text.RegularExpressions;

namespace SortedStoringForm
{
    class Client
    {
        IFilterFileInfoBLL complexBLL;
        IFilterFileInfoBLL simpleBLL;

        private void CreateBLL()
        {
            // 1 创建两个操作类
            complexBLL = BLL.BLLFactory.CreateFilterFile(Model.Enum.CopyTypeEnum.Complex);
            simpleBLL = BLLFactory.CreateFilterFile(Model.Enum.CopyTypeEnum.Simple);
           
        }

        private Form1.dg_AddInfo2Msg showmsg;

        public Client(Form1.dg_AddInfo2Msg show)
        {
            showmsg = show;
            CreateBLL();
        }

        public void DoCopy(SourceFileInfo fileInfo,CopyPathInfo copyInfo)
        {
            //进行批量复制
            complexBLL.CopyBatch(fileInfo, copyInfo);
            simpleBLL.CopyBatch(fileInfo, copyInfo);
            showmsg("批量复制成功");
            //批量复制后进行删除操作
            simpleBLL.DelFile(fileInfo);
            
        }

        public void CheckAndCopy(List<DataTypeInfo> list_datatypeInfo, SourceFileInfo fileInfo,CopyPathInfo copyInfo)
        {
            //遍历规则集合
            foreach (var item in list_datatypeInfo)
            {
                if(CheckFilterFileName(fileInfo.FileName, item.TypeRule))
                {
                    //将站代码赋给当前文件的种类编码
                    fileInfo.TypeCode = item.TypeCode;
                    DoCopy(fileInfo, copyInfo);
                }
            }
        }

        public static bool CheckFilterFileName(string name, string filterPattern)
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
    }
}
