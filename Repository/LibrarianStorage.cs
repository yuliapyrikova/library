using library.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace library.Repository
{
    public class LibrarianStorage
    {
        private Dictionary<int, Librarian> Librarians { get; } = new Dictionary<int, Librarian>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public LibrarianStorage() => Connection.Open();

        public void Create(Librarian librarian)
        {
            Librarians.Add(librarian.LibrarianId, librarian);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Librarian Read(int librarianId)
        {
            return Librarians[librarianId];
        }

        public Librarian Update(int librarianId, Librarian newLibrarian)
        {
            Librarians[librarianId] = newLibrarian;
            return Librarians[librarianId];
        }

        public bool Delete(int librarianId)
        {
            return Librarians.Remove(librarianId);
        }
    }
}