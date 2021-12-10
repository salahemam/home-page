using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CvTemplateWebApp.Models
{
    public class ExperienceModel
    {
        public string Company { get; set; }
        public string Position { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string Description { get; set; }
        public string Url { get; internal set; }
    }
}
