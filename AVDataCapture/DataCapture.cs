﻿using System;
using System.Collections.Generic;
using System.Text;
using AVDataCapture.DAL;
using AVDataCapture.BLL;
namespace AVDataCapture
{
    public class DataCapture
    {
        public int SearchSn(string sn) 
        {
            GetMovieInfo jbu = new GetMovieInfo();
            jbu.StartGetInfo(sn);

            //jbu.GetMovieInfo(sn);
            //jbu.GetTitle();
            //jbu.GetStudio();
            //jbu.GetActor();
            //jbu.GetActorPhoto();
            //jbu.GetTag();
            //jbu.GetNumber();
            //jbu.GetRuntime();
            //jbu.GetCover();
            //jbu.GetRelease();
            //jbu.GetSeries();
            return 0;
        }
    }

}
