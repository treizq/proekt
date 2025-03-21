using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Book : Media
    {
        public int PageCount { get; set; }
        public string Genre { get; set; }

        public Book(string title, string author, int yearPublished, int pageCount, string genre)
            : base(title, author, yearPublished)
        {
            PageCount = pageCount;
            Genre = genre;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Book: {Title} by {Author}, {YearPublished}, {PageCount} pages, Genre: {Genre}");
        }
    }

}