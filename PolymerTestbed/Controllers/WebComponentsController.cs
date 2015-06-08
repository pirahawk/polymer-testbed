using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PolymerTestbed.Controllers
{
    [RoutePrefix("web-components")]
    public partial class WebComponentsController : Controller
    {
        [Route("")]
        public virtual ActionResult Index()
        {
            return View();
        }
    }
}