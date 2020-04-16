using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using AVDataCapture;
namespace TestDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DataCapture dt = new DataCapture();
            dt.SearchSn("PPPD702");
        }
    }
}
