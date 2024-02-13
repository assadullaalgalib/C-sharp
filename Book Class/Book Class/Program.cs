using System;
using System.Collections.Generic;

class Book
{
    public string Title { get; }
    public int Pages { get; }
    public int PublicationYear { get; }

    public Book(string title, int pages, int publicationYear)
    {
        Title = title;
        Pages = pages;
        PublicationYear = publicationYear;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Book> books = new List<Book>();

        while (true)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                break; // Stop reading books when an empty name is entered
            }

            Console.Write("Pages: ");
            if (int.TryParse(Console.ReadLine(), out int pages))
            {
                Console.Write("Publication year: ");
                if (int.TryParse(Console.ReadLine(), out int publicationYear))
                {
                    books.Add(new Book(name, pages, publicationYear));
                }
                else
                {
                    Console.WriteLine("Invalid input. Publication year should be an integer.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Pages should be an integer.");
            }
        }

        Console.Write("What information will be printed? ");
        string printOption = Console.ReadLine();

        Console.WriteLine();

        if (printOption == "everything")
        {
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title}, {book.Pages} pages, {book.PublicationYear}");
            }
        }
        else if (printOption == "title")
        {
            foreach (var book in books)
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}
