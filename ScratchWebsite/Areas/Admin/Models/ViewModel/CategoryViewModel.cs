using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScratchWebsite.Areas.Admin.Models.ViewModel
{
    public class CategoryViewModel
    {
        public int CategoryID { get; set; }
        public string CatName { get; set; }
        public Nullable<int> DisplayOrder { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}