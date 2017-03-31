using System.Web.Http;
using System.Web.Http.Results;

namespace MyDealUrlShortner.Controllers.ApiControllers
{
    
    public class UrlController : ApiController
    {
       
        [HttpGet]
        public IHttpActionResult GetUrl()
        {
            return Ok("ss");
        }
    }
}
