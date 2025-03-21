using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public interface IMediaManager<T> where T : Media
    {  
        void Add(T item); //добавить элемент в коллекцию.
        bool Remove(string title); //добавить элемент в коллекцию.
        T FindByTitle(string title); //найти элемент по названию.
        IEnumerable<T> FilterByYear(int year); //фильтровать элементы по году выпуска.
        IEnumerable<T> GetAllAvailable(); //получить все доступные элементы.

    }
}
