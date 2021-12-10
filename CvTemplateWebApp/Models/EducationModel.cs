using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CvTemplateWebApp.Models
{
    public class EducationModel
    {
        public string Place { get; set; }
        public int FromYear { get; set; }
        public int ToYear { get; set; }
        public string Speciality { get; set; }
    }
}
