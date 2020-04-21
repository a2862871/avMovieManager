using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using AVDBDAL;
namespace avMovieManager.BLL
{

    [XmlRoot("movie")]
    public class MovieCollection
    {
        [XmlElement("title")]
        public string title { get; set; }
        [XmlElement("set")]
        public string set { get; set; }
        [XmlElement("rating")]
        public string rating { get; set; }
        [XmlElement("studio")]
        public string studio { get; set; }
        [XmlElement("year")]
        public string year { get; set; }
        [XmlElement("outline")]
        public string outline { get; set; }
        [XmlElement("plot")]
        public string plot { get; set; }
        [XmlElement("runtime")]
        public string runtime { get; set; }
        [XmlElement("poster")]
        public string poster { get; set; }
        [XmlElement("thumb")]
        public string thumb { get; set; }
        [XmlElement("fanart")]
        public string fanart { get; set; }
        [XmlElement("actor", Type = typeof(ActorCollection))]
        public ActorCollection [] actor { get; set; }
        [XmlElement("maker")]
        public string maker { get; set; }
        [XmlElement("tag")]
        public string[] tag { get; set; }
        [XmlElement("genre")]
        public string[] genre { get; set; }
        [XmlElement("num")]
        public string num { get; set; }
        [XmlElement("premiered")]
        public string premiered { get; set; }
        [XmlElement("release")]
        public string release { get; set; }
        [XmlElement("cover")]
        public string cover { get; set; }
        [XmlElement("website")]
        public string website { get; set; }
    }
    public class ActorCollection 
    {
        [XmlElement("name")]
        public string name { get; set; }
        [XmlElement("thumb")]
        public string thumb { get; set; }
    }
    public struct DBMovieInfo
    {
        public string title; // 获取标题
        public string studio;  // 获取厂商
        public string publisher;  // 获取发行商
        public string coverUrl;  // 获取封面链接
        public string release;  // 获取出版日期
        public string runtime;  // 获取分钟
        public string director;  // 获取导演
        public string series;  //获取系列
        public List<string> tag;  // 获取标签
        public List<string> actor; //获取演员
        public Dictionary<string, string> actorPic; //获取演员照片
        public string number; //获取番号
        public string website; //获取番号

    }
    
    public class GetMovieInfo
    {
        private JavBusGetMovieDAL javbus = new JavBusGetMovieDAL();
        private JavDbGetMovieDAL javDb = new JavDbGetMovieDAL();
        private string VideoNumber = "";
        private string FilePath = "";
        private string ext = "";
        private bool isChinese = false;
        private string destFilePath = "";
        DBMovieInfo movieInfo = new DBMovieInfo();
        public int StartGetInfo(string fullName,string name) 
        {
            FilePath = fullName;
            CollationFilePath(name);
            int ret = javbus.GetMovieInfo(VideoNumber);
            if (ret == 0)
            {
                movieInfo.title = javbus.GetTitle();
                movieInfo.studio = javbus.GetStudio();
                movieInfo.publisher = javbus.GetPublisher();
                movieInfo.coverUrl = javbus.GetCover();
                movieInfo.release = javbus.GetRelease();
                movieInfo.runtime = javbus.GetRuntime();
                movieInfo.director = javbus.GetDirector();
                movieInfo.series = javbus.GetSeries();
                movieInfo.tag = javbus.GetTag();
                movieInfo.actor = javbus.GetActor();
                movieInfo.number = javbus.GetNumber();
                movieInfo.actorPic = javbus.GetActorPhoto();
                movieInfo.website = javbus.Getwebsite();
                WriteXmlInfo();
            }
            return ret;
        }

        private void CollationFilePath(string key) 
        {
            key = key.ToUpper();
            if (key.IndexOf("-C")!=-1) 
            {
                isChinese = true;
            }
            Regex regex = new Regex("\\[.*?\\]");
            string pContent = regex.Match(key).Value;
            if (pContent.Length > 0)
            {
                key = key.Replace(pContent, string.Empty);
            }
            regex = new Regex("^[0-9]{3,4}");
            pContent = regex.Match(key).Value;
            if (pContent.Length > 0)
            {
                key = key.Replace(pContent, string.Empty);
            }
            key = key.Trim();
            key = key.Replace("_", string.Empty);
            key = key.Replace(".HD", string.Empty);
            key = key.Replace(".1080p", string.Empty);
            key = key.Replace("-C", string.Empty);
            key = key.Replace("h264", string.Empty);
            key = key.Replace("-", string.Empty);
            key = key.Replace("FHD", string.Empty);
            key = key.Replace("HHB", string.Empty);
            ext = key.Split('.')[1];
            VideoNumber = key.Split('.')[0];
        }
        private void WriteXmlInfo() 
        {
            List<ActorCollection> actorCollections = new List<ActorCollection>();
            foreach(string actor in movieInfo.actor) 
            {
                ActorCollection act = new ActorCollection();
                act.name = actor;
                if (movieInfo.actorPic.ContainsKey(actor)) 
                {
                    act.thumb = movieInfo.actorPic[actor];
                }
                else 
                {
                    act.thumb = "未找到演员照片";
                }
                actorCollections.Add(act);
            }
            MovieCollection movieCollection = new MovieCollection
            {
                title = movieInfo.title,
                set = movieInfo.series,
                rating = "5",
                studio = movieInfo.studio,
                year = movieInfo.release.Substring(0, 4),
                outline = movieInfo.series + " " + movieInfo.title,
                plot = movieInfo.series + " " + movieInfo.title,
                runtime = movieInfo.runtime,
                poster = movieInfo.number + "-poster.jpg",
                thumb = movieInfo.number + "-thumb.jpg",
                fanart = movieInfo.number + "-fanart.jpg",
                actor = actorCollections.ToArray(),
                maker = movieInfo.publisher,
                tag = movieInfo.tag.ToArray(),
                genre = movieInfo.tag.ToArray(),
                num = movieInfo.number,
                premiered = movieInfo.release,
                release = movieInfo.release,
                cover = movieInfo.coverUrl,
                website = movieInfo.website,
            };

            XmlSerializer serializer = new XmlSerializer(typeof(MovieCollection));

            //将对象序列化输出到控制台
            FileStream stream = new FileStream(destFilePath + movieInfo.number+".nfo", FileMode.OpenOrCreate);
            serializer.Serialize(stream, movieCollection);
        }
    }
}
