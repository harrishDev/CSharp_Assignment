using System.Collections.Generic;
using SIS_Project.entity;

namespace SIS_Project.dao
{
    public interface ICourseRepository
    {
        void AddCourse(Course course);
        void UpdateCourse(Course course);
        void DeleteCourse(int courseId);
        Course GetCourseById(int courseId);
        List<Course> GetAllCourses();
    }
}
