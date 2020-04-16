using System;
using System.Collections.Generic;
using System.Text;
using HtmlAgilityPack;
namespace TestDemo
{
    class javdbtest
    {
        public void starjavdb()
        {
            //查询页面测试
            string url = @"https://javdb4.com/search?q=PPPD-702&f=all";
            var web = new HtmlWeb();
            var doc = web.Load(url);
            var htmlnode = HtmlNode.CreateNode(doc.Text);
            var urls = htmlnode.SelectNodes("//*[@id=\"videos\"]/div/div/a");
            if (urls != null)
            {
                foreach (var item in urls)
                {
                    Console.WriteLine(item.Attributes["href"].Value);
                }
            }
            var ids = htmlnode.SelectNodes("//*[@id=\"videos\"]/div/div/a/div[contains(@class, \"uid\")]/text()");
            if (ids != null)
            {
                foreach (var item in ids)
                {
                    Console.WriteLine(item.InnerText);
                }
            }
        }
        public void testGetInfo()
        {
            string url = @"https://javdb4.com/v/1AO9Z";
            var web = new HtmlWeb();
            var doc = web.Load(url);
            var htmlnode = HtmlNode.CreateNode(doc.Text);
            //标题OK
            //var result = htmlnode.SelectNodes("/html/body/section/div/h2/strong/text()")[0].InnerText;


            //获取类别ok
            //var result1 = htmlnode.SelectNodes("//strong[contains(text(),\"類別:\")]/../span/text()");
            //var result2 = htmlnode.SelectNodes("//strong[contains(text(),\"類別:\")]/../span/a/text()");

            //获取图片OK
            //var result = htmlnode.SelectNodes("//img[@class='box video-cover']/@src")[0].Attributes["src"].Value;

            //缩略图
            //javdb拿不到缩略图

            //演员OK
            //var result1 = htmlnode.SelectNodes("//strong[contains(text(),\"演員\")]/../span/text()");
            //var result2 = htmlnode.SelectNodes("//strong[contains(text(),\"演員\")]/../span/a/text()");
        }
    }
}
