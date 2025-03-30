using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL
{
    public class CourseService
    {
        private readonly CourseRepository _courseRepository;
        public CourseService()
        {
            _courseRepository = new CourseRepository();
        }
        public List<tblCourses> GetAllCourses()
        {
            return _courseRepository.GetAllCourses();
        }
        public tblCourses AddCourse(tblCourses course)
        {
            return _courseRepository.AddCourse(course);
        }
        public tblCourses GetCourseById(int courseID)
        {
            return _courseRepository.GetCourseById(courseID);
        }
        public tblCourses UpdateCourse(tblCourses course)
        {
            return _courseRepository.UpdateCourse(course);
        }
        public bool DeleteCourse(int courseID)
        {
            return _courseRepository.DeleteCourse(courseID);
        }
    }
}
