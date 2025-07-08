using bookstore.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.Services
{
    internal class MailService
    {
        public Dictionary<Book, string> service = new();
        public void Subscribe(Book book, string email)
        {
            service[book] = email;
        }
    }
}
