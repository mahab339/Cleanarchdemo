using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleanarch.Domain.Interfaces
{
    public interface Icourserepository
    {
        IEnumerable<Models.Course> Getcourses();
    }
}
