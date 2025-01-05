using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    public static void Main()
    {
        List<Book> Books = new List<Book>
        {
            new Book { Name = "Лісова пісня", Author = "Леся Українка", Year = new DateTime(1918, 11, 22), Genre = "Драма"},
            new Book { Name = "Кобзар", Author = "Тарас Шевченко", Year = new DateTime(1840, 2, 12), Genre = "Класика"},
            new Book { Name = "451 градус за Фаренгейтом", Author = "Рей Дуглас Бредбері", Year = new DateTime(1953, 9, 4), Genre = "Фантастика"},
            new Book { Name = "Дитя Дракули", Author = "Джонатан Барнс", Year = new DateTime(2023, 6, 7), Genre = "Фантастика"}
        };
        
        DateTime currentDate = DateTime.Now;

        var filterForYear = Books.Where(e => (currentDate - e.Year).TotalDays < 10 * 365);

        var filterForGenre = Books.Where(e => e.Genre == "Фантастика");
        
        Console.WriteLine("Книги, які були видані після 2010 року та належать до жанру \"Фантастика\":");

        foreach (var books in filterForYear)
        {
            Console.WriteLine(books);
        }

    }
}



class Book
{
    public string Name { get; set; }
    public string Author { get; set; }
    public DateTime Year { get; set; }
    public string Genre { get; set; }

    public override string ToString()
    {
        return $"Назва книги: {Name}\nАвтор: {Author}\nРік випуску: {Year.ToShortDateString()}\nЖанр: {Genre}.";
    }
}








