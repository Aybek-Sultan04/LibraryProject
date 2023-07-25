using LibraryProject.Book;
using LibraryProject.DDManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.CRUD
{
    internal class CreatBook
    {
        public static void Creat(bool action)
        {
            BookModel book = new BookModel();
            try
            {
                Console.Write("Name of the Book: ");
                book.BookName = Console.ReadLine();
                Console.WriteLine(new string('-', 20));
                Console.Write("Page of the Book: ");
                book.PageOfBook = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(new string('-', 20));
                Console.Write("Price:");
                book.Price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(new string('-', 20));
                Console.Write("Autor the book: ");
                book.Autor = Console.ReadLine();
                Console.WriteLine(new string('-', 20));
                Console.Write("Date of publication");
                book.PublicationDate = DateOnly.Parse(Console.ReadLine());
                book.IdBook = new Guid();
                Console.Clear();
                var creater = AddBookInDB.AddAsync(book,action);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
