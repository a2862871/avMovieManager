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
            SearchUrlLink.JavDbUrl = IniHelper.Read("URL", "javdb", "https://javdb4.com/");
            SearchUrlLink.JavLibraryUrl = IniHelper.Read("URL", "javlibrary", "http://www.n43a.com/cn/");
            SearchUrlLink.AvMooUrl = IniHelper.Read("URL", "avmoo", "https://avmask.com/cn/");
            SearchUrlLink.AvSoxUrl = IniHelper.Read("URL", "avsox", "https://avsox.host/cn/");
            LocalPathParam.PicIsLoadALL = "1";
            LocalPathParam.VideoPreviewPath = @"i:\私人空间";
            LocalPathParam.VideoPlayerPath = @"E:\Program Files\DAUM\PotPlayer\PotPlayerMini64.exe";
            var result = Task.Run(() => InitDB());
            if ("1".Equals(LocalPathParam.PicIsLoadALL)) 
            { 
                UI.Form_SplashScreen fsc = new UI.Form_SplashScreen();
                fsc.ShowDialog();
            }
            Application.Run(new avMovieManager.UI.Form_Main());
        }
        private static void InitDB()
        {
            FullMovieDatas movieData = FullMovieDatas.Instance;
        }
    }
}
