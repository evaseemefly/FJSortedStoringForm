using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Dictionary;
using Model;

namespace Common
{
    public static class DictionaryHelper
    {
        /// <summary>
        /// 将DataTypeInfo集合转成字典
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static Dictionary<int,string> DataType2Dictionary(List<DataTypeInfo> list)
        {
            DataTypeDictonary dict = new DataTypeDictonary();
            list.ForEach(d => dict.Add(d.TypeCode, d.TypeName));
            return dict.GetTypeCode();
        }
    }
}
