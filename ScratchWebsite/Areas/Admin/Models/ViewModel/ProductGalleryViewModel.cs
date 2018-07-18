﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScratchWebsite.Areas.Admin.Models.ViewModel
{
    public class ProductGalleryViewModel
    {
        public int PGRID { get; set; }
        public int fkProjectID { get; set; }
        public int fkMGID { get; set; }
        public virtual MediaGalleryViewModel MediaGalleries { get; set; }
        public virtual ProjectViewModel Projects { get; set; }
    }
}