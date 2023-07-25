using LibraryProject.DDManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Book
{
    internal class Option
    {
        public static void Expensive()
        {
            var expensiveBook = (from exp in GetAllBook.GetBooks()
                                 orderby exp.Price
                                 select exp).ToList();
            Console.WriteLine(expensiveBook[0]);
            Console.ReadKey();
            Console.Clear();
        }
        public static void Cheap() 
        {
            var expensiveBook = (from exp in GetAllBook.GetBooks()
                                 orderby exp.Price
                                 descending
                                 select exp).ToList();
            Console.WriteLine(expensiveBook[0]);
            Console.ReadKey();
            Console.Clear();
        }
        public static void Fat()
        {
            var expensiveBook = (from exp in GetAllBook.GetBooks()
                                 orderby exp.PageOfBook
                                 select exp).ToList();
            Console.WriteLine(expensiveBook[0]);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
