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
            return CalcPrice(this.books);
        }

        private decimal CalcPrice(IEnumerable<Book> books)
        {
            decimal total = 0;
            if (!books.Any())
            {
                return total;
            }

            var series = books.GroupBy(b => b.volume).Select(b => b.First());
            total += ApplyDiscount(series);
            total += CalcPrice(books.Except(series));
            return total;
        }

        private decimal ApplyDiscount(IEnumerable<Book> books)
        {
            decimal total = books.Sum(book => book.price);
            switch (books.Count())
            {
                case 5:
                    total *= 0.75M;
                    break;
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
