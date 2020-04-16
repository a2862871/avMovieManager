using System;
using System.Collections.Generic;
using System.Text;
using AVDataCapture.DAL;
namespace AVDataCapture
{
    public class DataCapture
    {
        public int SearchSn(string sn) 
        {
            JavBusGetMovieInfo jbu = new JavBusGetMovieInfo();
            jbu.GetMovieInfo(sn);
            jbu.GetTitle();
            jbu.GetStudio();
            return 0;
        }
    }

}
