using Cleanarch.Application.Interfaces;
using Cleanarch.Domain.Interfaces;

namespace Cleanarch.Application.Services
{
    public class Course : Icourseservice
    {
        private readonly Icourserepository _Courserepository;

        public Course(Icourserepository courserepository)
        {
            _Courserepository=courserepository;
        }

        public Viewmodels.Course Getcourses()
        {
            return new Viewmodels.Course
            {
                Courses = _Courserepository.Getcourses()
            };
        }
    }
}
