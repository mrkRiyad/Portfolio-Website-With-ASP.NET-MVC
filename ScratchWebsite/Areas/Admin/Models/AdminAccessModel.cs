using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScratchWebsite.Areas.Admin.Models
{
    public class UserViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public virtual IEnumerable<RoleViewModel> Roles { get; set; }    
    }
    public class RoleViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}