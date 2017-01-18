using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace MyHomework2
{
    class Cart
    {
        private List<Book> books;

        public Cart()
        {
            this.books = new List<Book>();
        }

        public void add(Book book)
        {
            books.Add(book);
        }

        public int checkout()
        {
            return books.Sum(book => book.price);
        }
    }
}