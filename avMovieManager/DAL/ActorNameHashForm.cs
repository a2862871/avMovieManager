using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avMovieManager.DAL
{
    public static class ActorNameHashForm
    {
        private static string[] qiaoben = new string[] { "桥本有菜", "橋本ありな" };
        private static string[] yudugong = new string[] { "安齋らら", "RION", "宇都宮しをん" };  // 宇都宮紫苑的各种名字
        private static string[] jinyong = new string[] { "今永さな", "松永さな" }; //今永さな的各种名字
        private static string[] kui = new string[] { "葵", "小野夕子" };  //葵的名字
        private static string[] zuoboling = new string[] { "佐々波綾", "涼宮遙香" };
        private static string[] yuzhen = new string[] { "羽咲美晴", "羽咲みはる" };
        public static string getActorName(string name)
        {
            int id = Array.IndexOf(yudugong, name);
            if (id != -1)
            {
                return yudugong[0];
            }
            id = Array.IndexOf(jinyong, name);
            if (id != -1)
            {
                return jinyong[0];
            }
            id = Array.IndexOf(kui, name);
            if (id != -1)
            {
                return kui[0];
            }
            id = Array.IndexOf(zuoboling, name);
            if (id != -1)
            {
                return zuoboling[0];
            }
            id = Array.IndexOf(yuzhen, name);
            if (id != -1)
            {
                return yuzhen[0];
            }
            id = Array.IndexOf(qiaoben, name);
            if (id != -1)
            {
                return qiaoben[0];
            }
            return name;
        }
    }

}
