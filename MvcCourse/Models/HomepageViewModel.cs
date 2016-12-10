﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Core.Models;
using Umbraco.Web.PublishedContentModels;

namespace MvcCourse.Models
{
    public class HomepageViewModel : Homepage
    {
        public HomepageViewModel(IPublishedContent content) : base(content)
        {
        }
        //public IEnumerable<LandingPage> LandingPages { get; internal set; }

        // GET: HomepageViewModel x
    }
}