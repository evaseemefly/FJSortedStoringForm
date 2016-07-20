using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class SourceFileInfo
    {
        /// <summary>
        /// 文件名称
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// 原始路径
        /// </summary>
        public string SourcePath { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime SubTime { get; set; }

        /// <summary>
        /// 种类代号
        /// </summary>
        public int TypeCode { get; set; }
    
    }
}
