using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Model;
using IBLL;
using IDAL;

namespace BLL
{
    public abstract class BaseFilterFileInfoBLL: IFilterFileInfoBLL
    {
        protected IFilterFileInfoDAL filterFileInfo;

        public abstract bool CopyBatch(SourceFileInfo file, CopyPathInfo copyPath);

        public bool DelFile(SourceFileInfo fileInfo)
        {
            return filterFileInfo.DelFile(fileInfo);
        }
    }
}
