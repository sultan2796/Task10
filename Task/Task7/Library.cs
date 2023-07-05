using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Library
    {
        private List<Book> Books;

        public Library()
        {
            Books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            if (Books.Exists(b => b.No == book.No))
            {
                Console.WriteLine(" No ilə kitab artıq mövcuddur.");
                return;
            }

            Books.Add(book);
        }

        public List<Book> GetFilteredBooks(string genre)
        {
            return Books.FindAll(book => book.Genre == genre);
        }

        public List<Book> GetFilteredBooks(decimal minPrice, decimal maxPrice)
        {
            return Books.FindAll(book => book.SalePrice >= minPrice && book.SalePrice <= maxPrice);
        }
    }
}
