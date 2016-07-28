using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EqualCompare
{
    public class DataType_Compare : IEqualityComparer<DataTypeInfo>
    {
        public bool Equals(DataTypeInfo x, DataTypeInfo y)
        {
            return x.DirName.Equals(y.DirName);
        }

        public int GetHashCode(DataTypeInfo obj)
        {
            if (obj == null)
                return 0;
            else
                return obj.DirName.ToString().GetHashCode();
        }
    }
}
