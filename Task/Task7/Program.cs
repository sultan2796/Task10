using Task7;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Kitabların sayını daxil edin");
        int bookCount = int.Parse(Console.ReadLine());

        Library library = new Library();

        for (int i = 0; i < bookCount; i++)
        {
            Book book = CreateBook();
            library.AddBook(book);
        }

        Console.Write("Kitabları filtrlemek isteyirsiniz? (y/n) ");
        string filterChoice = Console.ReadLine();

        if (filterChoice.ToLower() == "n")
        {
            ShowAllBooks(library);
        }
        else if (filterChoice.ToLower() == "y")
        {
            Console.Write("Filtr novunu secin:\n1 - Janr üzrə\n2 - Qiymet Aralıgına gore\nSeciminizi daxil edin: ");
            string filterType = Console.ReadLine();

            if (filterType == "1")
            {
                Console.Write("Janrı daxil edin ");
                string genre = Console.ReadLine();
                List<Book> filteredBooks = library.GetFilteredBooks(genre);
                ShowBooks(filteredBooks);
            }
            else if (filterType == "2")
            {
                Console.Write("Minimum qiymeti daxil edin ");
                decimal minPrice = decimal.Parse(Console.ReadLine());
                Console.Write("Maksimum qiymeti daxil edin ");
                decimal maxPrice = decimal.Parse(Console.ReadLine());
                List<Book> filteredBooks = library.GetFilteredBooks(minPrice, maxPrice);
                ShowBooks(filteredBooks);
            }
            else
            {
                Console.WriteLine("Yanlıs filtr növü.");
            }
        }
        else
        {
            Console.WriteLine("Yanlıs secim.");
        }
    }

    static Book CreateBook()
    {
        Book book = new Book();

        Console.Write("Kitab nömrəsini daxil edin ");
        book.No = int.Parse(Console.ReadLine());

        Console.Write("Kitabın adını daxil edin ");
        book.Name = Console.ReadLine();

        Console.Write("Kitabın qiymətini daxil edin ");
        book.CostPrice = decimal.Parse(Console.ReadLine());

        Console.Write("Kitabın satış qiymətini daxil edin:");
        book.SalePrice = decimal.Parse(Console.ReadLine());

        Console.Write("Kitab ehtiyatının sayını daxil edin: ");
        book.StockCount = int.Parse(Console.ReadLine());

        Console.Write("Kitab janrını daxil edin ");
        book.Genre = Console.ReadLine();

        return book;
    }
}
   