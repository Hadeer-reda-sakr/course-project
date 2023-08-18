using Domain.Models;

namespace ServiceLayer.CourseService
{
    public interface ICourseService
    {
        IEnumerable<Course> GetCourses();
        Course GetCourse(long id);
        void InsertCourse(Course course);
        void UpdateCourse(Course course);
        void DeleteCourse(long id);
    }
}
