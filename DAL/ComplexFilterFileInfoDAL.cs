using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using IDAL;
using IOHelper;

namespace DAL
{
    /// <summary>
    /// 将文件分别复制到 ***/data与***/data_name目录下
    /// </summary>
    public class ComplexFilterFileInfoDAL : BaseFilterFileInfoDAL, IFilterFileInfoDAL
    {
        public bool Copy(SourceFileInfo fileInfo, string[] targetPathes)
        {
            CopyToPath(fileInfo, targetPathes);
            CopyToSendPath(fileInfo,targetPathes);
            return true;
        }

        private bool CopyToPath(SourceFileInfo fileInfo,string[] targetPathes)
        {
            bool isOk = false;
            foreach (var item in targetPathes)
            {
                //将文件分别复制到 ***/data与***/data_name目录下
                base.CopyToTargetPath(fileInfo, item + "/data");
            }
            return isOk;
        }

        private void CopyToSendPath(SourceFileInfo fileInfo, string[] targetPathes)
        {
            foreach (var item in targetPathes)
            {
                //只拷贝文件名称，不复制文件内容
                FileHelper.CopyFileName(fileInfo.FileName, fileInfo.SourcePath, item);
            }
            
        }
    }
}
