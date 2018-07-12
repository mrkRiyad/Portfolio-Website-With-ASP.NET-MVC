using Microsoft.AspNet.Identity.Owin;
using ScratchWebsite.Areas.Admin.Models;
using ScratchWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ScratchWebsite.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        private ApplicationUserManager _userManager;
        public UserController() { }
        public UserController(ApplicationUserManager userManager)
        {
            UserManager = userManager;
        }
        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }
        // GET: Admin/User
        public ActionResult Index()
        {
            var users = UserManager.Users.ToList();
            return View(users);
        }
        public ActionResult Get(UserViewModel user)
        {
            var userById = UserManager.FindByIdAsync(user.ID.ToString());
            return View(userById);
        }
    }
}