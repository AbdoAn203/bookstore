using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.Books
{
    internal abstract class Book
    {
        public string ISBN { get; set; }
        public int Year { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }

        protected bool forSale = true;
        protected Book(string isbn, string title, int year)
        {
            ValidateInput(isbn, nameof(isbn)); this.ISBN = isbn;
            ValidateInput(title, nameof(title)); this.Title = title;
            ValidateInput(year, nameof(year)); this.Year = year;
        }
        protected Book(string isbn, string title, int year, double price) : this(isbn, title, year)
        {
            ValidateInput(price, nameof(price)); this.Price = price;
        }

        protected void ValidateInput<T> (T input, string name)
        {
            
            var msg = $"Please enter a valid {name}";

            switch (input)
            {
                case string s:
                    if (string.IsNullOrWhiteSpace(s)) throw new Exception(msg);
                    break;
                case double d:
                    if (d<= 0) throw new Exception(msg);
                    break;
                case int y:
                    if (y > DateTime.Now.Year) throw new Exception(msg);
                    break;
            }
        }
        public override string ToString()
        {
            return $"{ISBN}: {Title}, {Year}";
        }
    }
}
