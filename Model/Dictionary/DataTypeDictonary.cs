using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Dictionary
{
    public class DataTypeDictonary
    {
        private static Dictionary<int, string> dataType;

        public Dictionary<int,string> GetTypeCode()
        {
            return dataType;
        }

        static DataTypeDictonary()
        {
            dataType = new Dictionary<int, string>();
        }

        public void Add(int key,string value)
        {
            if (dataType.ContainsKey(key))
            {
                return;
            }
            dataType.Add(key, value);
        }
    }
}
