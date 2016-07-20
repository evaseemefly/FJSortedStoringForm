using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace IOHelper
{
    /// <summary>
    /// 文件操作帮助类，实现对文件的复制，剪切及删除
    /// </summary>
    public static class FileHelper
    {
        /// <summary>
        /// 将指定路径下的文件复制到目标路径下
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="source"></param>
        /// <param name="target"></param>
        public static bool Copy(string filename,string source,string target)
        {
            //1 获取文件全路径
            var fullName_source= Path.Combine(source, filename);
            var fullName_target = Path.Combine(target, filename);
            //2 创建文件对象
            FileInfo file_temp = new FileInfo(fullName_source);
            //3 执行复制操作
            //3.1先判断指定路径是否存在
            if (Directory.Exists(target))
            {

            }
            //不存在则创建指定目录
            else
            {
                Directory.CreateDirectory(target);
            }
            //3.2 执行复制操作
            try
            {
                file_temp.CopyTo(fullName_target);
                return true;
            }
            catch (Exception e)
            {

                return false;
            }
            
        }
    }
}
