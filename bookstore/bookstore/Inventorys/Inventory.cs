using bookstore.Books;
using bookstore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.Inventorys
{
    internal class Inventory
    {
        public List<Book> Books { get; set; }
        public ShippingService ShippingService { get; set; }
        public MailService MailService { get; set; }
        public Inventory() { 
            Books = new List<Book>();

        }

        public void Add(Book book) 
        { 
            try
            { 
                Books.Add(book); 
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Book {book.ISBN} is added successfuly");
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ResetColor();
            }
        }
        public List<Book> Remove(int no_of_years)
        {
            List<Book> outdatedBooks = new List<Book>();
            foreach (var b in Books) 
            { 
                if (DateTime.Now.Year - b.Year >= no_of_years)
                {   
                    outdatedBooks.Add(b);
                    Console.WriteLine($"Book with ISBN {b.ISBN} is removed");
                }
            }
            foreach (var b in outdatedBooks)
            {
                Books.Remove(b);
            }
            return outdatedBooks;
        }

        public void Buy(string isbn, int quantity, string email, string address)
        {
            var book = Books.FirstOrDefault(b => b.ISBN == isbn);
            if (book == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Book with ISBN ({isbn}) is not found");
                Console.ResetColor();
                return;
            }
            if (book is PaperBook)
            {
                var pb = book as PaperBook;
                var new_stock = pb.Stock - quantity;
                if (new_stock < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("There is no enough stock for this quantity.");
                    Console.ResetColor();
                    return;
                }
                pb.Stock = new_stock;
                if (pb.Shippable) ShippingService.Subscribe(pb, address);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Book ({pb.Title}) is purchased successfuly");
                Console.WriteLine($"Total price : ${quantity * pb.Price}");
            }
            else if (book is Ebook)
            {
                var eb = book as Ebook;
                MailService.Subscribe(eb, email);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Book ({eb.Title}) is purchased successfuly");
                Console.WriteLine($"Total price : ${quantity * eb.Price}");
            }
            else if (book is Demo)
            {
                Console.WriteLine("Sorry This Book is not for sale");
            }

        }


    }
}
