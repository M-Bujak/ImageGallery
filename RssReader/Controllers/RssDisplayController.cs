using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using RssReader.Models;

namespace RssReader.Controllers
{
    public class RssDisplayController : Controller
    {
        // GET: RssDisplay
        public ActionResult Index(string url)
        {
            /*
            if(string.IsNullOrWhiteSpace(url))
            {
                url = "https://news.google.com/rss?hl=pl&gl=PL&ceid=PL:pl";
            }

            var items = XElement.Load(url).Descendants("item").Select(i => new RssItem
            {
                Title = i.Element("title").Value,
                PubDate = i.Element("pubDate").Value,
                Description = i.Element("description").Value
            }).ToList();

            return View(items);
            */

            return View();
        }
    }
}