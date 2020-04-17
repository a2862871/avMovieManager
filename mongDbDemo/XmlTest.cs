using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace TestDemo
{
    public class XmlTest
    {
        public static void startTest() 
        {
            XmlDocument xmldoc = new XmlDocument();
            //3.创建第一行描述信息，添加到xmldoc文档中
            XmlDeclaration xmldec = xmldoc.CreateXmlDeclaration("1.0", "utf-8", null);
            xmldoc.AppendChild(xmldec);
            //4.创建根节点，xml文档有且只能有一个根节点
            XmlElement xmlele = xmldoc.CreateElement("movie");
            xmldoc.AppendChild(xmlele);
            XmlElement name = xmldoc.CreateElement("title");
            name.InnerText = "PPPD-720";
            xmlele.AppendChild(name);
            XmlElement author = xmldoc.CreateElement("set");
            xmlele.AppendChild(author);
            XmlElement price = xmldoc.CreateElement("actor");
            XmlElement actorname = xmldoc.CreateElement("name");
            actorname.InnerText = "JULIA";
            XmlElement thumb = xmldoc.CreateElement("thumb");
            thumb.InnerText = "https://pics.javbus.com/actress/2de_a.jpg";
            price.AppendChild(actorname);
            price.AppendChild(thumb);
            xmlele.AppendChild(price);


            xmldoc.Save(@"E:\imgtest\test.nfo");
            Console.WriteLine("创建成功");
            Console.ReadKey();
        }
    }
}
