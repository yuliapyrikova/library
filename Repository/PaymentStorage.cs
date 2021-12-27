using library.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace library.Repository
{
    public class PaymentStorage
    {
        private Dictionary<int, Payment> Payments { get; } = new Dictionary<int, Payment>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public PaymentStorage() => Connection.Open();

        public void Create(Payment payment)
        {
            Payments.Add(payment.PaymentId, payment);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Payment Read(int paymentId)
        {
            return Payments[paymentId];
        }

        public Payment Update(int paymentId, Payment newPayment)
        {
            Payments[paymentId] = newPayment;
            return Payments[paymentId];
        }

        public bool Delete(int paymentId)
        {
            return Payments.Remove(paymentId);
        }
    }
}