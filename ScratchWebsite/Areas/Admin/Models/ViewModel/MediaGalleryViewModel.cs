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
        public string FileName { get; set; }
        public string FileFormat { get; set; }
        public string ThumbnailUrl { get; set; }

        public int PGRID { get; set; }
        public Nullable<bool> IsDefault { get; set; }
        public string ImageSize { get; set; }

    }
}