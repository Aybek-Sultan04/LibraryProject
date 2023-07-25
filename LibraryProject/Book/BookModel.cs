using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Book
{
    internal class BookModel
    {
        public string? BookName { get; set; }
        public int PageOfBook { get; set; }
        public double Price { get; set; }
        public string? Autor { get; set; }
        public DateOnly PublicationDate { get; set; }
        public Guid IdBook { get; set; }
    }
}
