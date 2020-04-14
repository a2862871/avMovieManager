using NPinyin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avMovieManager.BLL
{
    public class PinyinHelper
    {
        public static string InitiaSort(string key)
        {
            string initia = GetSpellCode(key);
            Char ch = initia.ToCharArray()[0];
            if (!(ch >= 'A' && ch <= 'Z'))
            {
                initia = "#";
            }
            return initia;
        }

        private static string GetSpellCode(string str)
        {
            Encoding gb2312 = Encoding.GetEncoding("gb2312");
            string strA = Pinyin.ConvertEncoding(str, Encoding.UTF8, gb2312);
            //首字母
            string strB = Pinyin.GetInitials(strA, gb2312).Substring(0, 1);
            //拼音 
            //string strC = Pinyin.GetPinyin(str);
            return strB.ToUpper();
        }
    }
}
