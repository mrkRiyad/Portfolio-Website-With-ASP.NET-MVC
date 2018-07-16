using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScratchWebsite.Areas.Admin.Models.ViewModel
{
    public class CatProjectViewModel
    {
        public int CPRID { get; set; }
        public int fkProjectID { get; set; }
        public int fkCategoryID { get; set; }
    }
}