using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class CopyPathInfo
    {
        /// <summary>
        /// 存储路径（vast/station_data/***/real_time)
        /// </summary>
       public string[] Path_Simple { get; set; }

        /// <summary>
        /// 发送接口目录
        /// </summary>
        public string[] Path_Complex { get; set; }

        public string PrefixName { get; set; }

        public string PostfixName { get; set; }
    }
}
