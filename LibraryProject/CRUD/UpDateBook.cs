using LibraryProject.Book;
using LibraryProject.DDManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.CRUD
{
    internal class UpDateBook
    {
        public static void UpDate()
        {
            Console.Write("Enter Id book:");
            string? bookid = Console.ReadLine();
            List<BookModel> books = GetAllBook.GetBooks();
            var book = (from currentBook in books
                        where currentBook.IdBook.Equals(bookid)
                        select currentBook).ToList();
            if (book != null)
            {
                book.Remove(book[0]);
                CreatBook.Creat(false);
            }
            else
            {
                Console.WriteLine("this id not found!");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
