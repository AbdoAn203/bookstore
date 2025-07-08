using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bookstore.Books;
namespace bookstore.Services
{
    internal class ShippingService
    {
        public Dictionary<Book, string> service = new();

        public void Subscribe(Book book, string address)
        {
            service[book] = address;
        }
    }
}
