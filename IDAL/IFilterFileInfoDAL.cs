using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace IDAL
{
    public interface IFilterFileInfoDAL:IBaseFilterFileInfoDAL
    {
        bool Copy(SourceFileInfo fileInfo, string[] targetPathes);
    }
}
