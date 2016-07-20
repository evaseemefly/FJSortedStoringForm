using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using IDAL;
using Model;


namespace DAL
{
    public class BaseFilterFileInfoDAL:IBaseFilterFileInfoDAL
    {
        /// <summary>
        /// 根据传入的正则表达式对传入的文件名称进行过滤
        /// </summary>
        /// <param name="name"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        public bool FilterByCondition(string name,string filter)
        {
            Regex regex = new Regex(filter);
            Match match = regex.Match(name);
            string value = match.Groups[1].Value;
            if (value != null)
            {
                return true;
            }
            return false;

        }

        /// <summary>
        /// 将指定文件复制到目标位置
        /// </summary>
        /// <param name="fileInfo"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool CopyToTargetPath(SourceFileInfo fileInfo, string path)
        {
            //将指定文件复制到目标位置
            return IOHelper.FileHelper.Copy(fileInfo.FileName, fileInfo.SourcePath, path);
        }

    }
}
