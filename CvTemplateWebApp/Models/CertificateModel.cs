using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CvTemplateWebApp.Models
{
    public class CertificateModel
    {
        public string Title { get; internal set; }
        public string Place { get; internal set; }
        public string Date { get; internal set; }
        public string Url { get; internal set; }
    }
}
