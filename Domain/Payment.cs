using System;

namespace library.Domain
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int OrderId { get; set; }
        public int OrderSum { get; set; }
        public int OrderDiscount { get; set; }
    }
}