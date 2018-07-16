using ScratchWebsite.Areas.Admin.Models;
using ScratchWebsite.Areas.Admin.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScratchWebsite.Areas.Admin.Controllers
{
    public class ServiceController : Controller
    {
        ServiceDB crud = new ServiceDB();
        // GET: Admin/Service
        public ActionResult Index()
        {
            var model = crud.GetAll();
            return View(model);
        }

        [HttpGet]
        public ActionResult Create() => View();
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ServiceViewModel service)
        {
            if (ModelState.IsValid)
            {
                var model = crud.Add(service);
                return View("Edit", model);
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            if (ModelState.IsValid)
            {
                var model = crud.Get(id);
                return View(model);
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ServiceViewModel service)
        {
            var model = crud.Update(service);
            return View("Edit", model);
        }
        
        public ActionResult Delete(int id)
        {
            crud.Delete(id);
            return RedirectToAction("Index");
        }

    }
}