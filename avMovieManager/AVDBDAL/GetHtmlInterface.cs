using System;
using System.Collections.Generic;
using System.Text;
using HtmlAgilityPack;
namespace avMovieManager.AVDBDAL
{
    interface GetHtmlInterface
    {
        string GetTitle(); // 获取标题
        string GetStudio();  // 获取厂商
        string GetPublisher();  // 获取发行商
        string GetCover();  // 获取封面链接
        string GetRelease();  // 获取出版日期
        string GetRuntime();  // 获取分钟
        string GetDirector();  // 获取导演
        string GetSeries();  //获取系列
        List<string> GetTag();  // 获取标签
        List<string> GetActor(); //获取演员
        string GetNumber(); //获取番号
        //string GetOutlineScore(number);  // 获取简介
        //string GetCover_small(number);  // 从avsox获取封面图
    }
}
