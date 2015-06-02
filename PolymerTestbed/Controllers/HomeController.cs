using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PolymerTestbed.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [Route("")]
        [Route("home/index")]
        public ViewResult Index()
        {
            return View();
        }

        
    }
}