using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Library<T> : IMediaManager<T> where T : Media
    {
        private List<T> mediaList = new List<T>();
        private Dictionary<string, T> mediaDictionary = new Dictionary<string, T>();

        public void Add(T item)
        {
            if (mediaDictionary.ContainsKey(item.Title))
            {
                throw new InvalidOperationException($"Медиа с названием '{item.Title}' уже существует.");
            }
            mediaList.Add(item);
            mediaDictionary[item.Title] = item;
        }
        public bool Remove(string title)
        {
            if (!mediaDictionary.ContainsKey(title))
            {
                throw new KeyNotFoundException($"Media with title '{title}' not found.");
            }
            var item = mediaDictionary[title];
            mediaList.Remove(item);
            return mediaDictionary.Remove(title);
        }

        public T FindByTitle(string title)
        {
            if (!mediaDictionary.ContainsKey(title))
            {
                throw new KeyNotFoundException($"Media with title '{title}' not found.");
            }
            return mediaDictionary[title];
        }

        public IEnumerable<T> FilterByYear(int year)
        {
            return mediaList.Where(m => m.YearPublished == year);
        }

        public IEnumerable<T> GetAllAvailable()
        {
            return mediaList.Where(m => m.IsAvailable);
        }

        public void CheckOutMedia(string title)
        {
            var media = FindByTitle(title);
            if (!media.IsAvailable)
            {
                throw new InvalidOperationException($"Media '{title}' is already checked out.");
            }
            media.IsAvailable = false;
        }

        public void ReturnMedia(string title)
        {
            var media = FindByTitle(title);
            if (media.IsAvailable)
            {
                throw new InvalidOperationException($"Media '{title}' is already available.");
            }
            media.IsAvailable = true;
        }

        public void PrintAll()
        {
            foreach (var media in mediaList)
            {
                media.DisplayInfo();
            }
        }
    }
}
}
