using System.Collections.Generic;
using SIS_Project.entity;

namespace SIS_Project.dao
{
    public interface IStudentRepository
    {
        void AddStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(int studentId);
        Student GetStudentById(int studentId);
        List<Student> GetAllStudents();
    }
}
