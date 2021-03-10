using RestSharp;
using RssReader.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;

namespace RssReader.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery
        public ActionResult Index(int? pageNum)
        {
            var restClient = new RestClient("https://api.unsplash.com/");
            var restRequest = new RestRequest("photos/", Method.GET);

            restRequest.AddParameter("client_id", "tcO82gjK9_1xOeA8My23Xx-jepw3i5CKW3bLFpdHzpk");
            restRequest.AddParameter("orientation", "squarish");
            var response = restClient.Get<List<ImgItem>>(restRequest);

            if(response.IsSuccessful)
            {
                return View(response.Data.ToPagedList(pageNum ?? 1, 4));
            }
            else
            {
                return null;
            }
            
        }
    }
}


