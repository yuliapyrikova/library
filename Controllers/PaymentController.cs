using library.Domain;
using library.Repository;
using Microsoft.AspNetCore.Mvc;

namespace library.Controllers
{
    [ApiController]
    [Route("/payment")]
    public class PaymentController : ControllerBase
    {
        [HttpPut]
        public Payment Create(Payment payment)
        {
            Storage.PaymentStorage.Create(payment);
            return payment;
        }

        [HttpGet]
        public Payment Read(int paymentId)
        {
            return Storage.PaymentStorage.Read(paymentId);
        }

        [HttpPost]
        public Payment Update(int paymentId, Payment newPayment)
        {
            return Storage.PaymentStorage.Update(paymentId, newPayment);
        }

        [HttpDelete]
        public bool Delete(int paymentId)
        {
            return Storage.PaymentStorage.Delete(paymentId); ;
        }
    }
}