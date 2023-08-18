using Domain.Models;
using presentence.Repository;

namespace ServiceLayer.CourseService
{
    public class CourseService : ICourseService
    {
        private IRepository<Course> courseRepository;
        public CourseService(IRepository<Course> courseRepository)
        {
            this.courseRepository = courseRepository;

        }
        public IEnumerable<Course> GetCourses()
        {
            return courseRepository.GetAll();
        }

        public Course GetCourse(long id)
        {
            return courseRepository.Get(id);
        }

        public void InsertCourse(Course course)
        {
            courseRepository.Insert(course);
        }
        public void UpdateCourse(Course course)
        {
            courseRepository.Update(course);
        }

        public void DeleteCourse(long id)
        {
            Course course = GetCourse(id);
            courseRepository.Remove(course);
            courseRepository.Save();
        }
    }
}
