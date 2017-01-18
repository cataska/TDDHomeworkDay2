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
            return CalcPrice(this.books, 0);
        }

        private decimal CalcPrice(IEnumerable<Book> books, decimal total)
        {
            if (!books.Any())
            {
                return total;
            }

            var series = books.GroupBy(b => b.volume).Select(b => b.First());
            total += ApplyDiscount(series);
            return CalcPrice(books.Except(series), total);
        }

        private decimal ApplyDiscount(IEnumerable<Book> series)
        {
            decimal total = series.Sum(book => book.price);
            switch (series.Count())
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
