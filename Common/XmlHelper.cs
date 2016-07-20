using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Model;

namespace Common
{
    public static class XmlHelper
    {
        /// <summary>
        /// 读取路径
        /// </summary>
        private static string readPath;

        static XmlHelper()
        {
            
        }

        public static void ReadPath(string path)
        {
            readPath = path;
        }

        /// <summary>
        /// 从xml文档中读取数据并转换为DataType集合
        /// </summary>
        /// <returns></returns>
        public static List<DataTypeInfo> ReadXml2DataTypeInfo()
        {
            //从指定路径读取xml文件
            XDocument doc = XDocument.Load(readPath);
            //var t = from s in doc.Descendants()
            //        select new
            //        {
            //            code=s.Element("name").Value,
            //            rule=s.Element("rule").Value
            //        };
            //可以取出type的对象
            var t = from s in doc.Descendants("type")
                    select s;

            var typeInfos = from s in doc.Descendants("type")
                     select new DataTypeInfo
                     {
                          TypeCode =int.Parse(s.Element("code").Value) ,
                          TypeName = s.Element("name").Value,
                          TypeRule=s.Element("rule").Value
                     };
            //var t = from s in doc.Descendants("type").Attributes("name")
            //        select s;
            //foreach (var item in t2)
            //{
            //    Console.WriteLine(item);
            //}
                    
            return typeInfos.ToList();

        }
    }
}
