using Microsoft.AspNetCore.Mvc;

namespace QRedirection.Controllers
{
    [ApiController]
    [Route("redirectSM")]
    public class RedirectController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            string userAgent = Request.Headers["User-Agent"].ToString();

            if (userAgent.Contains("Macintosh") || userAgent.Contains("iPhone") || userAgent.Contains("iPad") || userAgent.Contains("iPod"))
            {
                // Redireccionar a la App Store
                return Redirect("https://apps.apple.com/us/app/sm-demo-by-keito/id6470201705");
            }
            else
            {
                // Redireccionar a Google Play (para dispositivos Android y Windows)
                return Redirect("https://play.google.com/store/apps/details?id=com.keito.smdemo.app");
            }
        }
    }
}