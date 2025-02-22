using Cleanarch.Application.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleanarch.Application.Interfaces
{
    public interface Icourseservice
    {
        Viewmodels.Course Getcourses();
    }
}
