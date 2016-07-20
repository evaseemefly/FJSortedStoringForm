using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class DataTypeInfo
    {
        /// <summary>
        /// 类型代号
        /// </summary>
        public int TypeCode { get; set; }

        /// <summary>
        /// 类型名称
        /// </summary>
        public string TypeName { get; set; }

        /// <summary>
        /// 类型正则
        /// </summary>
        public string TypeRule { get; set; }
    }
}
