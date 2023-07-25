using LibraryProject.Book;
using LibraryProject.DDManager;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.CRUD
{
    internal class ShowAllBook
    {
        public static void Show()
        {
            List<BookModel> books = GetAllBook.GetBooks();
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
            Console.ReadKey();
            Console.Clear();

        }
    }
}
