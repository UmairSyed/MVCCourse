using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Core.Models;
using Umbraco.Web.PublishedContentModels;

namespace MvcCourse.Models
{
    public class DocumentationFormModel
    {
        [Required]
        public string BodyText { get; set; }
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        public IEnumerable<HttpPostedFileBase> Images { get; set; }
    }
    
}