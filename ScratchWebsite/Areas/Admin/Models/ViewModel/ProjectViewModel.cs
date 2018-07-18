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
        public IEnumerable<string> CatName { get; set; }

        //public Nullable<int> MGID { get; set; }
        //public string Caption { get; set; }
        //public string FilePathOrLink { get; set; }
        //public Nullable<bool> IsDefault { get; set; }
        //public Nullable<bool> IsThumbnail { get; set; }

        public Nullable<int> DisplayOrder { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}