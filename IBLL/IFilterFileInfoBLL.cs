using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;


namespace IBLL
{
    public interface IFilterFileInfoBLL
    {
        bool CopyBatch(SourceFileInfo file, CopyPathInfo copyPath);

        bool DelFile(SourceFileInfo fileInfo);
    }
}
