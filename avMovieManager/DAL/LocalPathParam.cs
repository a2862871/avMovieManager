using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avMovieManager.DAL
{
    public static class AvUrlParam
    {
        
    }
    public static class LocalPathParam 
    {
        //配置文件路径
        public static string ProgramIniPath
        {
            get { return System.Environment.CurrentDirectory + "\\config.ini"; }
        }
        private static string videoPlayerPath = "";

        //视频播放软件路径，如potplayer等
        public static string VideoPlayerPath
        {
            set { videoPlayerPath = value; }
            get { return videoPlayerPath; }
        }

        //存放分类后的视频目录
        private static string videopreviewpath = "";
        public static string VideoPreviewPath
        {
            set { videopreviewpath = value; }
            get { return videopreviewpath; }
        }
    }
}
