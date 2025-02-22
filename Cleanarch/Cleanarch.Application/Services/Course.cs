using Cleanarch.Application.Interfaces;
using Cleanarch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
