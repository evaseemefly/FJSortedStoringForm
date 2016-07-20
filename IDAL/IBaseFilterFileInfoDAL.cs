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
        bool FilterByCondition(string name, string filter);
    }
}
