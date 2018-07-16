using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScratchWebsite.Areas.Admin.Models.ViewModel
{
    public class ProjectViewModel
    {
        public int ProjectID { get; set; }
        public string ProjecName { get; set; }
        public string ProjectDescription { get; set; }
        public string ProjectTechnology { get; set; }
        public Nullable<int> DisplayOrder { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}