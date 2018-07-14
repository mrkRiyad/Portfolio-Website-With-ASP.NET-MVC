using Microsoft.AspNet.Identity.EntityFramework;
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
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/User
        public ActionResult Index()
        {
            //var users = UserManager.Users.ToList();
            //var vm = new UserViewModel();
            //foreach (var item in users)
            //{
            //    vm.Id = item.Id;
            //    vm.UserName = item.UserName;
            //    vm.Email = item.Email;
            //    vm.Roles = item.Roles;
            //}
            var userList = new List<UserViewModel>();
            foreach (var item in db.Users) 
            {
                var user = new UserViewModel(item);
                userList.Add(user);
            }
            return View(userList);
        }
        public ActionResult Get(UserViewModel user)
        {
            var userById = UserManager.Users.Where(u => u.Id == user.Id).FirstOrDefault();
            return View(userById);
        }
    }
}