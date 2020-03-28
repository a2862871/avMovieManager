using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avMovieManager.DAL
{
    public class ActorMovieData 
    {

        private string actorname;
        public string actorName 
        {
            set { actorname = value; }
            get { return actorname; }
        }
        public string actorPath 
        {
            get { return LocalPathParam.VideoPreviewPath + "\\" + actorName; }
        }
        private string pt;
        public string path
        {
            get
            {
                if (actorName.Length == 0) 
                {
                    return pt;
                }
                return LocalPathParam.VideoPreviewPath+"\\"+actorName + "\\"+ snFolderName; 
            }
        }
        private string snfoldername;
        public string snFolderName 
        {
            set { snfoldername = value; }
            get { return snfoldername; }
        }
        private string s_n;
        public string sn
        {
            set { s_n = value; }
            get { return s_n; }
        }
        private bool isch;
        public bool isChinese
        {
            set { isch = value; }
            get { return isch; }
        }
        private string jpgpath;
        public string jpgPath
        {
            set { jpgpath = value; }
            get 
            { 
                return LocalPathParam.VideoPreviewPath + "\\" + actorName + "\\" + snFolderName + "\\" + jpgpath; 
            }
        }
        private Image imgpic;
        public System.Drawing.Image img 
        {
            set { imgpic = value; }
            get { return imgpic; }
        }
    }
    public struct RGBColors
    {
        public static Color color1 = Color.FromArgb(172, 126, 241);
        public static Color color2 = Color.FromArgb(249, 118, 176);
        public static Color color3 = Color.FromArgb(253, 138, 114);
        public static Color color4 = Color.FromArgb(95, 77, 221);
        public static Color color5 = Color.FromArgb(249, 88, 155);
        public static Color color6 = Color.FromArgb(24, 161, 251);
    }
}
