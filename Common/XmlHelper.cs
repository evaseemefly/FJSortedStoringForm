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
            
        }

        /// <summary>
        /// 从xml文档中读取数据并转换为DataType集合
        /// </summary>
        /// <returns></returns>
        public static List<DataTypeInfo> ReadXml2DataTypeInfo(string path)
        {
            readPath = path;
            //从指定路径读取xml文件
            XDocument doc = XDocument.Load(readPath);
            
            var t = from s in doc.Descendants("type")
                    select s;

            var typeInfos = from s in doc.Descendants("type")
                     select new DataTypeInfo
                     {
                          TypeCode =int.Parse(s.Element("code").Value) ,
                          TypeName = s.Element("name").Value,
                          TypeRule=s.Element("rule").Value
                     };
                                
            return typeInfos.ToList();

        }

        public static CopyPathInfo ReadXml2CopyPathInfo(string path)
        {
            readPath = path;
            //从指定路径读取xml文件
            XDocument doc = XDocument.Load(readPath);

            var copypath = (from s in doc.Descendants("setting")
                            //from p_simple in doc.Descendants("pathes_simple").Attributes("path")
                            //from p_complex in doc.Descendants("pathes_complex").Attributes("path")
                            select new CopyPathInfo
                            {
                                PrefixName = s.Element("prefixName").Value,
                                PostfixName = s.Element("postfixName").Value
                            }).FirstOrDefault();

            copypath.Path_Simple=(from p_simple in doc.Descendants("pathes_simple").Elements("path")
             select p_simple.Value).ToArray();

            copypath.Path_Complex = (from p_complex in doc.Descendants("pathes_complex").Elements("path")
                                    select p_complex.Value).ToArray();
            return copypath;
        }
    }
}
