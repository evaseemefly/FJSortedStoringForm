using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IBLL;
using Model;

namespace BLL
{
    public class BLLFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static IFilterFileInfoBLL CreateFilterFile(Model.Enum.CopyTypeEnum type)
        {
            switch(type)
            {
                case Model.Enum.CopyTypeEnum.Complex:
                    return new ComplexFilterFileInfoBLL();
                default :
                    return new SimpleFilterFileInfoBLL();
            }
        }
    }
}
