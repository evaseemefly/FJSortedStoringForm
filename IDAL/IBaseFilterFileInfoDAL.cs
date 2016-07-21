using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IDAL
{
    public interface IBaseFilterFileInfoDAL
    {
        /// <summary>
        /// 根据传入的正则表达式对传入的文件名称进行过滤
        /// </summary>
        /// <param name="name"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        bool FilterNameByCondition(string name, string filter);

        /// <summary>
        /// 根据文件对象执行删除操作
        /// </summary>
        /// <param name="fileInfo"></param>
        /// <returns></returns>
        bool DelFile(SourceFileInfo fileInfo);
    }
}
