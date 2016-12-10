using MvcCourse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;
using Umbraco.Web.PublishedContentModels;

namespace MvcCourse.Controllers
{
    public class HomepageController : RenderMvcController
    {
        // GET: Homepage
        public override ActionResult Index(RenderModel model)
        {
            return base.Index(model);
        }
    }
}