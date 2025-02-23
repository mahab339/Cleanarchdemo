namespace Cleanarch.Domain.Interfaces
{
    public interface Icourserepository
    {
        IEnumerable<Models.Course> Getcourses();
    }
}
