using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.Books
{
    internal class Demo : Book
    {
        public Demo(string isbn, string title, int year) : base (isbn, title, year)
        {
            Price = 0;
            forSale = false;
        }
    }
}
