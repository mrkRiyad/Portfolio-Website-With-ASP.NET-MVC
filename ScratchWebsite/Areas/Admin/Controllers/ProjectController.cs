using ScratchWebsite.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScratchWebsite.Areas.Admin.Controllers
{
    public class ProjectController : Controller
    {
        ProjectDB _db = new ProjectDB();
        // GET: Admin/Project
        public ActionResult Index()
        {
            var model = _db.GetAll();
            return View(model);
        }
    }
}