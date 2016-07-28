using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using IDAL;

namespace DAL
{
    public class SimpleFilterFileInfoDAL:BaseFilterFileInfoDAL,IFilterFileInfoDAL
    {
        /// <summary>
        /// 对文件执行批量复制操作
        /// </summary>
        /// <param name="fileInfo"></param>
        /// <param name="targetPathes"></param>
        /// <returns></returns>
        public bool Copy(SourceFileInfo fileInfo,string[] targetPathes)
        {
            bool isOk = false;
            foreach (var item in targetPathes)
            {
                if (base.CopyToTargetPath(fileInfo, item))
                {
                    isOk = true;
                }
                else
                {
                    isOk = false;
                }     
            }
            //base.DelFile(fileInfo);
            return isOk;
        }

       
    }
}
