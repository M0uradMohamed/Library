using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAndBooks
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool Availability { get; set; }

        public Book (string Title , string Author , string ISBN ) 
        {
            this.Title = Title;
            this.Author = Author;
            this.ISBN = ISBN;
            Availability = true;
        }


    }
}
