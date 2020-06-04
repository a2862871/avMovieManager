using avMovieManager.BLL;
using avMovieManager.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace avMovieManager
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AvUrlLink.JavDbUrl = IniHelper.Read("URL", "javdb", "https://javdb4.com/");
            AvUrlLink.JavLibraryUrl = IniHelper.Read("URL", "javlibrary", "http://www.n43a.com/cn/");
            AvUrlLink.AvMooUrl = IniHelper.Read("URL", "avmoo", "https://avmask.com/cn/");
            AvUrlLink.AvSoxUrl = IniHelper.Read("URL", "avsox", "https://avsox.host/cn/");
            AvUrlLink.JavBusUrl = IniHelper.Read("URL", "javbus", "https://www.seedmm.zone/");
            LocalPathParam.WatiMovieSortPath = IniHelper.Read("WaitClassifyPath", "WaitClassify","");
            LocalPathParam.VideoPreviewPath = IniHelper.Read("MoviePath", "Path", @"E:\movie\整理内容");
            LocalPathParam.VideoPlayerPath = IniHelper.Read("PlayerPath", "Path", @"E:\Program Files\DAUM\PotPlayer\PotPlayerMini64.exe");
            LocalPathParam.SortFinalOutPath = IniHelper.Read("SortOutPath", "OutPath", @"I:\out");
            if(IniHelper.Read("LoadPic", "LoadALL", "0").Equals("1")) 
            {
                LocalPathParam.PicIsLoadALL = true;
            } 
            MovieDataBLL movieData = MovieDataBLL.Instance;
            if (movieData.GetXmlFileCount()>0)
            {
                UI.Form_SplashScreen fsc = new UI.Form_SplashScreen();
                fsc.ShowDialog();
            }
            Application.Run(new avMovieManager.UI.Form_Main());
        }
    }
}
