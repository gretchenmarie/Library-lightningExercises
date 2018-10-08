using System;
using System.Collections.Generic;



namespace Library
{
    class Library
    {
        static void Main(string[] args)
        {
            Book ChamberofSecrets = new Book()
            {
                Title = "Chamber of Secrets",
                Author = "jk rowling",
                ISBN = "123h456"
            };

            Book AnotherBook = new Book()
            {  Title = "Chamber of Secrets",
                Author = "jk rowling",
                ISBN = "123h456"
            };


            Book Frankenstein = new Book()
            {
                Title = "Frankenstein",
                Author = "m shelley",
                ISBN = "098g098"
            };

            Book ReadyPlayerOne = new Book()
            {
                Title = "Ready Player One",
                Author = "one",
                ISBN = "97g987"
            };

            Book book1 = new Book()
            {
                Title = "Book1",
                Author = "Author1",
                ISBN = "1A"
            };

            Book book2 = new Book()
            {
                Title = "Book2",
                Author = "Author2",
                ISBN = "2B",
                IsAvailable = false
            };
            Console.WriteLine($"book2 isavaialble = {book2.IsAvailable}");

            List<Book> books = new List<Book>(){
                book1, book2
            };
            Library library = new Library(books, "Downtown Library", "Main street");

            library.AddToInventory(ChamberofSecrets);
            library.AddToInventory(AnotherBook);
            library.AddToInventory(Frankenstein);
            library.AddToInventory(ReadyPlayerOne);

            if (library.IsAvailable("2B"))
            {
                Console.WriteLine("2B is available");
            }
            else
            {
                Console.WriteLine("2B is unavailable");
            }

        }
    }
}
