using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IDAL;
using Model;
using DAL;
using System.IO;

namespace BLL
{
    public class ComplexFilterFileInfoBLL:BaseFilterFileInfoBLL
    {       

        public override bool CopyBatch(SourceFileInfo file, CopyPathInfo copyPath, DataTypeInfo dateType)
        {
            //根据传入的文件进行批量复制
            //将文件分别复制到 ***/data与***/data_name目录下            
            filterFileInfo = new ComplexFilterFileInfoDAL();
            //filterFileInfo.FilterNameByCondition(file.FileName,file.)
            //注意此时复制完会进行删除原文件的操作

            return filterFileInfo.Copy(file, copyPath.Path_Complex);
        }
       
    }
}
