using System;
using System.Data.SqlClient;
using UniversitySystem.Interface;
using UniversitySystem.Models;

namespace UniversitySystem.Repositories
{
    public class PaymentRepositoryADO : IPaymentRepository
    {

        public PaymentRepositoryADO()
        {

        }

        public bool AddPayment(Payment payment)
        {
            using (SqlConnection conn = new SqlConnection(ConnectWithDB.ConnectionString))
            {
                string qurey = "insert into Payment values (@id,@amount,@paymentStatus,@payDate,@resolvedDate,@studentId,@financeId";
                conn .Open();
                using(SqlCommand cmd = new SqlCommand(qurey,conn)) {


                   cmd.Parameters.AddWithValue("@id", payment.Id);
                   cmd.Parameters.AddWithValue("@amount",payment.Amount);
                   cmd.Parameters.AddWithValue("@paymentStatus",payment.PaymentStatus);
                   cmd.Parameters.AddWithValue("@payDate",payment.PayDate);
                   cmd.Parameters.AddWithValue("@resolvedDate",string.IsNullOrEmpty(payment.ResolvedDate.ToString()) ? DBNull.Value : (object)payment.ResolvedDate);
                   cmd.Parameters.AddWithValue("@studentId",payment.StudentId);
                   cmd.Parameters.AddWithValue("@financeId",payment.FinanceId);
 
                    return cmd.ExecuteNonQuery() > 0 ? true : false;




                }
            }
        }

    }
}
