using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.Books
{
    internal class Ebook : Book
    {
        public string FileType { get; set; }
        public Ebook(string isbn, string title, int year, double price, string file_type) : base(isbn, title, year, price)
        {
            base.ValidateInput(file_type, "File Type");
            this.FileType = file_type;
        }
        public void SendViaEmail(string email)
        {
            base.ValidateInput(email, nameof(email));
            Console.WriteLine($"Book is sent succefuly to email: ({email})");
        }
    }
}
