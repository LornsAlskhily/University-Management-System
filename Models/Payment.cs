using System;
using UniversitySystem.Enums;
namespace UniversitySystem.Models
{
    public class Payment
    {
        public string Id { get; set; }
        public decimal Amount { get; set; }
        public Status PaymentStatus { get; set; }
        public DateTime PayDate { get; set; }
        public DateTime ResolvedDate { get; set; }
        public string StudentId { get; set; }
        public string FinanceId { get; set; }
    }
}
