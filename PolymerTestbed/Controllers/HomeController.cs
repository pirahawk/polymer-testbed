using System.Web.Mvc;

namespace PolymerTestbed.Controllers
{
    public partial class HomeController : Controller
    {
        // GET: Home
        [Route("")]
        [Route("~/home/index")]
        public virtual ViewResult Index()
        {
            return View();
        }
    }
}