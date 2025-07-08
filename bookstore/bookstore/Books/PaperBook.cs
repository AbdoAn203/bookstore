using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.Books
{
    internal class PaperBook : Book
    {
        public double Stock { get; set; }
        public bool Shippable { get; set; }
        public PaperBook(string isbn,string title, int year, double price, double stock, bool shippable) : 
            base (isbn, title, year, price)
        {
            base.ValidateInput(stock, nameof(stock));
            Stock = stock;
        }
    }
}
