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

        MovieDataDAL mdates;

        public delegate void RateOfProgress(int index, int count, string name);
        public static event RateOfProgress Progress;
        private MovieDataBLL() 
        {
            mdates = MovieDataDAL.Instance;
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
                mdates.AddActorInfo(actorNames);
                mdates.AddMovieInfo(moviesn, actorNames, info.DirectoryName, thumbPicPath, posterPicPath, movieTags);
                Progress?.Invoke(i, fileInfos.Count, moviesn);
                Thread.Sleep(1000);
                i++;
            }
            return 0;
        }

        private static List<FileInfo> GetAll(DirectoryInfo dir, List<FileInfo> FileList)//搜索文件夹中的文件 
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

        public List<ActorInfo> GetActorInfos() 
        {
            return mdates.GetActorInfos();
        }

        public Dictionary<string, List<string>> GetActorAllNameToInitial()
        {
            return mdates.GetActorAllNameToInitial();
        }

        public List<MovieInfo> GetActorNameToMoviesAllPath(string name) 
        {
            return mdates.GetActorNameToMoviesAllPath(name);
        }
    }
}
