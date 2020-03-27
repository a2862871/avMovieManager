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
    public sealed class FullMovieDatas
    {
        private static readonly Lazy<FullMovieDatas> lazy =
        new Lazy<FullMovieDatas>(() => new FullMovieDatas());

        public static FullMovieDatas Instance { get { return lazy.Value; } }


        private List<string> listactorname; //演员名字 用于排序
        private Dictionary<string, List<string>> actorNameInitia;//演员对应的拼音表
        private Dictionary<string, string> actorInfo;      //记录演员目录
        private Dictionary<string, List<actorMovieData>> actorToMovieInfo; //每个演员对应的影片目录
        private Dictionary<string, actorMovieData> snToMovieInfo; //番号对应的目录

        public delegate void RateOfProgress (int index,int count,string name);
        public static event RateOfProgress Progress;
        private FullMovieDatas()
        {
            listactorname = new List<string>();
            actorInfo = new Dictionary<string, string>();
            actorToMovieInfo = new Dictionary<string, List<actorMovieData>>();
            snToMovieInfo = new Dictionary<string, actorMovieData>();
            actorNameInitia = new Dictionary<string, List<string>>();
            InitActorInfo();
            Task<int> t = InitMoveInfoAsync();
        }

        //获取各种信息

        //获取所有演员名称
        public List<string> GetActorAllName() 
        {
            return listactorname;
        }
        public Dictionary<string,List<string>> GetActorAllNameToInitialForm() 
        {
            return actorNameInitia;
        }
        //获取该演员的所有信息
        public List<actorMovieData> GetActorNameToMoviesAllPath(string key) 
        { 
            if (actorToMovieInfo.ContainsKey(key))
                return actorToMovieInfo[key];
            return null;
        }
        //搜索演员
        public List<string> GetNameToActorList(string key) 
        {
            List<string> listName = new List<string>();
            foreach (string keys in listactorname)
            {
                if (keys.IndexOf(key) != -1)
                {
                    listName.Add(keys);
                }
            }
            return listName;
        }
        /// <summary>
        ///  搜索番号
        /// </summary>
        public List<actorMovieData> GetSnToMovieDatas(string key) 
        {
            List<actorMovieData> actorMovieDatas = new List<actorMovieData>();
            foreach (string keys in snToMovieInfo.Keys)
            {
                if (keys.IndexOf(key) != -1)
                {
                    actorMovieDatas.Add(snToMovieInfo[keys]);
                }
            }
            return actorMovieDatas;
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
                    InitiaSort(fs.Name);
                }
            }
            listactorname = listactorname.OrderBy(x => GetSpellCode(x)).ToList();
        }
        private void InitiaSort(string key) 
        {
            string initia = GetSpellCode(key);
            Char ch = initia.ToCharArray()[0];
            if (!(ch >= 'A' && ch <= 'Z')) 
            {
                initia = "#";
            }
            if (actorNameInitia.ContainsKey(initia)) 
            {
                actorNameInitia[initia].Add(key);
            }
            else 
            {
                List<string> ls = new List<string>();
                ls.Add(key);
                actorNameInitia.Add(initia, ls);
            }

        }
        private string GetSpellCode(string str)
        {
            Encoding gb2312 = Encoding.GetEncoding("gb2312");
            string strA = Pinyin.ConvertEncoding(str, Encoding.UTF8, gb2312);
            //首字母
            string strB = Pinyin.GetInitials(strA, gb2312).Substring(0, 1);
            //拼音 
            //string strC = Pinyin.GetPinyin(str);
            return strB.ToUpper();
        }
        private MemoryStream GetImgStream(string strFileName)
        {
            GC.Collect();
            System.Drawing.Image imgFullSize;
            MemoryStream stmimage;
            imgFullSize = System.Drawing.Image.FromFile(strFileName);
            stmimage = new MemoryStream();
            imgFullSize.Save(stmimage, System.Drawing.Imaging.ImageFormat.Jpeg);
            return stmimage;
        }
        public async Task<int> InitMoveInfoAsync()
        {
            int t = await Task.Run(() => InitMoveInfo());
            return t;
        }
        private int InitMoveInfo() 
        {
            int j = 1;
            foreach (KeyValuePair<string,string> kvp in actorInfo)
            {
                DirectoryInfo d = new DirectoryInfo(kvp.Value);
                FileSystemInfo[] f = d.GetFileSystemInfos();
                List<actorMovieData> listMovie = new List<actorMovieData>();
                foreach (FileSystemInfo fs in f)
                {
                    
                    if (fs is DirectoryInfo)
                    {
                        actorMovieData moviedata = new actorMovieData();
                        string name = fs.Name.Replace("-", string.Empty).ToUpper();
                        moviedata.sn = name;
                        moviedata.path = fs.FullName;
                        DirectoryInfo dir = new DirectoryInfo(fs.FullName);
                        FileInfo[] fileInfo = dir.GetFiles("*.jpg");
                        for (int i = 0; i < fileInfo.Length; i++)
                        {
                            moviedata.jpgPath = fileInfo[i].FullName;
                        }
                        if (File.Exists(fs.FullName + @"\ch.uid"))
                        {
                            moviedata.isChinese = true;
                        }
                        //空间换时间
                        if (LocalPathParam.PicIsLoadALL.Equals("1"))
                        {
                            moviedata.img = System.Drawing.Image.FromStream(GetImgStream(moviedata.jpgPath));
                        }
                        moviedata.actorName = kvp.Key;
                        listMovie.Add(moviedata);
                        if (snToMovieInfo.ContainsKey(name))
                            continue;
                        snToMovieInfo.Add(name, moviedata);
                    }
                }
                if (actorToMovieInfo.ContainsKey(kvp.Key))
                    continue;
                actorToMovieInfo.Add(kvp.Key, listMovie);
                if (Progress != null)
                    Progress(j,actorInfo.Count, kvp.Key);
                j++;
            }
            return 0;
        }
    }
}
