using Cleanarch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleanarch.Application.Viewmodels
{
    public class Course
    {
        public IEnumerable<Domain.Models.Course> Courses { get; set; }
    }
}
