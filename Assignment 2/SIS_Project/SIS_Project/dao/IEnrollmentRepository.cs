using System.Collections.Generic;
using SIS_Project.entity;

namespace SIS_Project.dao
{
    public interface IEnrollmentRepository
    {
        void AddEnrollment(Enrollment enrollment);
        void DeleteEnrollment(int enrollmentId);
        List<Enrollment> GetAllEnrollments();
    }
}
