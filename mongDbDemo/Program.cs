using avMovieManager.BLL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
//using AVDataCapture;
namespace TestDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //XmlTest.startTest();
            //ImageHelper.AddImageSignPic(@"E:\imgtest\1.jpg", @"E:\imgtest\2.jpg", @"E:\imgtest\watermark\LEAK.png", 1,100,1);
            //DataCapture dt = new DataCapture();
            //dt.SearchSn("SSNI745");
            ImageHelper.CropPosterImg(@"E:\1.jpg", @"E:\2.jpg");
        }
    }
}
