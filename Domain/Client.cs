using System;

namespace library.Domain
{
    public class Client
    {
        public int ClientId { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
    }
}