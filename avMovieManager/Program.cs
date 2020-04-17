﻿using avMovieManager.BLL;
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
            LocalPathParam.PicIsLoadALL = "0";
            ImageHelper.AddImageSignPic(@"E:\imgtest\1.jpg", @"E:\imgtest\2.jpg", @"E:\imgtest\watermark\SUB.png", 1, 100, 10);
            LocalPathParam.VideoPreviewPath = IniHelper.Read("MoviePath", "Path", @"I:\私人空间");
            LocalPathParam.VideoPreviewPath = @"E:\imgtest\xmltest";
            LocalPathParam.VideoPlayerPath = IniHelper.Read("PlayerPath", "Path", @"E:\Program Files\DAUM\PotPlayer\PotPlayerMini64.exe"); 
            var result = Task.Run(() => InitDB());
            if ("0".Equals(LocalPathParam.PicIsLoadALL)) 
            { 
                UI.Form_SplashScreen fsc = new UI.Form_SplashScreen();
                fsc.ShowDialog();
            }
            Application.Run(new avMovieManager.UI.Form_Main());
        }
        private static void InitDB()
        {
            //FullMovieDatas movieData = FullMovieDatas.Instance;
            MovieDataBLL m = MovieDataBLL.Instance;
        }
    }
}
