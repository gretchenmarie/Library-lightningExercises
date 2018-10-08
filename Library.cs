using System;
using System.Collections.Generic;

namespace Library
{

    public class Library
    {
        public Library(List<Book> initialInventory, string name, string address)
        {
            _listBooks = initialInventory;
            Name = name;
            Address = Address;
        }
        // Make a Library class that has:
        // - Private List of Books (remember casing and naming convention here)
        private List<Book> _listofBooks = new List<Book>();
        // - Public Method to add a Book to the List of Books
         public Library(List<Book> initialInventory, string name, string address)
        {
            _listBooks = initialInventory;
            Name = name;
            Address = address;
        }

        public string Name { get; set; }
        public string Address { get; set; }
        private List<Book> _listBooks = new List<Book>();

        public void AddToInventory(Book book)
        {
            _listBooks.Add(book);
        }

        public void Checkout(string isbn, CardHolder cardHolder)
        {
            foreach(Book book in _listBooks)
            {
                if(book.ISBN == isbn && book.IsAvailable)
                {
                    cardHolder.CheckoutBook(book);
                    book.IsAvailable = false;
                }
            }
        }

        // "A", "B", "C"
        // isbn = "B"
        // isbn = "D"
        public bool IsAvailable(string isbn)
        {
            foreach(Book book in _listBooks)
            {
                if(book.ISBN == isbn)
                {
                    return book.IsAvailable;
                }
            }

            return false;
}

    }
}


