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
    public class DocumentationController : RenderMvcController
    {


        // GET: Documentation
        public override ActionResult Index(RenderModel model)
        {
            var ids = UmbracoContext
                            .Application.Services
                            .RelationService.GetByParentId(model.Content.Id)
                            .Select(x => x.ChildId);

            //fetch them as nodes
            var products = Umbraco.TypedContent(ids)
                                   .OfType<LandingPage>();
            var viewmodel = new DocumentationViewModel(model.Content)
            { LandingPages = products };
            return CurrentTemplate(viewmodel);
            //return base.Index(model);
        }

    }
}