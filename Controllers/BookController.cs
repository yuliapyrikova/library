using library.Domain;
using library.Repository;
using Microsoft.AspNetCore.Mvc;

namespace library.Controllers
{
    [ApiController]
    [Route("/book")]
    public class BookController : ControllerBase
    {
        [HttpPut]
        public Book Create(Book book)
        {
            Storage.BookStorage.Create(book);
            return book;
        }

        [HttpGet]
        public Book Read(int bookId)
        {
            return Storage.BookStorage.Read(bookId);
        }

        [HttpPost]
        public Book Update(int bookId, Book newBook)
        {
            return Storage.BookStorage.Update(bookId, newBook);
        }

        [HttpDelete]
        public bool Delete(int bookId)
        {
            return Storage.BookStorage.Delete(bookId); ;
        }
    }
}