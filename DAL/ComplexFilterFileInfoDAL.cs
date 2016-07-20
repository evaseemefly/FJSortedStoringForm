using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using IDAL;

namespace DAL
{
    public class ComplexFilterFileInfoDAL : BaseFilterFileInfoDAL, IFilterFileInfoDAL
    {
        public bool Copy(SourceFileInfo fileInfo, string[] targetPathes)
        {
            bool isOk = false;
            foreach (var item in targetPathes)
            {
                //将文件分别复制到 ***/data与***/data_name目录下
                base.CopyToTargetPath(fileInfo, item + "/data");
            }

            return isOk;
        }
    }
}
