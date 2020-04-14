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
                nodeinfos.Add(nodelist[i].InnerText);
            }
            return nodeinfos;
        }
        public static string GetXmlNodeInfo(string nodeinfo) 
        {
            XmlNodeList nodelist = xml.SelectNodes(nodeinfo);
            return nodelist[0].InnerText;
        }
    }
}
