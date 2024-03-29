﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Core.EF
{
    [MetadataTypeAttribute(typeof(CMS_AreaOfDocument_Metadata))]
    public partial class CMS_AreaOfDocument
    {
        public class CMS_AreaOfDocument_Metadata
        {

            [Display(Name = "Tiêu đề")]
            [Required(ErrorMessage = "Vui lòng nhập tiêu đề")]
            public string Name { get; set; }

            [Display(Name = "Mô tả")]
            public string Description { get; set; }
        }
    }
}