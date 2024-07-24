using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asssessment2
{
    public interface IRepository
    {
        public void CreateBook(Book book);
        public void UpdateBook(int id, int option);

        public List<Book> DisplayBooks();
        public Book GetBooKBYID(int id);
        public Book GetBooKBYName(string name);
        public List<Book> DisplayBooksByAuthor(string Author);
        public List<Book> DisplayBooksByAuthorAndPublisher(string Author, string Publisher);

    }
}
