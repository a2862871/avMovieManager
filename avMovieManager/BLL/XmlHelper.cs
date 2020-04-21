using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace avMovieManager.BLL
{
    public class XmlHelper
    {
        private static XmlDocument xml = new XmlDocument();

        public static void LoadXmlFile(string filepath) 
        {
            xml.Load(filepath);
        }

        public static List<string> GetXmlNodeInfos(string nodeinfo) 
        {
            List<string> nodeinfos = new List<string>();
            XmlNodeList nodelist = xml.SelectNodes(nodeinfo);
            for(int i = 0; i < nodelist.Count; i++) 
            {
                if (nodelist[i].InnerText.IndexOf("系列:") >=0|| nodelist[i].InnerText.IndexOf("製作:") >= 0 
                    || nodelist[i].InnerText.IndexOf("發行:") >= 0) 
                {
                    continue;
                }
                nodeinfos.Add(nodelist[i].InnerText);
            }
            return nodeinfos;
        }
        public static string GetXmlNodeInfo(string nodeinfo) 
        {
            XmlNodeList nodelist = xml.SelectNodes(nodeinfo);
            if (nodelist.Count > 0) 
            { 
                return nodelist[0].InnerText; 
            }
            return null;
        }

        public static bool AddXmlChildNode(string filepath,string node,string value) 
        {
            XmlDocument tempxml = new XmlDocument();
            tempxml.Load(filepath);
            XmlNode memberlist = tempxml.SelectSingleNode("movie");
            XmlElement childNode = tempxml.CreateElement(node);
            childNode.InnerText = value;
            memberlist.AppendChild(childNode);
            tempxml.Save(filepath);
            return true;
        }
    }
}
