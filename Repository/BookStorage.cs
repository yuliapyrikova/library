using library.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace library.Repository
{
    public class BookStorage
    {
        private Dictionary<int, Book> Books { get; } = new Dictionary<int, Book>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public BookStorage() => Connection.Open();

        public void Create(Book book)
        {
            Books.Add(book.BookId, book);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Book Read(int bookId)
        {
            return Books[bookId];
        }

        public Book Update(int bookId, Book newBook)
        {
            Books[bookId] = newBook;
            return Books[bookId];
        }

        public bool Delete(int bookId)
        {
            return Books.Remove(bookId);
        }
    }
}