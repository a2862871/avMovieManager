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


        private List<string> listactorname; //演员名字 用于搜索演员的时候
        private List<ActorMovieData> listactorMovieDatas; //一个list搞定，发现效率和之前字典差不多。
        private Dictionary<string, List<string>> actorNameInitia;//演员名称按照字母排序
        private Dictionary<string, string> actorInfo;      //记录演员目录 主要用作加载时进度条演示

        public delegate void RateOfProgress (int index,int count,string name);
        public static event RateOfProgress Progress;
        private FullMovieDatas()
        {
            listactorMovieDatas = new List<ActorMovieData>();
            listactorname = new List<string>();
            actorInfo = new Dictionary<string, string>();
            actorNameInitia = new Dictionary<string, List<string>>(); 
            InitActorInfo();
            //InitMoveInfo();
            Task<int> t = InitMoveInfoAsync();
        }

        //获取各种信息

        /// <summary>
        ///  获取所有演员名字
        /// </summary>
        public List<string> GetActorAllName() 
        {
            return listactorname;
        }
        /// <summary>
        ///  获取按照拼音排序的演员名字
        /// </summary>
        public Dictionary<string,List<string>> GetActorAllNameToInitialForm() 
        {
            return actorNameInitia;
        }
        /// <summary>
        ///  获取该演员的所有影片
        /// </summary>
        public List<ActorMovieData> GetActorNameToMoviesAllPath(string key) 
        {
            List<ActorMovieData> lsa = new List<ActorMovieData>();
            foreach (ActorMovieData kvp in listactorMovieDatas)
            {
                if (kvp.actorName.Equals(key))
                    lsa.Add(kvp);
            }
            return lsa;
        }
        public void AddActorMovieData(ActorMovieData data)
        {
            if (LocalPathParam.PicIsLoadALL.Equals("1"))
            {
                data.img = System.Drawing.Image.FromStream(GetImgStream(data.jpgPath));
            }
            listactorMovieDatas.Add(data);
            if(!listactorname.Contains(data.actorName))
            {
                listactorname.Add(data.actorName);
                InitiaSort(data.actorName);
            }
        }
        /// <summary>
        ///  搜索演员
        /// </summary>
        public List<string> SearchNameToActorList(string key) 
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
        public List<ActorMovieData> SearchSnToMovieDatas(string key) 
        {
            List<ActorMovieData> lsa = new List<ActorMovieData>();
            foreach (ActorMovieData kvp in listactorMovieDatas)
            {
                if (kvp.sn.Equals(key))
                    lsa.Add(kvp);
            }
            return lsa;
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
                foreach (FileSystemInfo fs in f)
                {
                    
                    if (fs is DirectoryInfo)
                    {
                        ActorMovieData moviedata = new ActorMovieData();
                        moviedata.actorName = kvp.Key;
                        moviedata.snFolderName = fs.Name;
                        string name = fs.Name.Replace("-", string.Empty).ToUpper();
                        moviedata.sn = name;
                        DirectoryInfo dir = new DirectoryInfo(fs.FullName);
                        FileInfo[] fileInfo = dir.GetFiles("*.jpg");
                        for (int i = 0; i < fileInfo.Length; i++)
                        {
                            moviedata.jpgPath = fileInfo[i].Name;
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
                        listactorMovieDatas.Add(moviedata);
                    }
                }
                Progress?.Invoke(j,actorInfo.Count, kvp.Key);
                j++;
            }
            return 0;
        }
    }
}
