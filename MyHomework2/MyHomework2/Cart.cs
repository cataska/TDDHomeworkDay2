using System;
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

        public decimal checkout()
        {
            decimal total = books.Sum(book => book.price);
            switch (books.Count)
            {
                case 4:
                    total *= 0.8M;
                    break;
                case 3:
                    total *= 0.9M;
                    break;
                case 2:
                    total *= 0.95M;
                    break;
            }
            return total;
        }
    }
}
