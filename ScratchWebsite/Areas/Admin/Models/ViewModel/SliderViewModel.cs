using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ScratchWebsite.Areas.Admin.Models.ViewModel
{
    public class SliderViewModel
    {
        public int SliderID { get; set; }
        [Display(Name = "Slider Name")]
        public string SliderTitle { get; set; }
        [Display(Name = "Description")]
        public string SliderDescription { get; set; }
        public string SliderImageUrl { get; set; }
        public Nullable<bool> DisplayOrder { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}