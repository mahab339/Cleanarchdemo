using Cleanarch.Domain.Interfaces;
using Cleanarch.Infra.Data.Context;

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
