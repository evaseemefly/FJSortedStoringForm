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
   public class SimpleFilterFileInfoBLL: BaseFilterFileInfoBLL
    {
        //private IFilterFileInfoDAL filterFileInfo;

        public override bool CopyBatch(SourceFileInfo file, CopyPathInfo copyPath, DataTypeInfo dateType)
        {
            //根据传入的文件进行批量复制
            //注意将文件复制到Path_Simple中时
            //存储路径为（vast/station_data/海洋站名字/real_time)
            filterFileInfo = new SimpleFilterFileInfoDAL();
            string[] pathes = new string[copyPath.Path_Simple.Length];
            for (int i = 0; i < copyPath.Path_Simple.Length; i++)
            {
                //将要转存的目录进行处理
                //遍历要转存的目录数组，并向其后加入类似/station_data/realtime这样的两极后缀，并生成最终的转发目录
                pathes[i] = Path.Combine(copyPath.Path_Simple[i], copyPath.PrefixName,dateType.TypeName,copyPath.PostfixName);
            }
            //注意此时复制完会进行删除原文件的操作
            return filterFileInfo.Copy(file, pathes);
        }
       
    }
}
