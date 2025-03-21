using ConsoleApp3;

class Program
{
    static void Main(string[] args)
    {
        Library<Media> library = new Library<Media>();

        try
        {
            library.Add(new Book("Мастер и Маргарита", "Михаил Булгаков", 1967, 480, "Роман"));
            library.Add(new Movie("Бойцовский клуб", "Дэвид Финчер", 1999, 139, "Дэвид Финчер"));
            library.Add(new MusicAlbum("Double Live", "Гарт Брукс", 1998, " Гарта Брукса", 26));

            Console.WriteLine("Вся медиа:");
            library.PrintAll();

            Console.WriteLine("\nФильтр по годам 1999:");
            var filteredResults = library.FilterByYear(1999);
            foreach (var media in filteredResults)
            {
                media.DisplayInfo();
            }

            Console.WriteLine("\nПроверьте 'Бойцовский клуб':");
            library.CheckOutMedia("Бойцовский клуб");
            library.PrintAll();

            Console.WriteLine("\nВозврат 'Бойцовский клуб':");
            library.ReturnMedia("Бойцовский клуб");
            library.PrintAll();

            Console.WriteLine("\nПолучить все доступные медиа:");
            var availableMedia = library.GetAllAvailable();
            foreach (var media in availableMedia)
            {
                media.DisplayInfo();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}