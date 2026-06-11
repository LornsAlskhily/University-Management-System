using UniversitySystem.Models;

namespace UniversitySystem.Interface
{
    public interface IPaymentRepository
    {
        bool AddPayment(Payment payment);
    }
}