using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ScratchWebsite.Areas.Admin.Models.ViewModel
{
    public class ServiceViewModel
    {
        public int ServiceID { get; set; }

        [Required]
        [Display(Name = "Service Name")]
        public string ServiceName { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string ServiceDescription { get; set; }

        [Required]
        [Display(Name = "Icon Name")]
        public string Icon { get; set; }

        [Display(Name = "Display Order")]
        public Nullable<int> DisplayOrder { get; set; }

        [Display(Name = "Public")]
        public bool IsActive { get; set; }
    }
}