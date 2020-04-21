using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HtmlAgilityPack;
namespace AVDBDAL
{
    class JavBusGetMovieDAL:GetHtmlInterface
    {
        private string javBusUrl = "https://www.buscdn.cloud/";
        private HtmlWeb web = new HtmlWeb();
        private HtmlNode htmlNode;
        private string url;
        private string website;
        public JavBusGetMovieDAL() 
        {

        }
        public int GetMovieInfo(string sn) 
        {
            try 
            {
                url = javBusUrl + "search/" + sn + "&type=1";
                var htmltext = web.Load(url);
                if (htmltext.Text.IndexOf("沒有您要的結果！") != -1) 
                {
                    return -1;
                }
                htmlNode = HtmlNode.CreateNode(htmltext.Text);
                var urls = htmlNode.SelectNodes("//div[@id='waterfall']/div[@id='waterfall']/div");
                for (int i = 1; i < urls.Count + 1; i++)
                {
                    string number_get = htmlNode.SelectNodes("//div[@id='waterfall']/div[@id='waterfall']/div[" + i.ToString() + "]/a[@class='movie-box']/div[@class='photo-info']/span/date[1]/text()")[0].InnerText;
                    number_get = number_get.Replace("-", string.Empty).ToUpper();
                    if (number_get.Equals(sn))
                    {
                        url = htmlNode.SelectNodes("//div[@id='waterfall']/div[@id='waterfall']/div[" + i.ToString() + "]/a[@class='movie-box']/@href")[0].Attributes["href"].Value;
                        htmlNode = HtmlNode.CreateNode(web.Load(url).Text);
                        website = url;
                        return 0;
                    }
                }
                return -1;
            } 
            catch
            {
                return -1;
            }  
        }
        public string Getwebsite()
        {
            return website;
        }
        public string GetTitle() 
        {
            try 
            {
                var result = htmlNode.SelectNodes("//html/body/div[@class=\"container\"]/h3/text()")[0].InnerText.Trim();
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
                var result = htmlNode.SelectNodes("//span[contains(text(),\"製作商\")]/following-sibling::a/text()")[0].InnerText.Trim();
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
                var result = htmlNode.SelectNodes("//span[contains(text(),\"發行商\")]/following-sibling::a/text()")[0].InnerText.Trim();
                return result;
            }
            catch
            {
                return "";
            }
        }
        public string GetCover()// 获取封面链接
        {
            try
            {
                var result = htmlNode.SelectNodes("//a[@class=\"bigImage\"]")[0].Attributes["href"].Value;
                return result;
            }
            catch
            {
                return "";
            }
        }
        public string GetRelease()// 获取出版日期
        {
            try
            {
                var result = htmlNode.SelectNodes("//span[contains(text(),\"發行日期\")]/../text()")[0].InnerText.Trim();
                return result;
            }
            catch
            {
                return "";
            }
        }
        public string GetRuntime()// 获取分钟 //span[contains(text(),"長度")]/../text()
        {
            try
            {
                var result = htmlNode.SelectNodes("//span[contains(text(),\"長度\")]/../text()")[0].InnerText.Trim();
                return result;
            }
            catch
            {
                return "";
            }
        }
        public string GetDirector()// 获取导演
        {
            try
            {
                var result = htmlNode.SelectNodes("//span[contains(text(),\"導演\")]/following-sibling::a/text()")[0].InnerText.Trim();
                return result;
            }
            catch
            {
                return "";
            }
        }
        public string GetSeries()//获取系列
        {
            try
            {
                var result = htmlNode.SelectNodes("//span[contains(text(),\"系列\")]/following-sibling::a/text()")[0].InnerText.Trim();
                return result;
            }
            catch
            {
                return "";
            }
        }
        public List<string> GetTag() // 获取标签
        {
            List<string> listtags = new List<string>();
            try
            {
                var result = htmlNode.SelectNodes("//span[@class=\"genre\"]");
                foreach (var item in result)
                {
                    if (item.OuterHtml.Contains("onmouseout")) 
                    {
                        continue;
                    }
                    listtags.Add(item.InnerText.Trim());
                }
                return listtags;
            }
            catch
            {
                return listtags;
            }
        }
        public List<string> GetActor()//获取演员
        {
            List<string> listname = new List<string>();
            try
            {
                var result = htmlNode.SelectNodes("//div[@class=\"star-name\"]/a/text()");
                foreach(var item in result) 
                {
                    listname.Add(item.InnerText.Trim());
                }
                return listname;
            }
            catch
            {
                return listname;
            }
        }
        public Dictionary<string, string> GetActorPhoto()//获取演员
        {
            Dictionary<string, string> listPicUrl = new Dictionary<string, string>();
            try
            {
                List<string> urls = new List<string>();
                var result = htmlNode.SelectNodes("//div[@class=\"star-name\"]/a");
                foreach (var item in result)
                {
                    urls.Add(item.Attributes["href"].Value+","+ item.InnerText);
                }
                foreach(string url in urls) 
                {
                    string name = url.Split(',')[1];
                    var htmlPicNode = HtmlNode.CreateNode(web.Load(url.Split(',')[0]).Text);
                    var resultPicUrl = htmlPicNode.SelectNodes("//*[@id=\"waterfall\"]/div[1]/div/div[1]/img")[0].Attributes["src"].Value;
                    listPicUrl.Add(name,resultPicUrl);
                    //Console.ReadLine();
                    Thread.Sleep(2000);
                }
                return listPicUrl;
            }
            catch
            {
                return listPicUrl;
            }
        }
        public string GetNumber()//获取番号  //span[contains(text(),"識別碼")]/following-sibling::span/text()
        {
            try
            {
                var result = htmlNode.SelectNodes("//span[contains(text(),\"識別碼\")]/following-sibling::span/text()")[0].InnerText.Trim();
                return result;
            }
            catch
            {
                return "";
            }
        } 
    }
}
