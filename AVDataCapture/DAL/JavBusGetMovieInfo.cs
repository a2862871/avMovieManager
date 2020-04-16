using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
namespace AVDataCapture.DAL
{
    class JavBusGetMovieInfo:GetHtmlInterface
    {
        private string javBusUrl = "https://www.buscdn.cloud/";
        private HtmlWeb web = new HtmlWeb();
        private HtmlNode htmlNode;
        private string url;
        public JavBusGetMovieInfo() 
        {

        }
        public int GetMovieInfo(string sn) 
        {
            try 
            {
                url = javBusUrl + "search/" + sn + "&type=1";
                htmlNode = HtmlNode.CreateNode(web.Load(url).Text);
                var urls = htmlNode.SelectNodes("//div[@id='waterfall']/div[@id='waterfall']/div");
                for (int i = 1; i < urls.Count + 1; i++)
                {
                    string number_get = htmlNode.SelectNodes("//div[@id='waterfall']/div[@id='waterfall']/div[" + i.ToString() + "]/a[@class='movie-box']/div[@class='photo-info']/span/date[1]/text()")[0].InnerText;
                    number_get = number_get.Replace("-", string.Empty).ToUpper();
                    if (number_get.Equals(sn))
                    {
                        url = htmlNode.SelectNodes("//div[@id='waterfall']/div[@id='waterfall']/div[" + i.ToString() + "]/a[@class='movie-box']/@href")[0].Attributes["href"].Value;
                        htmlNode = HtmlNode.CreateNode(web.Load(url).Text);
                        return 0;
                    }
                }
                return 0;
            } 
            catch (Exception ex) 
            {
                return -1;
            }  
        }
        public string GetTitle() 
        {
            try 
            {
                var result = htmlNode.SelectNodes("//html/body/div[@class=\"container\"]/h3/text()")[0].InnerText;
                return result;
            } 
            catch
            {
                return "";
            }
        }
        public string GetStudio()// 获取厂商
        {
            try
            {
                var result = htmlNode.SelectNodes("//span[contains(text(),\"製作商\")]/following-sibling::a/text()")[0].InnerText;
                return result;
            }
            catch
            {
                return "";
            }
        }
        public string GetPublisher()// 获取发行商
        {
            try
            {
                var result = htmlNode.SelectNodes("//span[contains(text(),\"發行商\")]/following-sibling::a/text()")[0].InnerText;
                return result;
            }
            catch
            {
                return "";
            }
        }
        public string GetYear()// 获取年份
        {
            return "";
        }
        public string GetCover()// 获取封面链接
        {
            return "";
        }
        public string GetRelease()// 获取出版日期
        {
            return "";
        }
        public string GetRuntime()// 获取分钟
        {
            return "";
        }
        public string GetDirector()// 获取导演
        {
            return "";
        }
        public string GetSeries()//获取系列
        {
            return "";
        }
        public string GetTag() // 获取标签
        {
            return "";
        }
        public string GetActor()//获取演员
        {
            return "";
        }
        public string GetNumber()//获取番号
        {
            return "";
        } 
    }
}
