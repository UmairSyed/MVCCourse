using MvcCourse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Umbraco.Web.WebApi;

namespace MvcCourse.Controllers
{
    public class DocumentationHistoryController : UmbracoApiController
    {
        [HttpGet]
        public IEnumerable<DocumentationVersion>Versions(int id)
        {
            return Services.ContentService
                .GetVersions(id)
                .Select(x => new DocumentationVersion()
                {
                    Name = x.Name,
                    PublishDate = x.UpdateDate,
                    VersionId = x.Version
                });
        }
        [HttpGet]
        public string PublishVersion(Guid version)
        {
            var content = Services.ContentService.GetByVersion(version);
            Services.ContentService.Publish(content);
            var newUrl = Umbraco.Url(content.Id);
            return newUrl;
        }

    }
}
