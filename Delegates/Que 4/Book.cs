using System;
using System.Collections.Generic; 

class Book
{
    private string _title;
    private string _author;
    private double _amount;
    private int _noOfPages;

    public Book(string title, string author, double amount, int noOfPages)
    {
        _title = title;
        _author = author;
        _amount = amount;
        _noOfPages = noOfPages;
    }

    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }

    public string Author
    {
        get { return _author; }
        set { _author = value; }
    }

    public double Amount
    {
        get { return _amount; }
        set { _amount = value; }
    }

    public int NoOfPages
    {
        get { return _noOfPages; }
        set { _noOfPages = value; }
    }

    public static int CompareBook(Book book1, Book book2)
    {
        return book1.Title.CompareTo(book2.Title);
    }
}
