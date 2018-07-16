using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScratchWebsite.Areas.Admin.Models.ViewModel
{
    public class UserViewModel
    {
        public UserViewModel() { }
        public UserViewModel(IdentityUser user)
        {
            this.Id = user.Id;
            this.UserName = user.UserName;
            this.Email = user.Email;
        }
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
    }
    public class RoleViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class UserRoleViewModel
    {
        public string UserId { get; set; }
        public int RoleId { get; set; }
    }
}