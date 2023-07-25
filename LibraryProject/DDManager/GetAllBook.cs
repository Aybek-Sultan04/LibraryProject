using LibraryProject.Book;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.DDManager
{
    internal class GetAllBook
    {
        public static List<BookModel> GetBooks()
        {
            using (StreamReader reder = new StreamReader("Books.json", true))
            {
                try
                {
                    List<BookModel>? books = JsonConvert.DeserializeObject<List<BookModel>>(reder.ReadToEnd());
                    return books;
                }
                catch (Exception ex)
                {

                }
            }
                return null;
        }
    }
}
