using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Dictionary
{
    public class DataTypeDictonary
    {
        private static Dictionary<int, string> dataType;

        public static Dictionary<int,string> GetTypeCode()
        {
            return dataType;
        }

        static DataTypeDictonary()
        {
            dataType = new Dictionary<int, string>();
        }

        static void Add(int key,string value)
        {
            dataType.Add(key, value);
        }
    }
}
