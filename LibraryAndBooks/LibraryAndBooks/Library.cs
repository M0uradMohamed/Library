using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAndBooks
{
    internal class Library
    {
        public List<Book> books { get; set; }

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public (bool ,int) SearchBook ( string name)
        {
            for (int i = 0; i < books.Count; i++)
            {
                string[] fullname = books[i].Title.Split(" ");


                for (int y = 0; y < fullname.Length; y++)
                {
                    if (fullname[y] == name)
                    {
                       return (true ,i) ;
                    }
                }

            }
            return (false,-1);
        }
        public void BorrowBook(string name)
        {

            var chechisin = SearchBook(name);
            if (chechisin.Item1 == true)
            {
                if (books[chechisin.Item2].Availability == true)
                {
                    books[chechisin.Item2].Availability = false;
                }
                else
                {
                    Console.WriteLine($"{name} , This book is already borrowed");
                }
            }           
           else if (chechisin.Item1 ==false)
            {
                Console.WriteLine($"{name} , This book is not in the library");
            }
        }

        public void ReturnBook(string name)
        {
            var chechisin = SearchBook(name);
            if( chechisin.Item1 ==true )
            {
                if (books[chechisin.Item2].Availability==false)
                {
                    books[chechisin.Item2].Availability = true;
                }
                else
                {
                    Console.WriteLine($"{name} , This book is not borrowed");
                }
            }
          else  if (chechisin.Item1 == false)
            {
                Console.WriteLine($"{name} , This book is not from the library");
            }
        }
    }
}
