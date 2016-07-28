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

        public void DoCopy(SourceFileInfo fileInfo,CopyPathInfo copyInfo,DataTypeInfo dateType)
        {
            //进行批量复制
            if(complexBLL.CopyBatch(fileInfo, copyInfo, dateType) && simpleBLL.CopyBatch(fileInfo, copyInfo, dateType))
            {
                showmsg("批量复制成功  复制文件为:" + fileInfo.FileName);
            }
            else
            {
                showmsg("批量复制失败 复制文件为:" + fileInfo.FileName);
            }
           
           
            //批量复制后进行删除操作（不要删除）
            //simpleBLL.DelFile(fileInfo);
            
        }

        public bool CheckAndCopy(List<DataTypeInfo> list_datatypeInfo, SourceFileInfo fileInfo,CopyPathInfo copyInfo)
        {
            bool isOk = false;
            //遍历规则集合
            foreach (var item in list_datatypeInfo)
            {
                if(CheckFilterFileName(fileInfo.FileName, item.TypeRule))
                {
                    //将站代码赋给当前文件的种类编码
                    fileInfo.TypeCode = item.TypeCode;
                    DoCopy(fileInfo, copyInfo,item);
                    isOk = true;
                    //只要在规则中找到匹配的规则就跳出循环
                    return isOk;
                }
            }
            return isOk;
        }

        public static bool CheckFilterFileName(string name, string filterPattern)
        {
            //string pattern = Regex.Escape(filterPattern);
            //Regex regex = new Regex(@filterPattern);

            Match match = Regex.Match(name, filterPattern);
            string value = match.Groups[0].Value;
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }
            return true;
        }
    }
}
