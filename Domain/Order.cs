using System;

namespace library.Domain
{
    public class Order
    {
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public string BookName { get; set; }
        public int OrderSum { get; set; }
        public DateTime DateofIssue { get; set; }
        public int OrderDiscount { get; set; }
        public int LibrarianId { get; set; }
        public int ClientId { get; set; }
    }
}