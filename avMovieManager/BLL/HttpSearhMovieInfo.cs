using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using avMovieManager.DAL;
using HtmlAgilityPack;

namespace avMovieManager.BLL
{
    class HttpSearhMovieInfo
    {
        private bool isCH = false;
        private string snkey = "";
        private string moviePath = "";
        private string eext = "";
        //public event Putlog putlog;
        public delegate void OutLog(string log);
        public event OutLog OutLogEvent;
        public HttpSearhMovieInfo()
        {

        }
        public void Clear() 
        {
            isCH = false;
            snkey = "";
            moviePath = "";
            eext = "";
        }
        public int SearchLocalMovieDatas(string name, string path)
        {
            name = name.ToUpper();
            if (name.IndexOf("-C") >= 0)
            {
                isCH = true;
            }
            snkey = dealwithfilename(name);
            moviePath = path;
            if (snkey.Length > 0) 
            {
                return JavDbSearchStart();
            }
            return -1;

        }
        private string dealwithfilename(string key)
        {
            Regex regex = new Regex("\\[.*?\\]");
            string pContent = regex.Match(key).Value;
            if (pContent.Length > 0)
            {
                key = key.Replace(pContent, string.Empty);
            }
            regex = new System.Text.RegularExpressions.Regex("^[0-9]{3,4}");
            pContent = regex.Match(key).Value;
            if (pContent.Length > 0)
            {
                key = key.Replace(pContent, string.Empty);
            }
            key = key.Trim();
            key = key.Replace("_", string.Empty);
            key = key.Replace(".HD", string.Empty);
            key = key.Replace(".1080P", string.Empty);
            key = key.Replace("-C", string.Empty);
            key = key.Replace("H264", string.Empty);
            key = key.Replace("-", string.Empty);
            key = key.Replace("FHD", string.Empty);
            key = key.Replace("HHB", string.Empty);
            eext = key.Split('.')[1];
            key = key.Split('.')[0];
            key = key.ToUpper();
            return key;
        }
        public int JavDbSearchStart()
        {
             OutLogEvent?.Invoke("开始搜索番号，番号:"+ snkey);
            string url = SearchUrlLink.JavDbUrl + "/search?q=" + snkey + "&f=all";
            var web = new HtmlWeb();
            var doc = web.Load(url);
            Dictionary<string, string> hashMap = new Dictionary<string, string>();
            List<string> listsn = new List<string>();
            List<string> listurl = new List<string>();
            string html = doc.DocumentNode.SelectSingleNode("//div[@class='videos video-container']").OuterHtml;
            HtmlNode row = HtmlNode.CreateNode(html);
            HtmlNodeCollection titleNodes = row.SelectNodes("//div[@class='uid']");
            if (titleNodes != null)
            {
                foreach (var item in titleNodes)
                {
                    listsn.Add(item.InnerText.Replace("-", string.Empty).ToUpper());
                }
            }
            titleNodes = row.SelectNodes("//a");
            if (titleNodes != null)
            {
                foreach (var item in titleNodes)
                {
                    listurl.Add(item.Attributes["href"].Value);
                }
            }
            for (int i = 0; i < listsn.Count; i++)
            {
                if (hashMap.ContainsKey(listsn[i]))
                    continue;
                hashMap.Add(listsn[i], listurl[i]);
            }
            if (!hashMap.ContainsKey(snkey))
            {
                OutLogEvent?.Invoke("没有搜索到，返回");
                return -1;
            }
            url = SearchUrlLink.JavDbUrl + hashMap[snkey];
            web = null;
            OutLogEvent?.Invoke("找到影片，开始获取影片信息");
            return JavDbGetVideoDate(url);
        }

        private int JavDbGetVideoDate(string url)
        {
            /*
                图片的XPATH    /html/body/section/div/div[3]/div[1]/a/img
                演员的XPATH    /html/body/section/div/div[3]/div[2]/nav/div[8]/span[2]/a
                部分片子演员的  /html/body/section/div/div[3]/div[2]/nav/div[6]/span[2]/a
                /html/body/section/div/div[3]/div[2]/nav/div[9]/span[2]/a
                /html/body/section/div/div[3]/div[2]/nav/div[6]/span[2]/a
                /html/body/section/div/div[3]/div[2]/nav/div[10]/span[2]/a
            */
            OutLogEvent?.Invoke("获取影片url url = "+url);
            HtmlWeb web;
            HtmlDocument doc;
            bool isgetname = false;
            try
            {
                web = new HtmlWeb();
                doc = web.Load(url);
            }
            catch (Exception ex)
            {
                OutLogEvent?.Invoke("获取影片信息异常，异常原因:"+ex.ToString());
                return -1;
            }

            string name = "";
            string sn = "";
            string jpgurl = "";
            try
            {
                sn = doc.DocumentNode.SelectSingleNode(@"/html/body/section/div/div[3]/div[2]/nav/div[1]/span").InnerText;
                jpgurl = doc.DocumentNode.SelectSingleNode(@"/html/body/section/div/div[3]/div[1]/a/img").Attributes["src"].Value;
            }
            catch (Exception ex)
            {
                OutLogEvent?.Invoke("获取影片数据异常，异常原因:" + ex.ToString());
                return -1;
            }
            for (int i = 10; i > 5; i--)
            {
                if (isgetname) break;
                string str = string.Format("/html/body/section/div/div[3]/div[2]/nav/div[{0}]/span/a", i);
                try
                {
                    name = doc.DocumentNode.SelectSingleNode(str).InnerText;
                    isgetname = true;
                }
                catch (Exception)
                {
                    isgetname = false;
                }
            }
            if (name.IndexOf('(') > 0)
            {
                name = name.Substring(0, name.IndexOf('('));
            }
            OutLogEvent?.Invoke("获取影片信息成功");
            ActorMovieData movieData = new ActorMovieData();
            movieData.actorName = ActorNameHashForm.getActorName(name.Split(',')[0]);
            movieData.snFolderName = sn;
            movieData.sn = sn.Replace("-", string.Empty);
            movieData.jpgPath = sn + ".jpg";
            movieData.isChinese = isCH;
            if (System.IO.Directory.Exists(movieData.path) == false)
            {
                //创建pic文件夹
                System.IO.Directory.CreateDirectory(movieData.path);
                OutLogEvent?.Invoke("未找到文件夹，创建文件夹：" + movieData.path);
            }
            if(Downloadimg(jpgurl, movieData.jpgPath) < 0) 
            {
                return -1;
            }
            web = null;
            if(MoveMovieFile(moviePath, movieData.path + "\\" + movieData.snFolderName + "." + eext) == 0) 
            {
                FullMovieDatas fmd = FullMovieDatas.Instance;
                fmd.AddActorMovieData(movieData);
                if (movieData.isChinese) 
                {
                    string file = movieData.path + "\\" + "ch.uid";
                    File.Create(file);
                }
                return 0;
            }
            return -1;
        }
        private int MoveMovieFile(string sourceFileName, string destFileName) 
        {
            try 
            {
                File.Move(sourceFileName, destFileName);
                OutLogEvent?.Invoke("移动文件成功,目标文件: "+destFileName);
                return 0;
            }
            catch(Exception ex)
            {
                OutLogEvent?.Invoke("移动文件异常,异常原因:"+ex.ToString());
                return -1;
            }
        }
        private int Downloadimg(string url, string path)
        {
            try
            {
                WebRequest request = WebRequest.Create(url);
                WebResponse response = request.GetResponse();
                Stream reader = response.GetResponseStream();
                FileStream writer = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                byte[] buff = new byte[512];
                int c = 0; //实际读取的字节数
                while ((c = reader.Read(buff, 0, buff.Length)) > 0)
                {
                    writer.Write(buff, 0, c);
                }
                writer.Close();
                OutLogEvent?.Invoke("下载图片成功");
                return 0;
            }
            catch (Exception ex)
            {
                OutLogEvent?.Invoke("下载图片异常，异常原因"+ex.ToString());
                return -1;
            }
        }
    }
}
