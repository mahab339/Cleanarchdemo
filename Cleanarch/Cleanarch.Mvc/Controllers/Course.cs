using Cleanarch.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cleanarch.Mvc.Controllers
{
    [Authorize]
    public class Course : Controller
    {
        private readonly Icourseservice _Courseservice;

        public Course(Icourseservice courseservice)
        {
            _Courseservice=courseservice;
        }


        // GET: /<controller>
        public IActionResult Index()
        {
            Application.Viewmodels.Course model = _Courseservice.Getcourses();
            return View(model);
        }
    }
}
