using CvTemplateWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CvTemplateWebApp.Helpers
{
    public static class CvDataHelper
    {
        public static List<string> GetLanguages()
        {
            return new List<string>
            {
                "Arabic",
                "English"
            };
        }

        public static List<ProjectModel> GetProjects()
        {
            return new List<ProjectModel>
            {
                new ProjectModel
                {
                    Title = "Qorrect Assessment",
                    Tools = "C#.Net, ASP.Net MVC Core, SqlServer, Redis, IdentityServer4, Hangfire",
                    Description = "Online exams assessment product which manages exams, teachers, students. It allows teachers to create and assign exams with different questions & layouts for their students."
                },
                new ProjectModel
                {
                    Title = "Key2Learn",
                    Tools = "C#.Net, ASP.Net MVC Core, MongoDB",
                    Description = "Learning management system (LMS) which manages schools, teachers, students, and parents. It allows teachers to create and assign couses, meeting, and materials for their students."
                },
                new ProjectModel
                {
                    Title = "Future Leaders",
                    Tools = "C#.Net, ASP.Net MVC, WCF Services, Sql Server",
                    Description = "Educational web application which allows the ministry to choose the most talented graduates or teachers to fullll the available leadership positions"
                },
                new ProjectModel
                {
                    Title = "Waed",
                    Tools = "C#.Net, ASP.Net MVC Core, WCF Services, Sql Server",
                    Description = "Educational web application which allows ltering the ministry employees by passing some exams and surveys and also making interviews and trainings based on their skills"
                },
                new ProjectModel
                {
                    Title = "Future Leaders",
                    Tools = "C#.Net, ASP.Net MVC, WCF Services, Sql Server",
                    Description = "Educational web application which allows the ministry to choose the most talented graduates or teachers to fullll the available leadership positions"
                },
                new ProjectModel
                {
                    Title = "Safeer Graduates",
                    Tools = "C#.Net, ASP.Net MVC, WCF Services, Sql Server",
                    Description = "Educational web application that integrates with many WCF services which allows the graduates to publish their CVs and apply for jobs or trainings offered by other registered agencies."
                },
                new ProjectModel
                {
                    Title = "Online Banking Webservices",
                    Tools = "C#.Net, ASP.Net WebApis, Oracle",
                    Description = "Build webservices for integration with internal bank system & exposed to external customers portal"
                },
                new ProjectModel
                {
                    Title = "iSHRAQ",
                    Tools = "C#.Net, ASP.Net WebForms, Oracle",
                    Description = "Banking software product for internal & external bank activities management & core banking."
                },
                new ProjectModel
                {
                    Title = "EduWave",
                    Tools = "C#.Net, Asp.Net WebApis Asp.Net WebForms, Sql Server",
                    Description = "Large e-learning system for all study levels which helps students and teachers communication & cover many schools in the Gulf"
                },
                new ProjectModel
                {
                    Title = "GAZT",
                    Tools = "C#.Net, Asp.Net WebApis, Sql Server, Angular 1.x, Active Directory, SAP, CRM.",
                    Description = "Inspection for agencies that have not paid their VAT or Excise Taxes to detect violations and set penalities on their owners & integrate with active directory and other external services (SAP, CRM)."
                },
                new ProjectModel
                {
                    Title = "MOT",
                    Tools = "C#.Net, Asp.Net WebApis, Sql Server, Angular 1.x",
                    Description = "Tracking and reporting accidents or violations in roads."
                },
                new ProjectModel
                {
                    Title = "Onaizah Municipality",
                    Tools = "C#.Net, Asp.Net WebApis, Sql Server, Oracle, Angular 1.x Active Directory.",
                    Description = "Inspection for all shops in Onaizah to check violations and set penalities on their owners & sync with oracle db & integrate with active directory."
                },
                new ProjectModel
                {
                    Title = "MLSD",
                    Tools = "C#.Net, Asp.Net WebApis, Sql Server, Oracle, SSIS, Angular 1.x.",
                    Description = "Inspection for poor people who need help or money & sync with ministry oracle db."
                },
                new ProjectModel
                {
                    Title = "GAMEP",
                    Tools = "C#.Net, Asp.Net WebApis, Sql Server, Angular 1.x..",
                    Description = "Inspection for buildings, factories, or agencies which have environmental violations & go through approval & revision workow"
                },
                new ProjectModel
                {
                    Title = "MOF",
                    Tools = "C#.Net, Asp.Net WebApis, Sql Server, Angular 1.x",
                    Description = "Provides news related to the ministry & integrate with mobile app."
                },
                new ProjectModel
                {
                    Title = "BRAVO Product",
                    Tools = "C#.Net, Asp.Net WebApis, Sql Server, Angular 1.x",
                    Description = "Generic eld inspection product with dynamic form builder, form viewer (web & mobile), workow, and task distribution."
                },
                new ProjectModel
                {
                    Title = "http://www.royalceramica.com",
                    Tools = "C#.Net, Asp.Net MVC, Sql Server, Orchard CMS",
                    Description = "Ceramica Royal company ofcial website."
                },
                new ProjectModel
                {
                    Title = "http://www.egysurvey.com",
                    Tools = "C#.Net, Asp.Net Webforms, Sql Server",
                    Description = "Design simple & professional surveys with different templates."
                },
                new ProjectModel
                {
                    Title = "http://www.rakeeb.net",
                    Tools = "C#.Net, Asp.Net Webforms, Sql Server, Charts, Windows Services",
                    Description = "Egypt Elections Supervision, News, Results, Statistics and Maps."
                },
                new ProjectModel
                {
                    Title = "http://www.emta7anat.com",
                    Tools = "C#.Net, Asp.Net Webforms, Sql Server",
                    Description = "Exams online for students, teachers, and schools."
                },
                new ProjectModel
                {
                    Title = "http://www.reservegypt.com",
                    Tools = "C#.Net, Asp.Net Webforms, Sql Server",
                    Description = "Hotels Reservation system for Egypt and other services."
                },
                new ProjectModel
                {
                    Title = "http://www.eiod.org",
                    Tools = "C#.Net, Asp.Net Webforms, Sql Server",
                    Description = "Egyptian Institute of Directors."
                },
                new ProjectModel
                {
                    Title = "http://www.ecrc.org.eg",
                    Tools = "C#.Net, Asp.Net Webforms, Sql Server",
                    Description = "Egyptian Corporate Responsibility Center."
                },
                new ProjectModel
                {
                    Title = "http://www.followmycars.com",
                    Tools = "C#.Net, Asp.Net Webforms",
                    Description = "Marketing website for tracking cars through GPS tools."
                },
                new ProjectModel
                {
                    Title = "http://www.acs-egypt.com",
                    Tools = "C#.Net, Asp.Net Webforms, Sql Server",
                    Description = "Management system for ACS Company."
                },
                new ProjectModel
                {
                    Title = "Gait Analysis for Human Identication",
                    Tools = "C#.Net, OpenCV, Sql Server",
                    Description = "Graduation Project which aims to identify the individuals by their gait (i.e. the manner they walk) from a video sequence. Won ITIDA prize"
                },
            };
        }

        public static List<ExperienceModel> GetWorkExperience()
        {
            return new List<ExperienceModel>
            {
                new ExperienceModel
                {
                    Position = "Software Team Lead",
                    Company = "Qorrect Assessment",
                    FromDate = "MAR-2021",
                    ToDate = "Present",
                    Url = "https://qorrectassess.com/",
                    Description = "Lead the development team to achieve tasks for the company Online Assessment product. My activities includes leadership, supervision, interview, refactoring, code reviews, research for best solutions, architecture & design."
                },
                new ExperienceModel
                {
                    Position = "Technical Lead",
                    Company = "Key2Soft",
                    FromDate = "Jan-2020",
                    ToDate = "MAR-2021",
                    Url = "http://www.key2soft.com/",
                    Description = "Delivered educational projects to Saudi client like TETCO software company and Ministry of Education"
                },
                new ExperienceModel
                {
                    Position = "Senior Software Engineer",
                    Company = "Path Solutions",
                    FromDate = "Nov-2018",
                    ToDate = "Dec-2019",
                    Url = "https://www.path-solutions.com/",
                    Description = "Work on large banking system 'iSHRAQ' with banking clients like 'Gulf Bank' and also build web services for integration."
                },
                new ExperienceModel
                {
                    Position = "Technical Team Lead",
                    Company = "Integrated Technology Group",
                    FromDate = "Aug-2018",
                    ToDate = "Nov-2018",
                    Url = "https://www.itgsolutions.com/",
                    Description = "Lead the development team to achieve tasks for large e-learning solution 'EduWave' and also build solutions from scratch using WebApis, Authentication, SignalR & WebSockets."
                },
                new ExperienceModel
                {
                    Position = ".Net Team Leader",
                    Company = "CodeLab",
                    FromDate = "May-2015",
                    ToDate = "July-2018",
                    Url = "http://www.codelabsys.com/",
                    Description = "Lead the development team to work on Dynamic Inspection System using angular & WebApis, and also was responsible for code review &deployments delivered to multiple different clients in Saudi Arabia"
                },
                new ExperienceModel
                {
                    Position = "Senior .Net Web Developer",
                    Company = "Vodafone International Services",
                    FromDate = "Jul-2014",
                    ToDate = "Apr-2015",
                    Url = "http://vis.vodafone.com.eg/",
                    Description = "Worked on the ofcial website for Ceramica Royal using Orchard CMS application built on ASP.Net MVC"
                },
                new ExperienceModel
                {
                    Position = "Senior .Net Web Developer",
                    Company = "Advanced Computer Systems",
                    FromDate = "Jan-2013",
                    ToDate = "July-2014",
                    Url = "http://www.acs-egypt.com/",
                    Description = "Developed different web & desktop projects using C#.Net, VB.Net, ASP.Net, SqlServer, Crystal Reports."
                },
                new ExperienceModel
                {
                    Position = "Junior .Net Web Developer",
                    Company = "Advanced Computer Systems",
                    FromDate = "Mar-2010",
                    ToDate = " Jan-2013",
                    Url = "http://www.acs-egypt.com/",
                    Description = "Developed different web & desktop projects using C#.Net, VB.Net, ASP.Net, SqlServer, Crystal Reports."
                },
            };
        }

        public static List<string> GetTechnicalSkills()
        {
            return new List<string>
            {
                "C#.Net", "VB.Net",
"ASP.Net (WebForms, MVC, WebApis)",
"ASP.Net MVC Core", "DotNet Core",
                "Entity Framework", "EF Core",
"Design Patterns",
"OOP", "SOLID Principles",
                "AngularJS", "Angular 2+", "KnockoutJs",
"HTML", "CSS", "Bootstrap",
"JavaScript", "jQuery", "AJAX",
"JSON", "XML", "WCF",
"MongoDB (Query, Aggregation, Performance)",
"SQL Server", "SSIS",
"Oracle", "MS Access",
"Crystal Reports", "iReport", "SSRS",
                "Cloud (Amazon, Azure)",
"Git", "TFVS", "JIRA",
"Agile", "Scrum",
"SignalR", "WebSockets",
"Basics in (SharePoint, Orchard CMS, Ionic Framework, Android, WordPress, Joomla, C++, JAVA, Win 8 Apps)."
            };
        }

        public static List<CourseModel> GetCourses()
        {
            return new List<CourseModel>
            {
                new CourseModel
                {
                    Title = "Get Started With .Net Core Identity Server 4",
                    IsOnline = true,
                    Place = "Udemy",
                    Date = "June 2021"
                },
                new CourseModel
                {
                    Title = "Learn Amazon web services (AWS): The complete introduction",
                    IsOnline = true,
                    Place = "Udemy",
                    Date = "Feb 2021"
                },
                new CourseModel
                {
                    Title = "MongoDB Basics",
                    IsOnline = true,
                    Place = "MongoDB University",
                    Date = "October 2020"
                },
                new CourseModel
                {
                    Title = "MongoDB Aggregation Framework",
                    IsOnline = true,
                    Place = "MongoDB University",
                    Date = "October 2020"
                },
                new CourseModel
                {
                    Title = "MongoDB Performance",
                    IsOnline = true,
                    Place = "MongoDB University",
                    Date = "October 2020"
                },
                new CourseModel
                {
                    Title = "MongoDB for Python Developers",
                    IsOnline = true,
                    Place = "MongoDB University",
                    Date = "October 2020"
                },
                new CourseModel
                {
                    Title = "Angular 9 - The Complete Guide 2020 Edition",
                    IsOnline = true,
                    Place = "Udemy",
                    Date = "June 2020"
                },
                new CourseModel
                {
                    Title = "Leadership Skills",
                    IsOnline = true,
                    Place = "E3melBusiness Academy",
                    Date = "July 2019"
                },
                new CourseModel
                {
                    Title = "Professional CEO",
                    IsOnline = true,
                    Place = "E3melBusiness Academy",
                    Date = "July 2019"
                },
                new CourseModel
                {
                    Title = "Modern Software Architecture",
                    Place = "SECC-ITIDA",
                    Date = "June 2019"
                },
                new CourseModel
                {
                    Title = "SECC Agile Foundation",
                    Place = "SECC-ITIDA",
                    Date = "April 2018"
                },
                new CourseModel
                {
                    Title = "Mastering the Basics of SQL Server Query Optimization",
                    IsOnline = true,
                    Place = "Udemy",
                    Date = "Jan 2018"
                },
                new CourseModel
                {
                    Title = "Mini MBA",
                    Place = "Smart Vision",
                    Date = "Jan 2018"
                },
                new CourseModel
                {
                    Title = "Developing Microsoft SharePoint Server 2013 Core Solutions",
                    Place = "New Horizons",
                    Date = "June 2015"
                },
                new CourseModel
                {
                    Title = "Cloud Business Essentials",
                    Place = "ITSynergy",
                    Date = "January 2014"
                },
                new CourseModel
                {
                    Title = "Android Application Development",
                    Place = "Asgatech",
                    Date = "March 2014"
                },
                new CourseModel
                {
                    Title = "Code Refactoring Techniques",
                    Place = "SECC-ITIDA",
                    Date = "June 2013"
                },
                new CourseModel
                {
                    Title = "Test Driven Development",
                    Place = "SECC-ITIDA",
                    Date = "June 2013"
                },
                new CourseModel
                {
                    Title = "Berlitz Prociency Level 1 (English Course)",
                    Place = "Berlitz",
                    Date = "April 2012"
                },
            };
        }

        public static List<CertificateModel> GetCertificates()
        {
            return new List<CertificateModel>
            {
                new CertificateModel
                {
                    Title = "SECC Agile Foundation",
                    Place = "SECC",
                    Date = "May 2018",
                    Url = "http://www.secc.org.eg/"
                },
                new CertificateModel
                {
                    Title = "CCC Cloud Business Associate",
                    Place = "TIEC",
                    Date = "February 2014",
                    Url = "http://www.cloudcredential.org/"
                }
            };
        }

        public static List<string> GetPersonalSkills()
        {
            return new List<string>
            {
                "Good Leadership skills",
                "Committed",
                "Analytical",
                "Love Thinking",
                "Cooperative",
                "Hard Worker",
                "Team Player",
                "Process-oriented",
                "Organized"
            };
        }

        public static List<EducationModel> GetEducation()
        {
            return new List<EducationModel>
            {
                new EducationModel
                {
                     Place = "FCIS @ Ainshams University",
                     FromYear = 2005,
                     ToYear = 2009,
                      Speciality = "Information Systems Department"
                },
                new EducationModel
                {
                    Place = "Mubarak Secondary",
                    FromYear = 2002,
                    ToYear=2005,
                     Speciality = "Thanawia ‘Amma"
                   }
            };
        }

        public static string GetCareerSummary()
        {
            return @"Experienced software engineer with more than 10 years in the software development field
                                working with different desktop and web technologies. Also have a strong awareness of projects
                                software life cycle including analysis, requirements gathering, planning, development, testing,
                                deployment, and code reviews";
        }
    }
}
