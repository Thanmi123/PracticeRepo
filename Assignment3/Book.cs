using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Book
    {
        public int Id;
        public string Name;
        public string[] language;
        public int price;
        public string Author;
        public string Publisher;
    }
    class BookRepository
    {
        public Book[] books = new Book[5];
        public int idx = 0;
        public void AddBook(Book book)
        {
            if (idx <= books.Length)
            {
                books[idx] = book;
                idx++;
            }
            else
            {
                Console.WriteLine("Book is Full!!!");
            }
        }
        public Book[] Getbooks() //Get All books
        {
            return books;
        }
        public Book[] GetBookByAuthor(string author) //Get books by Author
        {
            Book[] author_books = new Book[books.Length];
            int idx = 0;
            foreach (Book book in books)
            {
                if (book != null)
                {
                    if (book.Author == author)
                    {
                        author_books[idx] = book;
                        idx++;
                    }
                }
            }
            return author_books;
        }
        public Book[] GetBookByPublisher(string publisher) //Get books by Publisher
        {
            Book[] publisher_books = new Book[books.Length];
            int idx = 0;
            foreach (Book book in books)
            {
                if (book != null)
                {
                    if (book.Publisher == publisher)
                    {
                        publisher_books[idx] = book;
                        idx++;
                    }
                }
            }
            return publisher_books;
        }
        public Book[] GetBookByName(string name) //Get books by Name
        {
            Book[] name_books = new Book[books.Length];
            int idx = 0;
            foreach (Book book in books)
            {
                if (book != null)
                {
                    if (book.Name == name)
                    {
                        name_books[idx] = book;
                        idx++;
                    }
                }
            }
            return name_books;
        }


    }
    class Book_Main
    {
        static void Main(string[] args)
        {
            BookRepository bookRepository = new BookRepository();
            do
            {
                Console.WriteLine("1.Add Book");
                Console.WriteLine("2.Get Book By Name");
                Console.WriteLine("3.Get Book By Author");
                Console.WriteLine("4.Get Book By Publisher");
                Console.WriteLine("5.Get All Books");
                Console.WriteLine("6.Exit");
                Console.WriteLine("Enter U r Choice");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {
                            Book book = new Book();
                            Console.WriteLine("Enter Name");
                            book.Name = Console.ReadLine();
                            Console.WriteLine("Enter Author");
                            book.Author = Console.ReadLine();
                            Console.WriteLine("Enter Publisher");
                            book.Publisher = Console.ReadLine();
                            Console.WriteLine("Enter price");
                            book.price = Convert.ToInt16(Console.ReadLine());
                            book.Id = new Random().Next();
                            book.language = new string[] { "Malayalam", "Hindi", "Tamil" };
                            bookRepository.AddBook(book);

                        }
                        break;
                    case 2: //Get book by name
                        {
                            Console.WriteLine("Enter name");
                            string name = Console.ReadLine();
                            Book[] books = bookRepository.GetBookByName(name);
                            foreach (Book book in books)
                            {
                                if (book != null)
                                {
                                    Console.WriteLine($"Id:{book.Id}  Name:{book.Name}  Author:{book.Author}  Publisher:{book.Publisher}  Price:{book.price}");
                                    Console.Write("Languages available: ");
                                    foreach (string s in book.language) Console.Write(s + " ");
                                }
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 3: //Get book by author
                        {
                            Console.WriteLine("Enter Author");
                            string author = Console.ReadLine();
                            Book[] books = bookRepository.GetBookByAuthor(author);
                            foreach (Book book in books)
                            {
                                if (book != null)
                                {
                                    Console.WriteLine($"Id:{book.Id} Name:{book.Name} Author:{book.Author} Publisher:{book.Publisher} Price:{book.price}");
                                    Console.Write("Languages available: ");
                                    foreach (string s in book.language) Console.Write(s + " ");
                                }
                                Console.WriteLine();
                            }
                        }
                        break;

                    case 4: //Get book by publisher
                        {
                            Console.WriteLine("Enter Publisher");
                            string publisher = Console.ReadLine();
                            Book[] books = bookRepository.GetBookByPublisher(publisher);
                            foreach (Book book in books)
                            {
                                if (book != null)
                                {
                                    Console.WriteLine($"Id:{book.Id} Name:{book.Name} Author:{book.Author} Publisher:{book.Publisher} Price:{book.price}");
                                    Console.Write("Languages available: ");
                                    foreach (string s in book.language) Console.Write(s + " ");
                                }
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 5: //Get books
                        {
                            Book[] books = bookRepository.Getbooks();
                            foreach (Book book in books)
                            {
                                if (book != null)
                                {
                                    Console.WriteLine($"Id:{book.Id} Name:{book.Name} Author:{book.Author} Publisher:{book.Publisher} Price:{book.price}");
                                    Console.Write("Languages available: ");
                                    foreach (string s in book.language) Console.Write(s + " ");
                                }
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 6:
                        {
                            Environment.Exit(0);
                        }
                        break;
                }
            } while (true);
        }
    }
}
