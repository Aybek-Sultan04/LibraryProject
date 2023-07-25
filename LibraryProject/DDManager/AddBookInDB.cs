using LibraryProject.Book;
using Newtonsoft.Json;
using System.Text.Json.Nodes;

namespace LibraryProject.DDManager
{
    internal class AddBookInDB
    {
        public static async Task AddAsync(BookModel book,bool action)
        {
            using (StreamWriter writerBook = new StreamWriter("Books.json", true))
            {
                try
                {
                    string addedbook = JsonConvert.SerializeObject(book, Formatting.Indented);
                    writerBook.WriteLine(addedbook);
                    await Task.Delay(10000);
                    if (action == true)
                        Console.WriteLine("Book has created!");
                    else Console.WriteLine("Book has update!");
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
