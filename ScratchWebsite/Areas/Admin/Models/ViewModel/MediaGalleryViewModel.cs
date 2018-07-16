using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScratchWebsite.Areas.Admin.Models.ViewModel
{
    public class MediaGalleryViewModel
    {
        public int MGID { get; set; }
        public string Caption { get; set; }
        public string FilePathOrLink { get; set; }
        public Nullable<bool> IsDefault { get; set; }
        public Nullable<bool> IsThumbnail { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}