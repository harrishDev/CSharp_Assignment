using System.Collections.Generic;
using SIS_Project.entity;

namespace SIS_Project.dao
{
    public interface ITeacherRepository
    {
        void AddTeacher(Teacher teacher);
        void DeleteTeacher(int teacherId);
        List<Teacher> GetAllTeachers();
    }
}
