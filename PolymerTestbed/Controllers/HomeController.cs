using System.Web.Mvc;

namespace PolymerTestbed.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [Route("")]
        [Route("~/home/index")]
        public ViewResult Index()
        {
            return View();
        }

        [Route("~/home/test")]
        public ViewResult TestComponent()
        {
            return View();
        }
    }
}