using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using avMovieManager.DAL;
namespace avMovieManager.BLL
{
    public sealed class MovieDataBLL
    {
        private static readonly Lazy<MovieDataBLL> lazy =
        new Lazy<MovieDataBLL>(() => new MovieDataBLL());
        public static MovieDataBLL Instance { get { return lazy.Value; } }

        private static MovieDataDAL movieDatas;

        public delegate void ProgressEventHandler(int index, int count, string name);
        public static event ProgressEventHandler progress;
        private MovieDataBLL() 
        {
            movieDatas = new MovieDataDAL();
            Task<int> t = InitMovieDataAsync();
            //InitMovieData();
        }
        public async Task<int> InitMovieDataAsync()
        {
            int t = await Task.Run(() => InitMovieData());
            return t;
        }
        private int InitMovieData() 
        {

            if (Directory.Exists(LocalPathParam.VideoPreviewPath) == false)
            {
                return -1;
            }
            DirectoryInfo d = new DirectoryInfo(LocalPathParam.VideoPreviewPath);
            List<FileInfo> fileInfos = new List<FileInfo>();
            fileInfos = GetAll(d, fileInfos);
            int i = 1;
            foreach(FileInfo info in fileInfos) 
            {
                XmlHelper.LoadXmlFile(info.FullName);
                List<string> actorNames = XmlHelper.GetXmlNodeInfos("/movie/actor/name");
                List<string> movieTags = XmlHelper.GetXmlNodeInfos("/movie/tag");
                string moviesn = XmlHelper.GetXmlNodeInfo("/movie/num");
                string thumbPicPath = info.DirectoryName+"\\"+XmlHelper.GetXmlNodeInfo("/movie/thumb");
                string posterPicPath = info.DirectoryName + "\\" + XmlHelper.GetXmlNodeInfo("/movie/poster");
                movieDatas.AddActorInfo(actorNames);
                movieDatas.AddMovieInfo(moviesn, actorNames, info.DirectoryName, thumbPicPath, posterPicPath, movieTags);
                progress?.Invoke(i, fileInfos.Count, moviesn);
                if (fileInfos.Count < 50) 
                {
                    Thread.Sleep(100);
                }
                //
                i++;
            }
            return 0;
        }

        private List<FileInfo> GetAll(DirectoryInfo dir, List<FileInfo> FileList)//搜索文件夹中的文件 
        {
            FileInfo[] allFile = dir.GetFiles("*.nfo");
            foreach (FileInfo fi in allFile)
            {
                FileList.Add(fi);
            }
            DirectoryInfo[] allDir = dir.GetDirectories();
            foreach (DirectoryInfo d in allDir)
            {
                GetAll(d, FileList);
            }
            return FileList;
        }
        public static void AddActorInfo(string path,string sn) 
        {
            XmlHelper.LoadXmlFile(path+"\\"+sn+".nfo");
            List<string> actorNames = XmlHelper.GetXmlNodeInfos("/movie/actor/name");
            List<string> movieTags = XmlHelper.GetXmlNodeInfos("/movie/tag");
            string moviesn = XmlHelper.GetXmlNodeInfo("/movie/num");
            string thumbPicPath = path + "\\" + XmlHelper.GetXmlNodeInfo("/movie/thumb");
            string posterPicPath = path + "\\" + XmlHelper.GetXmlNodeInfo("/movie/poster");
            movieDatas.AddActorInfo(actorNames);
            movieDatas.AddMovieInfo(moviesn, actorNames, path, thumbPicPath, posterPicPath, movieTags);
        }

        public static List<ActorInfo> GetActorInfos() 
        {
            return movieDatas.GetActorInfos();
        }

        public static Dictionary<string, List<string>> GetActorAllNameToInitial()
        {
            return movieDatas.GetActorAllNameToInitial();
        }

        public static List<string> GetMovieAllTags() 
        {
            return movieDatas.GetAllTags();
        }

        public static List<MovieInfo> FindActorNameToMovies(string name)
        {
            return movieDatas.FindActorNameToMovies(name);
        }

        public static List<MovieInfo> FindTagsToMovies(List<string> tags) 
        {
            return movieDatas.FindTagsToMovies(tags);
        }
        public static List<string> FindFuzzyActorNames(string name) 
        {
            return movieDatas.FindFuzzyActorNames(name);
        }
        public static List<MovieInfo> FindFuzzyMovies(string name) 
        {
            return movieDatas.FindFuzzyMovies(name);
        }
    }
}
