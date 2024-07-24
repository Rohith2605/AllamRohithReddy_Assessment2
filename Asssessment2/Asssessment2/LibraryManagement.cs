using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asssessment2
{
    public class LibraryManagement
    {
        public static void Main()
        {
            LibraryManagement Lm = new LibraryManagement();
            BookRepository bb = new BookRepository();


            try
            {

                do
                {
                    Console.WriteLine("Choose the Operation");
                    Console.WriteLine("1.CreateBook\n2.UpdateDetails\n3.DisplayALL\n4.DisplayBasedONParticularDetail\n5.Exit");
                    int option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            {
                                try
                                {
                                    Book temp = new Book();
                                    Console.WriteLine("Enter the Book Details");
                                    Console.WriteLine("Enter the BookId");
                                    temp.BookId = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter the BookName");
                                    temp.BookName = Console.ReadLine();
                                    Console.WriteLine("Enter the Price");
                                    temp.Price = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter the BookAuthor");
                                    temp.Author = Console.ReadLine();
                                    Console.WriteLine("Enter the Bookpublisher");
                                    temp.Publisher = Console.ReadLine();


                                    bb.CreateBook(temp);



                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }


                            }
                            break;
                        case 2:
                            {
                                Console.WriteLine("Select which detail need to be update");
                                Console.WriteLine("1.bookName\n2.price\n3.author\n4.publisher");
                                int op = int.Parse(Console.ReadLine());

                                Console.WriteLine("Enter the BookId");
                                int Id = int.Parse(Console.ReadLine());

                                bb.UpdateBook(Id, op);


                            }
                            break;
                        case 3:
                            {
                                List<Book> temp = bb.DisplayBooks();
                                foreach (Book book in temp)
                                {
                                    Console.WriteLine(book.ToString());

                                }

                            }
                            break;
                        case 4:
                            {
                                Console.WriteLine("Select by we can display b00k");
                                Console.WriteLine("1.bookId\n2.bookName\n3.author\n4.publisher");

                                int Display = int.Parse(Console.ReadLine());

                                switch (Display)
                                {
                                    case 1:
                                        {

                                            Console.WriteLine("Enter the BookId");
                                            int id = int.Parse(Console.ReadLine());
                                            Console.WriteLine(bb.GetBooKBYID(id).ToString());


                                        }
                                        break;

                                    case 2:
                                        {
                                            Console.WriteLine("Enter the BookName");
                                            string BookName = Console.ReadLine();

                                            Console.WriteLine(bb.GetBooKBYName(BookName).ToString());

                                        }
                                        break;
                                    case 3:
                                        {
                                            Console.WriteLine("Enter the BookAuthor");
                                            string Author = Console.ReadLine();
                                            List<Book> ls = bb.DisplayBooksByAuthor(Author);
                                            if (ls != null)
                                            {
                                                foreach (Book book in ls)
                                                {
                                                    Console.WriteLine(book.ToString());
                                                }
                                            }
                                            else { Console.WriteLine("There are no records"); }



                                        }
                                        break;
                                    case 4:
                                        {
                                            Console.WriteLine("Enter the BookAuthor and Bookpublisher");
                                            string Author = Console.ReadLine();
                                            string Publisher = Console.ReadLine();
                                            List<Book> ls = bb.DisplayBooksByAuthorAndPublisher(Author, Publisher);
                                            if (ls != null)
                                            {
                                                foreach (Book book in ls)
                                                {
                                                    Console.WriteLine(book.ToString());
                                                }
                                            }
                                            else { Console.WriteLine("There are no records"); }

                                        }
                                        break;

                                }



                            }
                            break;
                        case 5:
                            {
                                Environment.Exit(0);

                            }
                            break;
                        default:
                            Console.WriteLine("Enter correct option");
                            break;
                    }

                } while (true);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
