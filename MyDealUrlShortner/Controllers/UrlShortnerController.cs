using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;
using MyDealUrlShortner.Models;
using MyDealUrlShortner.ViewModels;

namespace MyDealUrlShortner.Controllers
{
    
    public class UrlShortnerController : Controller
    {
        private ApplicationDbContext DbContext;
        public UrlShortnerController()
        {
            DbContext=new ApplicationDbContext();
        }
        public static IDictionary<string, string> UrlDictionary =new Dictionary<string, string>();
        // GET: UrlShortner
        public ActionResult Index()
        {
            var urlModel = new UrlViewModel();
            return View(urlModel);
        }

        [HttpPost]
        public ActionResult Index(UrlViewModel url)
        {
            if (ModelState.IsValid)
            {

                var exisitngUrl = DbContext.Urls.SingleOrDefault(u => u.ActualUrl == url.ActualUrl);
                if (exisitngUrl != null)
                {
                    url.MinifiedUrl = "http://localhost:58627/" + exisitngUrl.MinifiedUrl;
                }
                else
                {
                    var shortUrl = Guid.NewGuid().GetHashCode().ToString(CultureInfo.InvariantCulture);
                    DbContext.Urls.Add(new Url() { ActualUrl = url.ActualUrl, MinifiedUrl = shortUrl});
                    DbContext.SaveChanges();
                    url.MinifiedUrl = "http://localhost:58627/" + shortUrl;
                }
            

            }
            return View(url);

        }

        public ActionResult RedirectToActual(string hashKey)
        {

            return Redirect(DbContext.Urls.Single(u => u.MinifiedUrl == hashKey).ActualUrl);
        }
    }
}