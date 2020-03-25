using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using avMovieManager.DAL;
using NPinyin;
namespace avMovieManager.BLL
{
    public sealed class MovieData
    {
        private static readonly Lazy<MovieData> lazy =
        new Lazy<MovieData>(() => new MovieData());

        public static MovieData Instance { get { return lazy.Value; } }
        private List<string> listactorname; //演员名字 用于排序
        private Dictionary<string, string> actorInfo;      //记录演员对应的目录
        private Dictionary<string, List<movieData>> actorToMovieInfo; //每个演员对应的目录
        private Dictionary<string, movieData> snToMovieInfo; //番号对应的目录
        private MovieData()
        {
            listactorname = new List<string>();
            actorInfo = new Dictionary<string, string>();
            actorToMovieInfo = new Dictionary<string, List<movieData>>();
            snToMovieInfo = new Dictionary<string, movieData>();
            InitActorInfo();
            InitMoveInfo();
        }

        public List<string> GetActorName() 
        {
            return listactorname;
        }
        public static String GetSpellCode(string str)
        {
            Encoding gb2312 = Encoding.GetEncoding("gb2312");
            string strA = Pinyin.ConvertEncoding(str, Encoding.UTF8, gb2312);
            //首字母
            string strB = Pinyin.GetInitials(strA, gb2312).Substring(0, 1);
            //拼音 
            //string strC = Pinyin.GetPinyin(str);
            return strB;
        }
        public Dictionary<string, string> GetAllActorPath() 
        {
            return actorInfo;
        }
        private void InitActorInfo()
        {
            if (Directory.Exists(LocalPathParam.VideoPreviewPath) == false)
            {
                return;
            }
            DirectoryInfo d = new DirectoryInfo(LocalPathParam.VideoPreviewPath);
            //实例化DirectoryInfo
            FileSystemInfo[] f = d.GetFileSystemInfos();
            foreach (FileSystemInfo fs in f)
            {
                if (fs is DirectoryInfo)
                {
                    if (actorInfo.ContainsKey(fs.Name))
                        continue;
                    actorInfo.Add(fs.Name, fs.FullName);
                    listactorname.Add(fs.Name);
                }
            }
            listactorname = listactorname.OrderBy(x => GetSpellCode(x)).ToList();
        }
        private void InitMoveInfo() 
        {
            foreach (KeyValuePair<string,string> kvp in actorInfo)
            {
                DirectoryInfo d = new DirectoryInfo(kvp.Value);
                FileSystemInfo[] f = d.GetFileSystemInfos();
                List<movieData> listMovie = new List<movieData>();
                foreach (FileSystemInfo fs in f)
                {
                    
                    if (fs is DirectoryInfo)
                    {
                        movieData moviedata = new movieData();
                        string name = fs.Name.Replace("-", string.Empty).ToUpper();
                        moviedata.moviesn = name;
                        moviedata.moviePath = fs.FullName;
                        DirectoryInfo dir = new DirectoryInfo(fs.FullName);
                        FileInfo[] fileInfo = dir.GetFiles("*.jpg");
                        for (int i = 0; i < fileInfo.Length; i++)
                        {
                            moviedata.movieJpgPath = fileInfo[i].FullName;
                        }
                        if (File.Exists(fs.FullName + @"\ch.uid"))
                        {
                            moviedata.movieischinese = true;
                        }
                        listMovie.Add(moviedata);
                        if (snToMovieInfo.ContainsKey(name))
                            continue;
                        snToMovieInfo.Add(name, moviedata);
                    }
                }
                if (actorToMovieInfo.ContainsKey(kvp.Key))
                    continue;
                actorToMovieInfo.Add(kvp.Key, listMovie);
            }
        }
    }
}
