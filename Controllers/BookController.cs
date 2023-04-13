using Models;

namespace Controllers
{
    public class BookController
    {
        public void InsertBook(string t, string a)
        {
            Book book = new();
            book.Title = t;
            book.Author = a;
            book.Id = Guid.NewGuid();
        }
    }
}