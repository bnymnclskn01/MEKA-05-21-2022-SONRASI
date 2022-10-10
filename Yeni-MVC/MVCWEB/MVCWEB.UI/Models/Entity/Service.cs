﻿using MVCWEB.UI.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWEB.UI.Models.Entity
{
    public class Service : BasicEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}