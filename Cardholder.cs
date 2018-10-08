using System;
using System.Collections.Generic;

namespace Library{

public class CardHolder{
    public string FullName {get;set;}
    public int Id {get;set;}
    private List<Book> _currentBooks = new List<Book>();
    public void CheckoutBook (Book book)
    {
        _currentBooks.Add(book);
    }
}
}