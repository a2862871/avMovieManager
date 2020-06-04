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
            LoadIni();
            MovieDataBLL movieData = MovieDataBLL.Instance;
            if (movieData.GetXmlFileCount()>0)
            {
                UI.Form_SplashScreen fsc = new UI.Form_SplashScreen();
                fsc.ShowDialog();
            }
            Application.Run(new avMovieManager.UI.Form_Main());
        }

        private static void LoadIni() 
        {
            AvUrlLink.JavDbUrl = IniHelper.Read("URL", "javdb", "");
            AvUrlLink.JavLibraryUrl = IniHelper.Read("URL", "javlibrary", "");
            AvUrlLink.AvMooUrl = IniHelper.Read("URL", "avmoo", "");
            AvUrlLink.AvSoxUrl = IniHelper.Read("URL", "avsox", "");
            AvUrlLink.JavBusUrl = IniHelper.Read("URL", "javbus", "");
            LocalPathParam.WatiMovieSortPath = IniHelper.Read("WaitClassifyPath", "WaitClassify", "");
            LocalPathParam.VideoPreviewPath = IniHelper.Read("MoviePath", "Path", "");
            LocalPathParam.VideoPlayerPath = IniHelper.Read("PlayerPath", "Path", "");
            LocalPathParam.SortFinalOutPath = IniHelper.Read("SortOutPath", "OutPath", "");
            if (IniHelper.Read("LoadPic", "LoadALL", "0").Equals("1"))
            {
                LocalPathParam.PicIsLoadALL = true;
            }
        }
    }
}
