using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public abstract class Media
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearPublished { get; set; }
        public bool IsAvailable { get; set; } = true;
        public Media(string title, string author, int yearPublished)
        {
            Title = title;
            Author = author;
            YearPublished = yearPublished;
        }

        public abstract void DisplayInfo();
    }
}
