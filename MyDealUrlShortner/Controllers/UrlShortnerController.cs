using System;
using System.Collections.Generic;
using System.Globalization;
using System.Web.Mvc;
using MyDealUrlShortner.Models;

namespace MyDealUrlShortner.Controllers
{
    
    public class UrlShortnerController : Controller
    {
        public static IDictionary<string, string> UrlDictionary =new Dictionary<string, string>();
        // GET: UrlShortner
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Submit(Url url)
        {
            var shortUrl = Guid.NewGuid().GetHashCode().ToString(CultureInfo.InvariantCulture);
            UrlDictionary.Add(shortUrl, url.ActualUrl);


            url.MinifiedUrl = "http://localhost:58627/" + shortUrl;

            return View("Index", url);

        }

        public ActionResult RedirectToActual(string hashKey)
        {
            return Redirect(UrlDictionary[hashKey]);
        }
    }
}