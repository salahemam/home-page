using CvTemplateWebApp.Helpers;
using CvTemplateWebApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace CvTemplateWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public string CareerSummary { get; set; }
        public List<EducationModel> Educations { get; set; }
        public List<string> PersonalSkills { get; set; }
        public List<string> Languages { get; set; }
        public List<string> TechnicalSkills { get; set; }
        public List<ExperienceModel> WorkExperience { get; set; }
        public List<CourseModel> Courses { get; set; }
        public List<CertificateModel> Certificates { get; set; }
        public List<ProjectModel> Projects { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            CareerSummary = CvDataHelper.GetCareerSummary();

            Educations = CvDataHelper.GetEducation();

            PersonalSkills = CvDataHelper.GetPersonalSkills();

            Certificates = CvDataHelper.GetCertificates();

            Courses = CvDataHelper.GetCourses();

            TechnicalSkills = CvDataHelper.GetTechnicalSkills();

            WorkExperience = CvDataHelper.GetWorkExperience();

            Projects = CvDataHelper.GetProjects();

            Languages = CvDataHelper.GetLanguages();
        }
    }
}
