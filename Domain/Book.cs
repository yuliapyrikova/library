using System;

namespace library.Domain
{
    public class Book
    {
        public int BookId { get; set; }
        public string Author { get; set; }
        public DateTime DateOfAction { get; set; }
        public string Genre { get; set; }
    }
}