using Cleanarch.Domain.Interfaces;
using Cleanarch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleanarch.Infra.Data.Repositories
{
    public class Course : Icourserepository
    {
        private readonly Universitydbcontext _ctx;

        public Course(Universitydbcontext ctx)
        {
            _ctx=ctx;
        }

        public IEnumerable<Domain.Models.Course> Getcourses()
        {
            return _ctx.Courses;
        }
    }
}
