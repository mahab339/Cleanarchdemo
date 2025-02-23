using Cleanarch.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Cleanarch.Infra.Data.Context
{
    public class Universitydbcontext : DbContext
    {
        public Universitydbcontext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
    }
}
