using library.Domain;
using library.Repository;
using Microsoft.AspNetCore.Mvc;

namespace library.Controllers
{
    [ApiController]
    [Route("/librarian")]
    public class LibrarianController : ControllerBase
    {
        [HttpPut]
        public Librarian Create(Librarian librarian)
        {
            Storage.LibrarianStorage.Create(librarian);
            return librarian;
        }

        [HttpGet]
        public Librarian Read(int librarianId)
        {
            return Storage.LibrarianStorage.Read(librarianId);
        }

        [HttpPost]
        public Librarian Update(int librarianId, Librarian newLibrarian)
        {
            return Storage.LibrarianStorage.Update(librarianId, newLibrarian);
        }

        [HttpDelete]
        public bool Delete(int librarianId)
        {
            return Storage.LibrarianStorage.Delete(librarianId); ;
        }
    }
}