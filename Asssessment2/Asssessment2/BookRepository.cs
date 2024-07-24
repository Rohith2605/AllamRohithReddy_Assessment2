using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asssessment2
{
    class BookRepository : IRepository
    {
        public List<Book> books = new List<Book>();
        public void CreateBook(Book book)
        {
            books.Add(book);
        }

        public List<Book> DisplayBooks()
        {

            return books;
        }

        public List<Book> DisplayBooksByAuthor(string Author)
        {
            List<Book> temp = new List<Book>();
            foreach (Book book in books)
            {
                if (Author.Equals(book.Author))
                {
                    temp.Add(book);
                }
            }
            if (temp.Count > 0)
            {
                return temp;
            }
            else
            {
                return null;
            }
        }

        public List<Book> DisplayBooksByAuthorAndPublisher(string Author, string Publisher)
        {
            try
            {
                List<Book> temp = new List<Book>();
                foreach (Book book in books)
                {
                    if (Author.Equals(book.Author) && Publisher.Equals(book.Publisher))
                    {
                        temp.Add(book);
                    }
                }
                if (temp.Count > 0)
                {
                    return temp;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Book GetBooKBYID(int id)
        {
            try
            {
                Book temp = new Book();
                foreach (Book book in books)
                {
                    if (id == book.BookId)
                    {
                        temp = book;
                        return temp;
                    }
                }
                return null;
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                return null;
            }

        }

        public Book GetBooKBYName(string name)
        {
            try
            {
                Book temp = new Book();
                foreach (Book book in books)
                {
                    if (name.Equals(book.BookName))
                    {
                        temp = book;
                        return temp;
                    }
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateBook(int id, int option)
        {
            foreach (Book book in books)
            {
                if (id == book.BookId)
                {
                    switch (option)
                    {
                        case 1:
                            {
                                Console.WriteLine("Enter the Bookname");
                                string bookname = Console.ReadLine();
                                book.BookName = bookname;
                            }
                            break;
                        case 2:
                            {
                                Console.WriteLine("Enter the price");
                                double price = double.Parse(Console.ReadLine());
                                book.Price = price;
                            }
                            break;
                        case 3:
                            {
                                Console.WriteLine("Enter the BookAuthor");
                                string Author = Console.ReadLine();
                                book.Author = Author;
                            }
                            break;
                        case 4:
                            {
                                Console.WriteLine("Enter the Bookpublisher");
                                string Publisher = Console.ReadLine();
                                book.Publisher = Publisher;

                            }
                            break;
                        default:
                            {
                                Console.WriteLine("Enter the Correct Choice");
                            }
                            break;
                    }
                }
                else
                    Console.WriteLine("There is no record");
            }
        }
    }
}
