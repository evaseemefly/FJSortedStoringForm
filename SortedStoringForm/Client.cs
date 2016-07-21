using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLL;
using Model;
using IBLL;

namespace SortedStoringForm
{
    class Client
    {
        IFilterFileInfoBLL complexBLL;
        IFilterFileInfoBLL simpleBLL;
        private void CreateBLL()
        {
            // 1 创建两个操作类
            complexBLL = BLL.BLLFactory.CreateFilterFile(Model.Enum.CopyTypeEnum.Complex);
            simpleBLL = BLLFactory.CreateFilterFile(Model.Enum.CopyTypeEnum.Simple);
           
        }

        public Client()
        {
            CreateBLL();
        }

        public void DoCopy(SourceFileInfo fileInfo,CopyPathInfo copyInfo)
        {
            complexBLL.CopyBatch(fileInfo, copyInfo);
            simpleBLL.CopyBatch(fileInfo, copyInfo);
            simpleBLL.DelFile(fileInfo);
        }
    }
}
