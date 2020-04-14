using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
namespace mongDbDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //DirectoryInfo dir = new DirectoryInfo(@"E:\movie\整理内容\");
            ////相对路径，和程序exe同目录下
            ////DirectoryInfo dir = new DirectoryInfo(@"test");
            //List<FileInfo> fileNames = new List<FileInfo>();
            //fileNames = GetAll(dir, fileNames);
            XmlDocument xml = new XmlDocument();
            xml.Load(@"E:\movie\整理内容\JULIA\PPPD-702-巨乳デリヘルを呼んだらやってきたのは俺をいつも叱りつけていた美人教師J！！-彼女のせいで退学になり、モテない金ない仕事ない人生で風俗にもたま-2018-10-18\PPPD-702-C.nfo");
            XmlNodeList nodelist = xml.SelectNodes("/movie/tag");
            string a = nodelist[0].InnerText;
        }
        public static List<FileInfo> GetAll(DirectoryInfo dir, List<FileInfo> FileList)//搜索文件夹中的文件 
        {
            FileInfo[] allFile = dir.GetFiles("*.nfo");
            foreach (FileInfo fi in allFile)
            {
                FileList.Add(fi);
            }
            DirectoryInfo[] allDir = dir.GetDirectories();
            foreach (DirectoryInfo d in allDir)
            {
                GetAll(d,FileList);
            }
            return FileList;
        }


    }
}
