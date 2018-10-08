using System;

namespace Library
{
    public class Book
    {
public Book(){
    IsAvailable = true;
}
//          Make a Book class that has
// - Title property
public string Title {get;set;}
// - Author property
public string Author {get;set;}
// - ISBN (this will be a string) property
public string ISBN {get;set;}
public bool IsAvailable{get;set;}
        }
    }
