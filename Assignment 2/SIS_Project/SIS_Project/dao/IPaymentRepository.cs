using System.Collections.Generic;
using SIS_Project.entity;

namespace SIS_Project.dao
{
    public interface IPaymentRepository
    {
        void AddPayment(Payment payment);
        List<Payment> GetPaymentsByStudentId(int studentId);
    }
}
