using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScratchWebsite.Areas.Admin.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        // GET: Admin/Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddSlide()
        {
            return View();
        }
    }
}